using System;
using Autofac;
using DinkToPdf;
using DinkToPdf.Contracts;
using PdfGen;

namespace HtmlPdfGen
{
    public class PdfGenModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.Register(c => new SynchronizedConverter(new PdfTools())).As<IConverter>().SingleInstance();
            builder.RegisterType<PdfGenerator>().As<IPdfGenerator>().InstancePerLifetimeScope();

        }
    }
}
