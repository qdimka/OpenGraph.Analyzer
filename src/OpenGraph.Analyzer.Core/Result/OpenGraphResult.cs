using System.Collections.Generic;
using System.Data;
using System.Linq;
using OpenGraph.Analyzer.Core.Rules.Result;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Result
{
    public class OpenGraphResult : IAnalyzerResult
    {
        public Dictionary<OpenGraphNameSpace, IAnalyzerRuleError[]> Ns { get; set; }
        public Dictionary<OpenGraphMeta, IAnalyzerRuleError[]> Results { get; set; }
    }
}