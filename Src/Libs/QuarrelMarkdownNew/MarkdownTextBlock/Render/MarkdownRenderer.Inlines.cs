// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI;
using Microsoft.Toolkit.Parsers.Markdown;
using Microsoft.Toolkit.Parsers.Markdown.Inlines;
using Microsoft.Toolkit.Parsers.Markdown.Render;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Shapes;

namespace Microsoft.Toolkit.Uwp.UI.Controls.Quarrel.Markdown.Render
{
    /// <summary>
    /// Inline UI Methods for UWP UI Creation.
    /// </summary>
    public partial class MarkdownRenderer
    {
        /// <summary>
        /// Renders emoji element.
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderEmoji(EmojiInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            var inlineCollection = localContext.InlineCollection;

            if (element.Id == null)
            {
                var emoji = new Run
                {
                    FontFamily = EmojiFontFamily ?? DefaultEmojiFont,
                    Text = element.Text
                };

                inlineCollection.Add(emoji);
            }
            else
            {
                InlineUIContainer imageRun = new InlineUIContainer();
                string extension = ".png";
                if (element.IsAnimated) extension = ".gif";
                Thickness imagemargin = new Thickness(0, 0, 0, 0);
                imageRun.Child = new Image()
                {
                    Margin = imagemargin,
                    Width = FontSize,
                    Height = FontSize,
                    Source = new BitmapImage(new Uri("https://cdn.discordapp.com/emojis/" + element.Id + extension)) { AutoPlay = true }
                };
                //Add the tooltip of the emoji's name
                ToolTipService.SetToolTip(imageRun, element.Name);
                // Add it
                inlineCollection.Add(imageRun);
            }
        }

        /// <summary>
        /// Renders a text run element.
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderTextRun(TextRunInline element, IRenderContext context)
        {
            InternalRenderTextRun(element, context);
        }

        private Run InternalRenderTextRun(TextRunInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            var inlineCollection = localContext.InlineCollection;

            // Create the text run
            Run textRun = new Run
            {
                Text = element.Text
            };

            // Add it
            inlineCollection.Add(textRun);
            return textRun;
        }

        /// <summary>
        /// Renders a bold run element.
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderBoldRun(BoldTextInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            // Create the text run
            Span boldSpan = new Span
            {
                FontWeight = FontWeights.Bold
            };

            var childContext = new InlineRenderContext(boldSpan.Inlines, context)
            {
                Parent = boldSpan,
                WithinBold = true
            };

            // Render the children into the bold inline.
            RenderInlineChildren(element.Inlines, childContext);

            // Add it to the current inlines
            localContext.InlineCollection.Add(boldSpan);
        }

        /// <summary>
        /// Renders a link element
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderMarkdownLink(MarkdownLinkInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            // HACK: Superscript is not allowed within a hyperlink.  But if we switch it around, so
            // that the superscript is outside the hyperlink, then it will render correctly.
            // This assumes that the entire hyperlink is to be rendered as superscript.
            if (AllTextIsSuperscript(element) == false)
            {
                // Regular ol' hyperlink.
                var link = new Hyperlink();

                // Register the link
                LinkRegister.RegisterNewHyperLink(link, element.Url);

                // Remove superscripts.
                RemoveSuperscriptRuns(element, insertCaret: true);

                // Render the children into the link inline.
                var childContext = new InlineRenderContext(link.Inlines, context)
                {
                    Parent = link,
                    WithinHyperlink = true
                };

                if (localContext.OverrideForeground)
                {
                    link.Foreground = localContext.Foreground;
                }
                else if (LinkForeground != null)
                {
                    link.Foreground = LinkForeground;
                }

                RenderInlineChildren(element.Inlines, childContext);
                context.TrimLeadingWhitespace = childContext.TrimLeadingWhitespace;

                ToolTipService.SetToolTip(link, element.Tooltip ?? element.Url);

                // Add it to the current inlines
                localContext.InlineCollection.Add(link);
            }
            else
            {
                // THE HACK IS ON!

                // Create a fake superscript element.
                var fakeSuperscript = new SuperscriptTextInline
                {
                    Inlines = new List<MarkdownInline>
                    {
                        element
                    }
                };

                // Remove superscripts.
                RemoveSuperscriptRuns(element, insertCaret: false);

                // Now render it.
                RenderSuperscriptRun(fakeSuperscript, context);
            }
        }

