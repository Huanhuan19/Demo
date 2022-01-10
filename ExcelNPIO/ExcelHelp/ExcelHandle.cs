using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace ExcelHelp
{
    public class ExcelHandle
    {
        IWorkbook workbook;
        ISheet sheet;
        string fileName;

        public ExcelHandle(string fileN, string sheetN)
        {
            OpenSheet(sheetN, fileN);
            fileName = fileN;
        }

        public void OpenSelectExcel(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            if (fileName.Contains(".xlsx"))
            {
                workbook = new XSSFWorkbook(fs);
            }
            else if (fileName.Contains(".xls"))
            {
                workbook = new HSSFWorkbook(fs);
            }
        }

        public void OpenSheet(string sheetName, string fileName = "")
        {
            try
            {
                if (!string.IsNullOrEmpty(fileName) && workbook == null)
                {
                    OpenSelectExcel(fileName);
                    if (workbook == null)
                    {
                        throw new Exception("wookbook is null");
                    }
                }
                if (!string.IsNullOrEmpty(sheetName) && sheet == null)
                {
                    sheet = workbook.GetSheet(sheetName);
                }
                if (sheet == null)
                {
                    throw new Exception("sheet is not exist");
                }
            }
            catch
            {
                throw new Exception("open excel sheet fale");
            }

        }
        /// <summary>
        /// get cell value
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="ColumnIndex"></param>
        /// <param name="fileName"></param>
        /// <param name="sheetName"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public string GetCellValue(int rowIndex, int ColumnIndex)
        {

            if (sheet == null)
            {
                throw new Exception("The current sheet is null");
            }
            var cell = sheet.GetRow(rowIndex).GetCell(ColumnIndex);
            if (cell != null)
            {
                return cell.ToString();
            }
            return "";
        }

        public List<List<string>> GetRowsAndCollums(string rowstr, string columnstr)
        {
            List<List<string>> values = new List<List<string>>();

            var rows = GetNumbers(rowstr);
            var columns = GetNumbers(columnstr);
            foreach (var r in rows)
            {
                List<string> rowValue = new List<string>();
                foreach (var c in columns)
                {
                    rowValue.Add(GetCellValue(r, c));
                }
                values.Add(rowValue);
            }
            return values;
        }

        public void SetCellValue(int rowIndex, int ColumnIndex, string value)
        {
            if (sheet == null)
            {
                throw new Exception("The current sheet is null");
            }
            var cell = sheet.CreateRow(rowIndex).CreateCell(ColumnIndex);
            if (cell != null)
            {
                cell.SetCellValue(value);
            }
            SaveExcel(workbook, fileName);
        }

        public string SaveExcelFile(IWorkbook workbook, string FileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //设置文件标题
            saveFileDialog.Title = "导出Excel文件";
            //设置文件类型
            saveFileDialog.Filter = "Excel 工作簿(*.xlsx)|*.xlsx|Excel 97-2003 工作簿(*.xls)|*.xls";
            //设置默认文件类型显示顺序  
            saveFileDialog.FilterIndex = 1;
            //是否自动在文件名中添加扩展名
            saveFileDialog.AddExtension = true;
            //是否记忆上次打开的目录
            saveFileDialog.RestoreDirectory = true;
            //设置默认文件名
            saveFileDialog.FileName = FileName;
            //按下确定选择的按钮  
            string localFilePath = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径 
                localFilePath = saveFileDialog.FileName.ToString();

                //转为字节数组  
                MemoryStream stream = new MemoryStream();
                workbook.Write(stream);
                var buf = stream.ToArray();

                //保存为Excel文件  
                using (FileStream fs = new FileStream(localFilePath, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(buf, 0, buf.Length);
                    fs.Flush();
                    fs.Close();
                }
            }
            return localFilePath;
        }

        private void SaveExcel(IWorkbook workbook, string localFilePath)
        {
            try
            {
                //转为字节数组  
                MemoryStream stream = new MemoryStream();
                workbook.Write(stream);
                var buf = stream.ToArray();

                //保存为Excel文件  
                using (FileStream fs = new FileStream(localFilePath, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(buf, 0, buf.Length);
                    fs.Flush();
                    fs.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<int> GetNumbers(string str)
        {
            List<int> nums = new List<int>();
            var value = str.Split(':').ToArray();
            if (value.Count() < 1)
            {
                return null;
            }
            else if (value.Count() == 1)
            {
                nums.Add(Convert.ToInt32(value[0]));
                return nums;
            }
            for (int i = Convert.ToInt32(value[0]); i <= Convert.ToInt32(value[1]); i++)
            {
                nums.Add(i);
            }
            return nums;
        }

    }
}
