using System;

namespace OpenGraph.Analyzer.Core.Abstractions
{
    public interface IAnalyzerRule
    {
        string Name { get; }

        Func<string, bool> Rule();
    }
}