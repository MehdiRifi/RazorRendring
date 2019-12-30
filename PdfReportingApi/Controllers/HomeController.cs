using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PdfReporting;
using RazorRendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PdfReportingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController:ControllerBase
    {
        private readonly IViewRender _viewRender;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public HomeController(IViewRender viewRender, IWebHostEnvironment hostingEnvironment)
        {
            _viewRender = viewRender;
            _hostingEnvironment = hostingEnvironment;
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var test = _viewRender.RenderAsync("test");
            return Ok();
        }
    }
}
