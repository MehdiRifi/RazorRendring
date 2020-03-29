using System;
using DinkToPdf;
using DinkToPdf.Contracts;

namespace PdfGen
{
    public class PdfGenerator : IPdfGenerator
    {
        private readonly IConverter _pdfConverter;
        public PdfGenerator(IConverter converter)
        {
            _pdfConverter = converter;
        }
        public Byte[] GeneratePdfFromHtml(string htmlSource)
        {
            var globalSettings = new GlobalSettings
            {
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings() { Top = 10 },
                DPI = 380,
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlSource,
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] de [toPage]", Line = true, Spacing = 1 },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Footer 2020" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            return _pdfConverter.Convert(pdf);
        }
    }
}
