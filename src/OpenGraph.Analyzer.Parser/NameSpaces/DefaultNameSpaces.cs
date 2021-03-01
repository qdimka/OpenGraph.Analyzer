using System.Collections.Generic;

namespace OpenGraph.Analyzer.Parser.NameSpaces
{
    public static class DefaultNameSpaces
    {
        public static Dictionary<string, OpenGraphNameSpace> NameSpaces = new Dictionary<string, OpenGraphNameSpace>
        {
            {"og", new OpenGraphNameSpace("og", "http://ogp.me/ns#", "title", "type", "image", "url")},
            {"article", new OpenGraphNameSpace("article", "http://ogp.me/ns/article#")},
            {"book", new OpenGraphNameSpace("book", "http://ogp.me/ns/book#")},
            {"books", new OpenGraphNameSpace("books", "http://ogp.me/ns/books#")},
            {"business", new OpenGraphNameSpace("business", "http://ogp.me/ns/business#")},
            {"fitness", new OpenGraphNameSpace("fitness", "http://ogp.me/ns/fitness#")},
            {"game", new OpenGraphNameSpace("game", "http://ogp.me/ns/game#")},
            {"music", new OpenGraphNameSpace("music", "http://ogp.me/ns/music#")},
            {"place", new OpenGraphNameSpace("place", "http://ogp.me/ns/place#")},
            {"product", new OpenGraphNameSpace("product", "http://ogp.me/ns/product#")},
            {"profile", new OpenGraphNameSpace("profile", "http://ogp.me/ns/profile#")},
            {"restaurant", new OpenGraphNameSpace("restaurant", "http://ogp.me/ns/restaurant#")},
            {"video", new OpenGraphNameSpace("video", "http://ogp.me/ns/video#")},
        };
    }
}