        /// <summary>
        /// Renders a raw link element.
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderHyperlink(HyperlinkInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            if (element.LinkType == HyperlinkType.DiscordUserMention || element.LinkType == HyperlinkType.DiscordChannelMention || element.LinkType == HyperlinkType.DiscordRoleMention || element.LinkType == HyperlinkType.DiscordNickMention || element.LinkType == HyperlinkType.QuarrelColor)
            {
                bool _halfopacity = false;
                var link = new HyperlinkButton();
                var content = element.Text;
                bool enabled = true;
                SolidColorBrush foreground = (SolidColorBrush)Application.Current.Resources["Blurple"];

                try
                {
                    if (element.LinkType == HyperlinkType.DiscordUserMention || element.LinkType == HyperlinkType.DiscordNickMention)
                    {
                        string mentionid = element.Text.Remove(0, (element.LinkType == HyperlinkType.DiscordNickMention ? 2 : 1));
                        if (Document.Users != null)
                        {
                            Document.Users.TryGetValue(mentionid, out var user);
                            if (!string.IsNullOrEmpty(user.Name))
                            {
                                link.Tag = mentionid;
                                content = _halfopacity ? user.Name : "@" + user.Name;
                                foreground = IntToColor(user.Colour);

                                /*if (GuildsService.CurrentGuild.Model.Name != "DM")
                                {
                                    CurrentUsersService.Users.TryGetValue(mentionid, out var member);
                                    if (!string.IsNullOrWhiteSpace(member?.DisplayName))
                                    {
                                        if (_halfopacity) content = member.DisplayName;
                                        else content = "@" + member.DisplayName;

                                        foreground = IntToColor(member.TopRole.Color);
                                    }
                                }*/
                            }
                        }
                    }


                    else if (element.LinkType == HyperlinkType.DiscordChannelMention)
                    {
                        var key = element.Text.Remove(0, 1);
                        if (Document.Channels != null)
                        {
                            Document.Channels.TryGetValue(key, out var value); 
                            content = "#" + value;
                            enabled = true;
                            link.Tag = value;
                        }
                        else
                        {
                            content = "#deleted-channel";
                            enabled = false;
                        }

                    }


                    else if (element.LinkType == HyperlinkType.DiscordRoleMention)
                    {
                        if (Document.Roles != null && Document.Roles.TryGetValue(element.Text.Remove(0, 2), out var role))
                        {
                            if (_halfopacity) content = role.Name;
                            else content = "@" + role.Name;
                            foreground = IntToColor(role.Colour);
                        }
                        else
                        {
                            enabled = false;
                            content = "@deleted-role";
                        }
                    }
                    else if (element.LinkType == HyperlinkType.QuarrelColor)
                    {
                        string intcolor = element.Text.Replace("@$QUARREL-color", "");
                        try
                        {
                            var color = IntToColor(Int32.Parse(intcolor));
                            localContext.InlineCollection.Add(new InlineUIContainer
                            {
                                Child = new Ellipse()
                                {
                                    Height = FontSize,
                                    Width = FontSize,
                                    Fill = color,
                                    Margin = new Thickness(0, 0, 2, -2)
                                }
                            });
                            localContext.InlineCollection.Add(new Run
                            {
                                FontWeight = FontWeights.SemiBold,
                                //Foreground = BoldForeground,
                                Text = color.Color.ToString()
                            });
                            return;
                        }
                        catch
                        { }
                    }
                }
                catch (Exception) { content = "<Invalid Mention>"; }


                link.Content = CollapseWhitespace(context, content);
                link.Foreground = foreground;
                link.FontSize = FontSize;
                if (_halfopacity) link.Style = (Style)Application.Current.Resources["DiscordMentionHyperlinkBold"];
                else link.Style = (Style)Application.Current.Resources["DiscordMentionHyperlink"];
                link.IsEnabled = enabled;
                LinkRegister.RegisterNewHyperLink(link, element.Url);
                InlineUIContainer linkContainer = new InlineUIContainer { Child = link };
                localContext.InlineCollection.Add(linkContainer);
            }
            else
            {
                var link = new Hyperlink();

                // Register the link
                LinkRegister.RegisterNewHyperLink(link, element.Url);

                var brush = localContext.Foreground;
                if (LinkForeground != null && !localContext.OverrideForeground)
                {
                    brush = LinkForeground;
                }

                // Make a text block for the link
                Run linkText = new Run
                {
                    Text = CollapseWhitespace(context, element.Text),
                    Foreground = brush
                };

                link.Inlines.Add(linkText);

                // Add it to the current inlines
                localContext.InlineCollection.Add(link);
            }
        }

