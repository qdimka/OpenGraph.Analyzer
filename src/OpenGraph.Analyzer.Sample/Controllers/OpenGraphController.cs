using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenGraph.Analyzer.Core.Services;

namespace OpenGraph.Analyzer.Sample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OpenGraphController : ControllerBase
    {
        private readonly IOpenGraphAnalyzer _openGraphAnalyzer;

        public OpenGraphController(IOpenGraphAnalyzer openGraphAnalyzer)
        {
            _openGraphAnalyzer = openGraphAnalyzer;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]OpenGraphRequest request)
        {
            var http = new HttpClient();

            var response = await http.GetAsync(request.Url);

            var html = await response.Content.ReadAsStringAsync();

            var result = _openGraphAnalyzer.Analyze(html);

            return Ok(result);
        }
    }

    public class OpenGraphRequest
    {
        [Required]
        public string Url { get; set; }
    } 
}