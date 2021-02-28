using System.Collections.Generic;

namespace OpenGraph.Analyzer.Core.Rules.Result
{
    public interface IAnalyzerRuleResult
    {
        List<IAnalyzerRuleError> Errors { get; }
        
        bool Success { get; }
    }
}