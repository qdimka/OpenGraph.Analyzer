using System;
using System.Threading.Tasks;
using OpenGraph.Analyzer.Core.Rules.Registry;
using OpenGraph.Analyzer.Core.Services;
using OpenGraph.Analyzer.Parser;
using OpenGraph.Analyzer.Parser.NameSpaces;
using Xunit;

namespace OpenGraph.Analyzer.Core.Tests.Services
{
    public class OpenGraphAnalyzerTests
    {
        private IOpenGraphAnalyzer _openGraphAnalyzer = 
            new OpenGraphAnalyzer(
                new OpenGraphParser(new DefaultNameSpaceStore()), 
                new DefaultRuleRegistry());
        
        [Fact]
        public void AnalyzeAsync_Should_Throw_Error_For_EmptyOrNull_String()
        {
            Assert.Throws<InvalidOperationException>(
                () => _openGraphAnalyzer.Analyze(""));
            Assert.Throws<InvalidOperationException>(
                () => _openGraphAnalyzer.Analyze(null));
        }
    }
}