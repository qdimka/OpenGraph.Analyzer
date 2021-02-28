using System;
using System.Threading.Tasks;
using OpenGraph.Analyzer.Core.Rules.Registry;
using OpenGraph.Analyzer.Core.Services;
using OpenGraph.Analyzer.Parser;
using Xunit;

namespace OpenGraph.Analyzer.Core.Tests.Services
{
    public class OpenGraphAnalyzerTests
    {
        private IOpenGraphAnalyzer _openGraphAnalyzer = 
            new OpenGraphAnalyzer(new OpenGraphParser(), new DefaultRuleRegistry());
        
        [Fact]
        public async Task AnalyzeAsync_Should_Throw_Error_For_EmptyOrNull_String()
        {
            await Assert.ThrowsAsync<InvalidOperationException>(
                () => _openGraphAnalyzer.AnalyzeAsync(""));
            await Assert.ThrowsAsync<InvalidOperationException>(
                () => _openGraphAnalyzer.AnalyzeAsync(null));
        }
    }
}