        /// <summary>
        /// Renders an image element.
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override async void RenderImage(ImageInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            var inlineCollection = localContext.InlineCollection;

            var placeholder = InternalRenderTextRun(new TextRunInline { Text = element.Text, Type = MarkdownInlineType.TextRun }, context);
            var resolvedImage = await ImageResolver.ResolveImageAsync(element.RenderUrl, element.Tooltip);

            // if image can not be resolved we have to return
            if (resolvedImage == null)
            {
                return;
            }

            var image = new Image
            {
                Source = resolvedImage,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Stretch = ImageStretch
            };

            HyperlinkButton hyperlinkButton = new HyperlinkButton()
            {
                Content = image
            };

            var viewbox = new Viewbox
            {
                Child = hyperlinkButton,
                StretchDirection = StretchDirection.DownOnly
            };

            viewbox.PointerWheelChanged += Preventative_PointerWheelChanged;

            var scrollViewer = new ScrollViewer
            {
                Content = viewbox,
                VerticalScrollMode = ScrollMode.Disabled,
                VerticalScrollBarVisibility = ScrollBarVisibility.Disabled
            };

            var imageContainer = new InlineUIContainer() { Child = scrollViewer };

            bool ishyperlink = false;
            if (element.RenderUrl != element.Url)
            {
                ishyperlink = true;
            }

            LinkRegister.RegisterNewHyperLink(image, element.Url, ishyperlink);

            if (ImageMaxHeight > 0)
            {
                viewbox.MaxHeight = ImageMaxHeight;
            }

            if (ImageMaxWidth > 0)
            {
                viewbox.MaxWidth = ImageMaxWidth;
            }

            if (element.ImageWidth > 0)
            {
                image.Width = element.ImageWidth;
                image.Stretch = Stretch.UniformToFill;
            }

            if (element.ImageHeight > 0)
            {
                if (element.ImageWidth == 0)
                {
                    image.Width = element.ImageHeight;
                }

                image.Height = element.ImageHeight;
                image.Stretch = Stretch.UniformToFill;
            }

            if (element.ImageHeight > 0 && element.ImageWidth > 0)
            {
                image.Stretch = Stretch.Fill;
            }

            // If image size is given then scroll to view overflown part
            if (element.ImageHeight > 0 || element.ImageWidth > 0)
            {
                scrollViewer.HorizontalScrollMode = ScrollMode.Auto;
                scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            }

            // Else resize the image
            else
            {
                scrollViewer.HorizontalScrollMode = ScrollMode.Disabled;
                scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            }

            ToolTipService.SetToolTip(image, element.Tooltip);

            // Try to add it to the current inlines
            // Could fail because some containers like Hyperlink cannot have inlined images
            try
            {
                var placeholderIndex = inlineCollection.IndexOf(placeholder);
                inlineCollection.Remove(placeholder);
                inlineCollection.Insert(placeholderIndex, imageContainer);
            }
            catch
            {
                // Ignore error
            }
        }

        /// <summary>
        /// Renders a text run element.
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderItalicRun(ItalicTextInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            // Create the text run
            Span italicSpan = new Span
            {
                FontStyle = FontStyle.Italic
            };

            var childContext = new InlineRenderContext(italicSpan.Inlines, context)
            {
                Parent = italicSpan,
                WithinItalics = true
            };

            // Render the children into the italic inline.
            RenderInlineChildren(element.Inlines, childContext);

            // Add it to the current inlines
            localContext.InlineCollection.Add(italicSpan);
        }

        protected override void RenderUnderlineRun(UnderlineTextInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            Span underlineSpan = new Span
            {
                TextDecorations = TextDecorations.Underline
            };

            var childContext = new InlineRenderContext(underlineSpan.Inlines, context)
            {
                Parent = underlineSpan,
                WithinItalics = true
            };

            // Render the children into the italic inline.
            RenderInlineChildren(element.Inlines, childContext);

            // Add it to the current inlines
            localContext.InlineCollection.Add(underlineSpan);
        }


        /// <summary>
        /// Renders a strikethrough element.
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderStrikethroughRun(StrikethroughTextInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            Span span = new Span();

            if (TextDecorationsSupported)
            {
                span.TextDecorations = TextDecorations.Strikethrough;
            }
            else
            {
                span.FontFamily = new FontFamily("Consolas");
            }

            var childContext = new InlineRenderContext(span.Inlines, context)
            {
                Parent = span
            };

            // Render the children into the inline.
            RenderInlineChildren(element.Inlines, childContext);

            if (!TextDecorationsSupported)
            {
                AlterChildRuns(span, (parentSpan, run) =>
                {
                    var text = run.Text;
                    var builder = new StringBuilder(text.Length * 2);
                    foreach (var c in text)
                    {
                        builder.Append((char)0x0336);
                        builder.Append(c);
                    }

                    run.Text = builder.ToString();
                });
            }

            // Add it to the current inlines
            localContext.InlineCollection.Add(span);
        }

