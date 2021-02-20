using System.IO;
using Xunit;

namespace OpenGraph.Analyzer.Parser.Tests
{
    public class OpenGraphParserTests
    {
        private readonly IOpenGraphParser _parser = new OpenGraphParser();
        
        [Fact]
        public void Parse_Should_Return_Empty_NameSpace_If_NameSpace_NotPresent()
        {
            var html = File.ReadAllText("./Data/index.html");

            var metaData = _parser.Parse(html);
            
            Assert.NotNull(metaData);
            Assert.Null(metaData.NameSpace);
        }
        
        [Fact]
        public void Parse_Should_Return_Meta_For_GivenValue()
        {
            var html = File.ReadAllText("./Data/index.html");

            var metaData = _parser.Parse(html);
            
            Assert.NotNull(metaData);
            Assert.NotNull(metaData.Meta);
        }
    }
}