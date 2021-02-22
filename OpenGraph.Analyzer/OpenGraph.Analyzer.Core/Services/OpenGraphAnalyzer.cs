using System;
using System.Threading.Tasks;
using OpenGraph.Analyzer.Core.Abstractions;
using OpenGraph.Analyzer.Parser;

namespace OpenGraph.Analyzer.Core.Services
{
    public class OpenGraphAnalyzer : IOpenGraphAnalyzer
    {
        private readonly IOpenGraphParser _openGraphParser;

        public OpenGraphAnalyzer(IOpenGraphParser openGraphParser)
        {
            _openGraphParser = openGraphParser;
        }
        
        public Task<IAnalyzerResult> AnalyzeAsync(string html)
        {
            if (string.IsNullOrEmpty(html))
                throw new InvalidOperationException();

            var meta = _openGraphParser.Parse(html);
            
            return null;
        }
    }
}