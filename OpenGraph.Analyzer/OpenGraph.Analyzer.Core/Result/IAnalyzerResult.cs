using System.Collections.Generic;

namespace OpenGraph.Analyzer.Core.Result
{
    public interface IAnalyzerResult
    {
        Dictionary<string, string> Rules { get; }

        bool IsOpenGraphPresent { get; }
    }
}