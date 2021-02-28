using System.Collections.Generic;
using OpenGraph.Analyzer.Core.Common;
using OpenGraph.Analyzer.Core.Rules;
using OpenGraph.Analyzer.Parser;
using Xunit;

namespace OpenGraph.Analyzer.Core.Tests.Rules
{
    public class RequiredAttributesRuleTests
    {
        [Fact]
        public void Rule_ShouldReturnError_If_AttributesNotPresent()
        {
            var rule = new RequiredAttributesRule(new DefaultErrorDescriber());
            var meta = new OpenGraphMetaData(
                new OpenGraphNameSpace("og", "", new []{"image", "title"}), 
                new Dictionary<string, OpenGraphMeta[]>()
                {
                    {"og:title", new OpenGraphMeta[]
                    {
                        new OpenGraphMeta("og", "title", "Title")
                    }},
                });

            var result = rule.Rule(meta);
            
            Assert.False(result.Success);
        }
        
        [Fact]
        public void Rule_ShouldReturnSuccess_If_AttributesPresent()
        {
            var rule = new RequiredAttributesRule(new DefaultErrorDescriber());
            var meta = new OpenGraphMetaData(
                new OpenGraphNameSpace("og", "", new []{"image", "title"}), 
                new Dictionary<string, OpenGraphMeta[]>()
                {
                    {"og:title", new OpenGraphMeta[]
                    {
                        new OpenGraphMeta("og", "title", "Title")
                    }},
                    {"og:image", new OpenGraphMeta[]
                    {
                        new OpenGraphMeta("og", "image", "Image")
                    }},
                });

            var result = rule.Rule(meta);
            
            Assert.True(result.Success);
        }
    }
}