using System.Collections.Generic;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Result
{
    public interface IAnalyzerResult
    {
        Dictionary<OpenGraphMeta, IAnalyzerRuleError[]> Results { get; }
    }
}