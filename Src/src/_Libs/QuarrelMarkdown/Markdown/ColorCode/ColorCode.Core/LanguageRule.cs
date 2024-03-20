// Copyright (c) Microsoft Corporation.  All rights reserved.
// Copyright (c) Quarrel. All rights reserved.

using Quarrel.Controls.Markdown.ColorCode.ColorCode.Core.Common;
using System.Collections.Generic;

namespace Quarrel.Controls.Markdown.ColorCode.ColorCode.Core
{
    /// <summary>
    /// Defines a single rule for a language. For instance a language rule might define string literals for a given language.
    /// </summary>
    public class LanguageRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageRule"/> class.
        /// </summary>
        /// <param name="regex">The regular expression that defines what the language rule matches and captures.</param>
        /// <param name="captures">The scope indices and names of the regular expression's captures.</param>
        public LanguageRule(
            string regex,
            IDictionary<int, string> captures)
        {
            Guard.ArgNotNullAndNotEmpty(regex, "regex");
            Guard.EnsureParameterIsNotNullAndNotEmpty(captures, "captures");

            Regex = regex;
            Captures = captures;
        }

        /// <summary>
        /// Gets the regular expression that defines what the language rule matches and captures.
        /// </summary>
        /// <value>The regular expression that defines what the language rule matches and captures.</value>
        public string Regex { get; private set; }

        /// <summary>
        /// Gets the scope indices and names of the regular expression's captures.
        /// </summary>
        /// <value>The scope indices and names of the regular expression's captures.</value>
        public IDictionary<int, string> Captures { get; private set; }
    }
}