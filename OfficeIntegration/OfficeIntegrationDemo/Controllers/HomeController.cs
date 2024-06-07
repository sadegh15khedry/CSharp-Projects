using ClosedXML.Excel;
using CsvHelper;
using CsvHelper.Configuration;
using DocumentFormat.OpenXml.Packaging;
using Microsoft.AspNetCore.Mvc;
using OfficeIntegrationDemo.Models;
using System.Diagnostics;
using System.Globalization;

namespace OfficeIntegrationDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult DownloadExcellFile()
    {
        //return NotFound("Excell");

        //XLWorkbook workbook = OfficeHelperClass.GetExellFile();
        using (var workbook = new XLWorkbook())
        {
            var sheet = workbook.Worksheets.Add("Test");
            sheet.Cell(1, 1).Value = "1";

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);

                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "Test.xlsx");

            }
        }


    }

    [HttpGet]
    public IActionResult DownloadWordFile()
    {

        var path = @"wwwroot\word\temp.docx";

        MemoryStream stream = new MemoryStream();
        byte[] fileByteArray = System.IO.File.ReadAllBytes(path.ToString());
        stream.Write(fileByteArray, 0, fileByteArray.Length);
        stream.Position = 0;

        using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(stream, true))
        {
            var docText = "";

            using (StreamReader streamReader = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
            {
                docText = streamReader.ReadToEnd();
            }
            docText = docText.Replace("hello", "hi");

            using (StreamWriter streamWriter = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
            {
                streamWriter.Write(docText);
            }

            wordDoc.Save();
            wordDoc.Close();

            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "Test.docx");
        }


    }


    [HttpPost]
    public async Task<IActionResult> ReadFromCsvFile([FromForm] IFormFile csvFile)
    {
        //return NotFound("csv");
        if (csvFile == null)
        {
            return NotFound("file is null");
        }

        string fileExtention = System.IO.Path.GetExtension(csvFile.FileName);
        if (fileExtention != ".csv" && fileExtention != ".CSV")
        {
            return NotFound(fileExtention);
        }

        using (var stremReader = new StreamReader(csvFile.OpenReadStream()))
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null,
                HeaderValidated = null
            };

            using (var csvReader = new CsvReader(stremReader, config))
            {
                var records = csvReader.GetRecords<Person>().ToList();


                return NotFound(records[0]);
            }
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}