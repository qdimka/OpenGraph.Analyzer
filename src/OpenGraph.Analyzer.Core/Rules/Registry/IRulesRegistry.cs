using System.Collections.Generic;
using OpenGraph.Analyzer.Core.Rules.Result;

namespace OpenGraph.Analyzer.Core.Rules.Registry
{
    public interface IRulesRegistry<TIn, TOut>
        where TOut : IAnalyzerRuleResult
    {
        List<IAnalyzerRule<TIn, TOut>> GetRules();
        
        void AddRule(IAnalyzerRule<TIn, TOut> rule);

        void RemoveRule(string key);
    }
}