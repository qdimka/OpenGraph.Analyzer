using System;

namespace OpenGraph.Analyzer.Core.Abstractions
{
    public interface IAnalyzerRule<in T>
    {
        bool Rule(T meta);
    }
}