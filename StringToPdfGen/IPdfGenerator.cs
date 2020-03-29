using System;
namespace PdfGen
{
    public interface IPdfGenerator
    {
        Byte[] GeneratePdfFromHtml(string htmlSource);
    }
}
