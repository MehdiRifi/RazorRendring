# Welcome to RazorRending docs!

this is a small showcase on how we can generate a **PDF** from a **razor template**. 

the project was created with asp.net core web api.  
 nugets :   
- Autofac
- Haukcode.DinkToPdf

## PDF Generation Process

![Alt text](PdfReportingApi/Resources/pdf_gen_process.png?raw=true "Title")

## Solution Structure

![Alt text](PdfReportingApi/Resources/projects_structure.png?raw=true "Title")

## Example of usage (home controller)


#### Rendring template #
_viewRender is of type **IViewRender**, you can get the concrete of that abstraction from constructor injection. 
		
        //View name
        string htmlSource = 
        await _viewRender.
        RenderAsync<User>("HelloBuddy",
        new User { FirstName="Mehdi",LastName="Rifi"});
                
        //absolute path
        string htmlSource2 = 
        await _viewRender.
        RenderAsync("~/Views/Heros/TheFlash.cshtml");

RenderAsync support **view name** as well as the **absolute path** too.

#### Generating PDF #
Generate pdf from html as string.  
_pdfGenerator is of type **IPdfGenerator**, you can get the concrete of that abstraction from constructor injection. 

        byte[] pdf = _pdfGenerator.
        GeneratePdfFromHtml(htmlSource);





