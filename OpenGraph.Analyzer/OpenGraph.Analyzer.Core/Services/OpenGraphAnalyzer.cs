using System;
using System.Linq;
using System.Threading.Tasks;
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

        public OpenGraphAnalyzer(IOpenGraphParser openGraphParser, 
            IRulesRegistry<IOpenGraphMetaData, IAnalyzerRuleResult> rulesRegistry)
        {
            _openGraphParser = openGraphParser;
            _rulesRegistry = rulesRegistry;
        }
        
        public Task<IAnalyzerResult> AnalyzeAsync(string html)
        {
            if (string.IsNullOrEmpty(html))
                throw new InvalidOperationException();

            var meta = _openGraphParser.Parse(html);

            var results = _rulesRegistry
                .GetRules()
                .Select(x => x.Rule(meta))
                .ToArray();
            
            return null;
        }
    }
}