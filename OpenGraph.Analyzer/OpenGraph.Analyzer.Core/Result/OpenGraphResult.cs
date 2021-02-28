using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace OpenGraph.Analyzer.Core.Result
{
    public class OpenGraphResult : IAnalyzerResult
    {
        public (string Rule, string Result)[] Rules { get; set; }

        public bool IsOpenGraphPresent 
            => Rules == null || Rules.Any();
    }
}