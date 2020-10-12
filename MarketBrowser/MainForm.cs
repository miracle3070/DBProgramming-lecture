using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<List<string>> MakeCloumnarDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open),
                Encoding.Default);

            var line = sr.ReadLine();
            var headers = line.Split(',');
            string str = "";

            List<List<string>> data = new List<List<string>>();
            foreach (string header in headers)
            {
                List<string> list = new List<string>();
                list.Add(header);
                data.Add(list);
            }

            int row = 0;
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var values = line.Split(',');

                for (int i = 0; i < values.Length; i++)
                {
                    data[i].Add(values[i]);
                }

                if (row++ == 10)
                    break;
            }

            //textBoxCSVViewer.Text = str;

            sr.Close();
            return data;
        }

        private void printColumnData_columnbased(List<List<string>> data, int columnIndex)
        {
            string str = "";
            textBoxCSVViewer.Text = "";
            foreach (string value in data[1])
            {
                str += value + "\r\n";
            }
            textBoxCSVViewer.Text = str;

        }

        private void printRowData_columnbased(List<List<string>> data)
        {
            string str = "";
            for (int row = 0; row < data[0].Count; row++)
            {
                foreach(List<string> list in data)
                {
                    str += list[row] + "\t";
                }
                str += "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        // 과제: 이 함수를 적절하게 수정하여 과제방에 올릴것
        private string[] parseCSVLine(string line)
        {
            return line.Split(',');
        }

        private List<List<string>> MakeRowbasedDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open),
                Encoding.Default);

            var line = sr.ReadLine();

            List<List<string>> data = new List<List<string>>();

            int row = 0;
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var values = line.Split(',');

                data.Add(values.ToList());

                if (row++ == 10)
                    break;
            }

            sr.Close();
            return data;
        }

        private void printRowData_rowbased(List<List<string>> data)
        {
            string str = "";
            foreach(List<string> rowlist in data)
            {
                foreach (string value in rowlist)
                    str += value + "\t";
                str += "\r\n";
            }

            textBoxCSVViewer.Text = str;
        }

        private void printColumnData_rowbased(List<List<string>> data, int colIdx)
        {
            string str = "";
            foreach (List<string> rowlist in data)
            {
                str += rowlist[colIdx] + "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            List<List<string>> data = MakeRowbasedDataStructure();
            //printRowData_rowbased(data);
            printColumnData_rowbased(data, 1);


            //List<List<string>> data = MakeCloumnarDataStructure();
            //printColumnData_columnbased(data, 1);
            //printRowData_columnbased(data);
        }
    }
}
