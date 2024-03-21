// LoginPage

using GalaSoft.MvvmLight.Ioc;
using Quarrel.Dialogs;
using Quarrel.SubPages.Interfaces;
using Quarrel.ViewModels.Helpers;
using Quarrel.ViewModels.Services.Analytics;
using Quarrel.ViewModels.Services.Discord.Rest;
using Quarrel.ViewModels.Services.Navigation;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.Web.Http;

namespace Quarrel.SubPages
{
    /// <summary>
    /// The sub page to show the login prompt.
    /// </summary>
    public sealed partial class LoginPage : UserControl, IFullscreenSubPage
    {
        private static readonly string UserAgentID = "Mozilla/5.0 (iPhone; CPU iPhone OS 16_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.6 Mobile/15E148 Safari/604.1";
        private IAnalyticsService _analyticsService = null;
        private IDiscordService _discordService = null;
        private ISubFrameNavigationService _subFrameNavigationService = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage"/> class.
        /// </summary>
        public LoginPage()
        {
            this.InitializeComponent();
            AnalyticsService.Log(Constants.Analytics.Events.LoginOpened);
        }

        /// <inheritdoc/>
        public bool Hideable { get; } = false;

        private IAnalyticsService AnalyticsService
        {
            get
            {
                return _analyticsService ?? 
                    (_analyticsService = SimpleIoc.Default.GetInstance<IAnalyticsService>());
            }
        }

        private IDiscordService DiscordService
        {
            get
            {
                return _discordService 
                    ?? (_discordService = SimpleIoc.Default.GetInstance<IDiscordService>());
            }
        }

        private ISubFrameNavigationService SubFrameNavigationService
        {
            get
            {
                return _subFrameNavigationService ?? 
                    (_subFrameNavigationService = SimpleIoc.Default.GetInstance<ISubFrameNavigationService>());
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Collapsed;
            CaptchaView.Visibility = Visibility.Visible;

            HttpRequestMessage requestMessage = new HttpRequestMessage(
                                    HttpMethod.Post, 
                                    new Uri("https://discord.com/app"));

            requestMessage.Headers.Add("User-Agent", UserAgentID);

            CaptchaView.NavigateWithHttpRequestMessage(requestMessage);
        }

        private async void LoginWithToken_Click(object sender, RoutedEventArgs e)
        {
           
            var dialog = new TokenDialog();
            await dialog.ShowAsync();

            if (!string.IsNullOrWhiteSpace(dialog.Token))
            {
                Debug.WriteLine("[i] LoginPage: getting token ok");

                MainContent.Visibility = Visibility.Visible;
                CaptchaView.Visibility = Visibility.Collapsed;

                await DiscordService.Login(dialog.Token, true);
                SubFrameNavigationService.GoBack();               
            }
            else
            {
                Debug.WriteLine("[i] LoginPage: getting token failed");
            }
        }


        private async void ForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://discord.com/"));
        }

        private void Token_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                LoginButton_Click(null, null);
            }
        }

        private async void ScriptNotify(object sender, NotifyEventArgs e)
        {
            // Respond to the script notification.

            if (e.CallingUri.AbsolutePath == "/app") 
            {
                string token = await GetTokenFromWebView();
                if (!string.IsNullOrEmpty(token))
                {
                    await DiscordService.Login(token, true);
                    SubFrameNavigationService.GoBack();
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1118:Parameter should not span multiple lines", Justification = "Raw string")]
        private async void CaptchaView_OnNavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            _ = sender.InvokeScriptAsync(
                "eval",
                new[]
                {
                @"
                    var pushState = history.pushState;
                    history.pushState = function () {
                        pushState.apply(history, arguments);
	                    window.external.notify('');
                    };
                ",
                });

            if (args.Uri.AbsolutePath == "/app")
            {
                string token = await GetTokenFromWebView();
                if (!string.IsNullOrEmpty(token))
                {
                    await DiscordService.Login(token, true);
                    SubFrameNavigationService.GoBack();
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1118:Parameter should not span multiple lines", Justification = "Raw string")]
        private async Task<string> GetTokenFromWebView()
        {
            // Discord doesn't allow access to localStorage so create an iframe to bypass this.
            string token = await CaptchaView.InvokeScriptAsync(
                "eval",
                new[]
                {
                    @"
                    iframe = document.createElement('iframe');
                    document.body.appendChild(iframe);
                    iframe.contentWindow.localStorage.getItem('token');
                    //'<<token>>'",
                });

            AnalyticsService.Log(Constants.Analytics.Events.TokenIntercepted);

            return string.IsNullOrEmpty(token) ? string.Empty : token.Trim('"');
        }
    }
}
