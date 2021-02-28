using System.IO;
using System.Linq;
using OpenGraph.Analyzer.Parser.NameSpaces;
using Xunit;

namespace OpenGraph.Analyzer.Parser.Tests
{
    public class OpenGraphParserTests
    {
        private readonly IOpenGraphParser _parser = new OpenGraphParser(new DefaultNameSpaceStore());
        
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
            var expectedFbNameSpace = "fb";
            var expectedOgNameSpace = "og";
            var expectedCount = 7;
            
            var html = File.ReadAllText("./Data/index.html");

            var metaData = _parser.Parse(html);

            var selected = metaData.Meta
                .SelectMany(x => x.Value)
                .ToArray();
            
            Assert.NotNull(metaData);
            Assert.NotNull(metaData.Meta);
            Assert.Equal(expectedCount, metaData.Meta.Count);
            Assert.Contains(selected, 
                x => expectedFbNameSpace == x.NameSpace);
            Assert.Contains(selected, 
                x => expectedOgNameSpace == x.NameSpace);
        }
        
        [Fact]
        public void Parse_Should_Return_NameSpace_If_NameSpace_Present()
        {
            var html = File.ReadAllText("./Data/index_with_namespace.html");

            var metaData = _parser.Parse(html);
            
            Assert.NotNull(metaData);
            Assert.NotNull(metaData.NameSpace);
        }
        
        [Fact]
        public void Parse_Should_Return_Array_Of_Images()
        {
            var html = File.ReadAllText("./Data/index_with_image_array.html");

            var metaData = _parser.Parse(html);
            
            Assert.NotNull(metaData);
            Assert.NotNull(metaData.NameSpace);
            Assert.Equal(2, metaData.Meta["og:image"].Length);
        }
    }
}