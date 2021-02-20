using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OpenGraph.Analyzer.Core.Abstractions;

namespace OpenGraph.Analyzer.Core.Services
{
    public class OpenGraphAnalyzer : IOpenGraphAnalyzer
    {
        public Task<IAnalyzerResult> AnalyzeAsync(string html)
        {
            if (string.IsNullOrEmpty(html))
                throw new InvalidOperationException();

            return null;
        }
    }
}