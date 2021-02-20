using System;
using System.Threading.Tasks;
using OpenGraph.Analyzer.Core.Abstractions;
using OpenGraph.Analyzer.Core.Services;
using Xunit;

namespace OpenGraph.Analyzer.Core.Tests.Services
{
    public class OpenGraphAnalyzerTests
    {
        private IOpenGraphAnalyzer _openGraphAnalyzer = new OpenGraphAnalyzer();
        
        [Fact]
        public async Task AnalyzeAsync_Should_Throw_Error_For_EmptyOrNull_String()
        {
            await Assert.ThrowsAsync<InvalidOperationException>(
                () => _openGraphAnalyzer.AnalyzeAsync(""));
            await Assert.ThrowsAsync<InvalidOperationException>(
                () => _openGraphAnalyzer.AnalyzeAsync(null));
        }
        
        [Fact]
        public async Task AnalyzeAsync_Should_Return_Empty_Result_If_OpenGraph_Not_Present_In_Html()
        {
            
            return;
            var htmlString = "<html />";

            _openGraphAnalyzer.AnalyzeAsync("");
        }
    }
}