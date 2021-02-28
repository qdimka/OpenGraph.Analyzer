using OpenGraph.Analyzer.Core.Common;
using OpenGraph.Analyzer.Core.Rules;
using OpenGraph.Analyzer.Parser;
using Xunit;

namespace OpenGraph.Analyzer.Core.Tests.Rules
{
    public class RequiredGlobalNameSpaceRuleTests
    {
        [Fact]
        public void Rule_ShouldReturnError_If_NameSpaceNotPresent()
        {
            var rule = new RequiredGlobalNameSpaceRule(new DefaultErrorDescriber());
            var meta = new OpenGraphMetaData(null, null);

            var result = rule.Rule(meta);
            
            Assert.False(result.Success);
        }
        
        [Fact]
        public void Rule_ShouldReturnSuccess_If_NameSpacePresent()
        {
            var rule = new RequiredGlobalNameSpaceRule(new DefaultErrorDescriber());
            var meta = new OpenGraphMetaData(new OpenGraphNameSpace("og", "", new []{""}), null);

            var result = rule.Rule(meta);
            
            Assert.True(result.Success);
        }
    }
}