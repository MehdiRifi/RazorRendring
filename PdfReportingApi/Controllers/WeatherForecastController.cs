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
        private readonly IWebHostEnvironment _hostingEnvironment;


   
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            //var test = new ServiceTest(_viewRender);
            //string result= await test.Parse("khedama");
            return Ok();
        }
    }
}
