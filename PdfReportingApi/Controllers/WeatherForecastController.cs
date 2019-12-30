using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PdfReporting;
using PdfReportingApi;
using PdfReportingApi.Views;

namespace PdfReportingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IViewRender _viewRender;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public WeatherForecastController(IViewRender viewRender,IWebHostEnvironment hostingEnvironment)
        {
            _viewRender = viewRender;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            string html = await _viewRender.RenderAsync("khedama", new TDto { Name="Mehdi Rifi"});
            return Ok();
        }
    }
}
