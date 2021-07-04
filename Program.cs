using System.IO;
using OfficeOpenXml;

namespace ExcelDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
      FileInfo file = new(@"myWorkbook.xlsx");

      using (var package = new ExcelPackage(file))
      {
        var sheet = package.Workbook.Worksheets.Add("My Sheet");
        sheet.Cells["A1"].Value = "Hello World!";

        sheet.Cells["A2"].Value = 5;
        sheet.Cells["A3"].Value = 3;

        sheet.Cells["A4"].Formula = "=A2+A3";


        // Save to file
        package.Save();
      }

    }
  }
}
