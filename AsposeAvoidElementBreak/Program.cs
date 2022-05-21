using Aspose.Pdf;

var pdfDocument = new Document();

HtmlLoadOptions options = new HtmlLoadOptions();
var html = "<div style=\"border: 10px solid red; break-inside: avoid; height: 200px\">dont break me </div><div style=\"border: 10px solid red; break-inside: avoid; height: 200px\">dont break me </div><div style=\"border: 10px solid red; break-inside: avoid; height: 200px\">dont break me </div><div style=\"border: 10px solid red; break-inside: avoid; height: 200px\">dont break me </div><div style=\"border: 10px solid red; break-inside: avoid; height: 200px\">dont break me </div>";
            HtmlFragment textFragment = new HtmlFragment(html)
            {
                HtmlLoadOptions = options
            };

var page = pdfDocument.Pages.Add();
page.Paragraphs.Add(textFragment);
pdfDocument.Save("html_test.PDF");