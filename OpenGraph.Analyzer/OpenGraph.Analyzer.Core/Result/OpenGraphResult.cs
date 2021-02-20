using System.Collections.Generic;
using System.Data;
using System.Linq;
using OpenGraph.Analyzer.Core.Abstractions;

namespace OpenGraph.Analyzer.Core.Result
{
    public class OpenGraphResult : IAnalyzerResult
    {
        public Dictionary<string, string> Rules { get; }

        public bool IsOpenGraphPresent 
            => Rules == null || Rules.Any();
    }
}