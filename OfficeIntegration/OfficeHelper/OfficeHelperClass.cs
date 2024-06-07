using ClosedXML.Excel;

namespace OfficeHelper;

public class OfficeHelperClass
{
    public static Array GetExellFile()
    {
        using (var workbook = new XLWorkbook())
        {
            var sheet = workbook.Worksheets.Add("Test");
            sheet.Cell(1, 1).Value = "1";

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);

                var content = stream.ToArray();
                return content;


            }

        }

    }


}
