using OpenGraph.Analyzer.Core.Rules.Result;

namespace OpenGraph.Analyzer.Core.Rules
{
    public interface IAnalyzerRule<in TIn, out TOut>
        where TOut : IAnalyzerRuleResult
    {
        string Key { get; }
        
        TOut Rule(TIn meta);
    }
}