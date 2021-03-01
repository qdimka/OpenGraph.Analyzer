using System.Collections.Generic;
using System.Linq;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Rules.Registry
{
    public class DefaultRuleRegistry : IRulesRegistry<IOpenGraphMetaData, IAnalyzerRuleResult>
    {
        private readonly List<IAnalyzerRule<IOpenGraphMetaData, IAnalyzerRuleResult>> _rules;

        public DefaultRuleRegistry(
            IEnumerable<IAnalyzerRule<IOpenGraphMetaData, IAnalyzerRuleResult>> rules = null)
        {
            _rules = rules?.ToList() 
                     ?? new List<IAnalyzerRule<IOpenGraphMetaData, IAnalyzerRuleResult>>();
        }
        
        public List<IAnalyzerRule<IOpenGraphMetaData, IAnalyzerRuleResult>> GetRules()
        {
            return _rules;
        }

        public void AddRule(IAnalyzerRule<IOpenGraphMetaData, IAnalyzerRuleResult> rule)
        {
            _rules.Add(rule);
        }

        public void RemoveRule(string key)
        {
            var index = _rules
                .FindIndex(x => x.Key == key);
            
            if (index != -1)
                _rules.RemoveAt(index);
        }
    }
}