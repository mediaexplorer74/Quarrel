using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Quarrel.Dialogs
{
    public sealed partial class TokenDialog : ContentDialog
    {
        public string Token
        {
            get
            {
                return TokenTextBox.Password;
            }
        }

        public TokenDialog()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
           TokenTextBox.Password = TokenTextBox.Password;
        }

        private void ContentDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            TokenTextBox.Password = "";
        }
         
    }
}
