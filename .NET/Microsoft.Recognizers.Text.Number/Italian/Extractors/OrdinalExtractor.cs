﻿using Microsoft.Recognizers.Definitions.Italian;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace Microsoft.Recognizers.Text.Number.Italian
{
    public class OrdinalExtractor : BaseNumberExtractor
    {
        internal sealed override ImmutableDictionary<Regex, string> Regexes { get; }

        protected sealed override string ExtractType { get; } = Constants.SYS_NUM_ORDINAL; // "Ordinal";

        public OrdinalExtractor()
        {
            var regexes = new Dictionary<Regex, string>
            {
                {
                    new Regex(
                        NumbersDefinitions.OrdinalSuffixRegex,
                        RegexOptions.IgnoreCase | RegexOptions.Singleline)
                    , "OrdinalNum"
                },
                {
                    new Regex(NumbersDefinitions.OrdinalNounRegex,
                        RegexOptions.IgnoreCase | RegexOptions.Singleline)
                    , "OrdinalIT"
                }
            };

            this.Regexes = regexes.ToImmutableDictionary();
        }
    }
}