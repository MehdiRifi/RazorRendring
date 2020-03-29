using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Models;
using RazorRendering;
using HtmlPdfGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PdfGen;

namespace PdfReportingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController:ControllerBase
    {
        private readonly IViewRender _viewRender;
        private readonly IPdfGenerator _pdfGenerator;


        public HomeController(IViewRender viewRender,IPdfGenerator htmlPdfGenerator)
        {
            _viewRender = viewRender;
            _pdfGenerator = htmlPdfGenerator;
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            //render the razor file.
            //NB: file must be in a folder with the same name as the controller.
            string htmlSource = await _viewRender.RenderAsync<User>("HelloBuddy",new User { FirstName="Mehdi",LastName="Rifi"});

            //load file with absolute url
            string htmlSource2 = await _viewRender.RenderAsync("~/Views/Heros/TheFlash.cshtml");
            //create pdf from html string
            byte[] pdf = _pdfGenerator.GeneratePdfFromHtml(htmlSource);
            //write the pdf stream into a file => test only
            System.IO.File.WriteAllBytes("test.pdf",pdf);
            //return the string html source => test only
            return Ok(htmlSource);
        }
    }
}
