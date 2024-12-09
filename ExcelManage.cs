using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace HealthTracker
{
    public class ExcelManage
    {
        private string filePath;
        private string dataFolder;

        public ExcelManage()
        {
            //determines the relative path to the folder so that it can be used on any computer
            string dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            filePath = Path.Combine(dataFolder, "HealthData.xlxs");
        }

        private void ensureDataFileAndFolder()
        {
            //check to see if data folder exists
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }
            //check to see if file exists in folder
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
        }
        private void createExcelFile()
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                //create sheets
                package.Workbook.Worksheets.Add("Calories");
                package.Workbook.Worksheets.Add("Weight");
                package.Workbook.Worksheets.Add("Exercise");

                //save file
                package.Save();
            }
        }
        public void AddToSheet(string sheetName, string[] data)
        {
            //verify if file is in path
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Excel File not found.");
            }

            using (var package = new ExcelPackage(new FileInfo (filePath)))
            {
                var worksheet = package.Workbook.Worksheets[sheetName] ?? package.Workbook.Worksheets.Add(sheetName);

                int row = worksheet.Dimension?.Rows + 1 ?? 1;
                for (int i = 0; i < data.Length; i++)
                {
                    worksheet.Cells[row, i +1].Value = data[i];
                }
                package.Save();
            }
        }
    }
}