        /// <summary>
        /// Renders a superscript element.
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderSuperscriptRun(SuperscriptTextInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            var parent = localContext?.Parent as TextElement;
            if (localContext == null && parent == null)
            {
                throw new RenderContextIncorrectException();
            }

            // Le <sigh>, InlineUIContainers are not allowed within hyperlinks.
            if (localContext.WithinHyperlink)
            {
                RenderInlineChildren(element.Inlines, context);
                return;
            }

            var paragraph = new Paragraph
            {
                FontSize = parent.FontSize * 0.8,
                FontFamily = parent.FontFamily,
                FontStyle = parent.FontStyle,
                FontWeight = parent.FontWeight
            };

            var childContext = new InlineRenderContext(paragraph.Inlines, context)
            {
                Parent = paragraph
            };

            RenderInlineChildren(element.Inlines, childContext);

            var richTextBlock = CreateOrReuseRichTextBlock(new UIElementCollectionRenderContext(null, context));
            richTextBlock.Blocks.Add(paragraph);

            var border = new Border
            {
                Padding = new Thickness(0, 0, 0, paragraph.FontSize * 0.2),
                Child = richTextBlock
            };

            var inlineUIContainer = new InlineUIContainer
            {
                Child = border
            };

            // Add it to the current inlines
            localContext.InlineCollection.Add(inlineUIContainer);
        }

        /// <summary>
        /// Renders a subscript element.
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderSubscriptRun(SubscriptTextInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            var parent = localContext?.Parent as TextElement;
            if (localContext == null && parent == null)
            {
                throw new RenderContextIncorrectException();
            }

            var paragraph = new Paragraph
            {
                FontSize = parent.FontSize * 0.7,
                FontFamily = parent.FontFamily,
                FontStyle = parent.FontStyle,
                FontWeight = parent.FontWeight
            };

            var childContext = new InlineRenderContext(paragraph.Inlines, context)
            {
                Parent = paragraph
            };

            RenderInlineChildren(element.Inlines, childContext);

            var richTextBlock = CreateOrReuseRichTextBlock(new UIElementCollectionRenderContext(null, context));
            richTextBlock.Blocks.Add(paragraph);

            var border = new Border
            {
                Margin = new Thickness(0, 0, 0, (-1) * (paragraph.FontSize * 0.6)),
                Child = richTextBlock
            };

            var inlineUIContainer = new InlineUIContainer
            {
                Child = border
            };

            // Add it to the current inlines
            localContext.InlineCollection.Add(inlineUIContainer);
        }

        /// <summary>
        /// Renders a code element
        /// </summary>
        /// <param name="element"> The parsed inline element to render. </param>
        /// <param name="context"> Persistent state. </param>
        protected override void RenderCodeRun(CodeInline element, IRenderContext context)
        {
            var localContext = context as InlineRenderContext;
            if (localContext == null)
            {
                throw new RenderContextIncorrectException();
            }

            var text = CreateTextBlock(localContext);
            text.Text = CollapseWhitespace(context, element.Text);
            text.FontFamily = InlineCodeFontFamily ?? FontFamily;
            text.Foreground = InlineCodeForeground ?? Foreground;

            if (localContext.WithinItalics)
            {
                text.FontStyle = FontStyle.Italic;
            }

            if (localContext.WithinBold)
            {
                text.FontWeight = FontWeights.Bold;
            }

            var borderthickness = InlineCodeBorderThickness;
            var padding = InlineCodePadding;

            var border = new Border
            {
                BorderThickness = borderthickness,
                BorderBrush = InlineCodeBorderBrush,
                Background = InlineCodeBackground,
                Child = text,
                Padding = padding,
                Margin = InlineCodeMargin
            };

            // Aligns content in InlineUI, see https://social.msdn.microsoft.com/Forums/silverlight/en-US/48b5e91e-efc5-4768-8eaf-f897849fcf0b/richtextbox-inlineuicontainer-vertical-alignment-issue?forum=silverlightarchieve
            border.RenderTransform = new TranslateTransform
            {
                Y = 4
            };

            var inlineUIContainer = new InlineUIContainer
            {
                Child = border,
            };

            // Add it to the current inlines
            localContext.InlineCollection.Add(inlineUIContainer);
        }


        public static SolidColorBrush IntToColor(int color)
        {
            if (color != 0)
            {
                byte a = (byte)(255);
                byte r = (byte)(color >> 16);
                byte g = (byte)(color >> 8);
                byte b = (byte)(color >> 0);
                return new SolidColorBrush(Color.FromArgb(a, r, g, b));
            }
            else
            {
                return (SolidColorBrush)Application.Current.Resources["Foreground"];
            }
        }
    }
}