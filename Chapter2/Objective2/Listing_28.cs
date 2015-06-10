namespace Chapter2.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class Listing_28
    {
        static void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;

            excelApp.Workbooks.Add();

            dynamic workSheet = excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Header A";
            workSheet.Cells[1, "B"] = "Header B";

            var row = 1;
            foreach (var entity in entities)
            {
                row++;
                workSheet.Cells[row, "A"] = entity.ColumnA;
                workSheet.Cells[row, "B"] = entity.ColumnB;
            }

            workSheet.Columns[1].Autofit();
            workSheet.Columns[2].Autofit();
        }

        [TestMethod]
        public void Main()
        {
            var entities = new List<dynamic>
            {
                new 
                {
                    ColumnA = 1,
                    ColumnB = "Foo",
                },
                new 
                {
                    ColumnA = 2,
                    ColumnB = "Bar",
                }
            };

            DisplayInExcel(entities);
        }
    }
}
