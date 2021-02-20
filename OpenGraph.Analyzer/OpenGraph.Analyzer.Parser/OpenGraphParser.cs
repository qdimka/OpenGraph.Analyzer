using System.Linq;
using HtmlAgilityPack;

namespace OpenGraph.Analyzer.Parser
{
    public class OpenGraphParser : IOpenGraphParser
    {
        private const string PropertyAttribute = "property";
        private const string ContentAttribute = "content";

        public IOpenGraphMetaData Parse(string html)
        {
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            
            var nodes = htmlDocument
                .DocumentNode
                .SelectNodes("//meta");

            var meta = nodes    
                .ToArray()
                .Where(x => x.Attributes.Contains(PropertyAttribute) &&
                               x.GetAttributeValue(PropertyAttribute, "").Contains(":"))
                .Select(x =>
                {
                    var propertyValue = x
                        .GetAttributeValue(PropertyAttribute, "");
                    var contentValue = x
                        .GetAttributeValue(ContentAttribute, "");

                    return new OpenGraphMeta(propertyValue, contentValue);
                })
                .ToDictionary(x => x.Name);

            return new OpenGraphMetaData(null, meta);
        }
    }
}