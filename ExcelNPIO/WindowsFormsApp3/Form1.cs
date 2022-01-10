using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelHelp;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ExcelHandle eh;


        private void Form1_Load(object sender, EventArgs e)
        {
            eh = new ExcelHandle("bhh.xlsx", "naaa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = eh.GetCellValue(Convert.ToInt32 (row.Text), Convert.ToInt32(col.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var filename = SaveExcelFileName();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MultiCell.Text = "";
            var value = eh.GetRowsAndCollums(rows.Text,cols.Text);
            foreach (var rows in value)
            {
                foreach (var cell in rows)
                {
                    MultiCell.Text += cell+" ";
                }
                MultiCell.Text += "\r\n";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List<MinAndMax> minandmaxList = new List<MinAndMax>();
            string str = "10-100;100-300;300-400;400-500;500-1000;1000-5000;5000-10000;10000-100000;100000";
            var value = str.Split(';').ToArray();
            foreach (var item in value)
            {
                var freq = item.Split('-');
                if (freq.Length ==2)
                {
                    minandmaxList.Add(new MinAndMax() { minfreq = Convert.ToDouble(freq[0]), maxfreq = Convert.ToDouble(freq[1]) });
                }
                else if (freq.Length ==1)
                {
                    minandmaxList.Add(new MinAndMax() { minfreq = Convert.ToDouble(freq[0]), maxfreq = 10e9 });
                }
            }
        }
        class MinAndMax
        {
            public double minfreq;
            public double maxfreq;
        }

        private void cols_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            eh.SetCellValue(Convert.ToInt32( setRow.Text), Convert.ToInt32(setCol.Text),SetValue.Text);
        }
    }
}
