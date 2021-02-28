using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace OpenGraph.Analyzer.Core.Result
{
    public class OpenGraphResult : IAnalyzerResult
    {
        public Dictionary<string, string> Rules { get; }

        public bool IsOpenGraphPresent 
            => Rules == null || Rules.Any();
    }
}