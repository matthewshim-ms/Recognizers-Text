
using Microsoft.Recognizers.Definitions.Italian;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace Microsoft.Recognizers.Text.Number.Italian
{
    public class FractionExtractor : BaseNumberExtractor
    {
        internal sealed override ImmutableDictionary<Regex, string> Regexes { get; }

        protected sealed override string ExtractType { get; } = Constants.SYS_NUM_FRACTION; // "Fraction";

        public FractionExtractor()
        {
            var regexes = new Dictionary<Regex, string>
            {
                {
                    new Regex(NumbersDefinitions.FractionNotationRegex,
                        RegexOptions.IgnoreCase | RegexOptions.Singleline)
                    , "FracNum"
                },
                {
                    new Regex(NumbersDefinitions.FractionNotationWithSpacesRegex,
                        RegexOptions.IgnoreCase | RegexOptions.Singleline)
                    , "FracNum"
                },
                {
                    new Regex(NumbersDefinitions.FractionNounRegex,
                        RegexOptions.IgnoreCase | RegexOptions.Singleline)
                    , "FracIT"
                },
                {
                    new Regex(NumbersDefinitions.FractionNounWithArticleRegex,
                        RegexOptions.IgnoreCase | RegexOptions.Singleline)
                    , "FracIT"
                },
                {
                    new Regex(NumbersDefinitions.FractionPrepositionRegex,
                        RegexOptions.IgnoreCase | RegexOptions.Singleline)
                    , "FracIT"
                },
            };

            this.Regexes = regexes.ToImmutableDictionary();
        }
    }
}