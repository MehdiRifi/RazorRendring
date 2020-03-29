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


        {
            _viewRender = viewRender;
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
        }
    }
}
