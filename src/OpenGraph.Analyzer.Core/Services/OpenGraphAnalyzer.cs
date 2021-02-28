using System;
using System.Linq;
using System.Threading.Tasks;
using OpenGraph.Analyzer.Core.Common;
using OpenGraph.Analyzer.Core.Result;
using OpenGraph.Analyzer.Core.Rules;
using OpenGraph.Analyzer.Core.Rules.Registry;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Services
{
    public class OpenGraphAnalyzer : IOpenGraphAnalyzer
    {
        private readonly IOpenGraphParser _openGraphParser;
        private readonly IRulesRegistry<IOpenGraphMetaData, IAnalyzerRuleResult> _rulesRegistry;
        private readonly IErrorDescriber _errorDescriber;

        public OpenGraphAnalyzer(IOpenGraphParser openGraphParser, 
            IRulesRegistry<IOpenGraphMetaData, IAnalyzerRuleResult> rulesRegistry)
        {
            _openGraphParser = openGraphParser;
            _rulesRegistry = rulesRegistry;
        }
        
        public IAnalyzerResult Analyze(string html)
        {
            if (string.IsNullOrEmpty(html))
                throw new InvalidOperationException();

            var meta = _openGraphParser.Parse(html);

            var results = _rulesRegistry
                .GetRules()
                .Select(x => x.Rule(meta))
                .ToArray()
                .SelectMany(x => x.Errors)
                .Select(x => (x.Key, x.Error))
                .ToArray();
            
            return new OpenGraphResult()
            {
                Rules = results
            };
        }
    }
}