﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System.Collections.Generic;

namespace Quarrel.MarkdownTextBlock.Parse.Inlines
{
    /// <summary>
    /// Represents a span containing strikethrough text.
    /// </summary>
    internal class StrikethroughTextInline : MarkdownInline, IInlineContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StrikethroughTextInline"/> class.
        /// </summary>
        public StrikethroughTextInline()
            : base(MarkdownInlineType.Strikethrough)
        {
        }

        /// <summary>
        /// Gets or sets The contents of the inline.
        /// </summary>
        public IList<MarkdownInline> Inlines { get; set; }

        /// <summary>
        /// Returns the chars that if found means we might have a match.
        /// </summary>
        internal static void AddTripChars(List<Helpers.Common.InlineTripCharHelper> tripCharHelpers)
        {
            tripCharHelpers.Add(new Helpers.Common.InlineTripCharHelper() { FirstChar = '~', Method = Helpers.Common.InlineParseMethod.Strikethrough });
        }

        /// <summary>
        /// Attempts to parse a strikethrough text span.
        /// </summary>
        /// <param name="markdown"> The markdown text. </param>
        /// <param name="start"> The location to start parsing. </param>
        /// <param name="maxEnd"> The location to stop parsing. </param>
        /// <returns> A parsed strikethrough text span, or <c>null</c> if this is not a strikethrough text span. </returns>
        internal static Helpers.Common.InlineParseResult Parse(string markdown, int start, int maxEnd)
        {
            // Check the start sequence.
            if (start >= maxEnd - 1 || markdown.Substring(start, 2) != "~~")
            {
                return null;
            }

            // Find the end of the span.
            var innerStart = start + 2;
            int innerEnd = Helpers.Common.IndexOf(markdown, "~~", innerStart, maxEnd);
            if (innerEnd == -1)
            {
                return null;
            }

            // The span must contain at least one character.
            if (innerStart == innerEnd)
            {
                return null;
            }

            // The first character inside the span must NOT be a space.
            if (Helpers.Common.IsWhiteSpace(markdown[innerStart]))
            {
                return null;
            }

            // The last character inside the span must NOT be a space.
            if (Helpers.Common.IsWhiteSpace(markdown[innerEnd - 1]))
            {
                return null;
            }

            // We found something!
            var result = new StrikethroughTextInline();
            result.Inlines = Helpers.Common.ParseInlineChildren(markdown, innerStart, innerEnd);
            return new Helpers.Common.InlineParseResult(result, start, innerEnd + 2);
        }

        /// <summary>
        /// Converts the object into it's textual representation.
        /// </summary>
        /// <returns> The textual representation of this object. </returns>
        public override string ToString()
        {
            if (Inlines == null)
            {
                return base.ToString();
            }

            return "~~" + string.Join(string.Empty, Inlines) + "~~";
        }
    }
}
