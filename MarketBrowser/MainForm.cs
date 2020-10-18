using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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

            //int row = 0;
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                //List<string> values = parseCSVLine(line);
                string[] values = parseCSVLine(line);

                for (int i = 0; i < values.Length; i++)
                {
                    data[i].Add(values[i]);
                }

                //   if (row++ == 10)
                //       break;
            }

            //textBoxCSVViewer.Text = str;

            sr.Close();
            return data;
        }

        private void printColumnData_columnbased(List<List<string>> data, int columnIndex)
        {
            string str = "";
            textBoxCSVViewer.Text = "";
            foreach (string value in data[columnIndex])
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
                foreach (List<string> list in data)
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
            var splitLine = line.Split(',');
            List<string> result = new List<string>();
            string temp = "";
            for (int i = 0; i < splitLine.Length; i++)
            {
                temp = "";
                if (splitLine[i][0] == '\"')
                {
                    temp += splitLine[i];
                    temp += ",";
                    i++;

                    while (splitLine[i][splitLine[i].Length - 1] != '\"')
                    {
                        temp += splitLine[i];
                        temp += ",";
                        i++;
                    }
                    temp += splitLine[i];
                    temp = temp.Remove(temp.Length-1);
                    temp = temp.Remove(0,1);
                    result.Add(temp);
                    continue;
                }
                else
                {
                    temp = splitLine[i];
                    result.Add(temp);;
                }
            }

            return result.ToArray();
        }

        Dictionary<string, int> headerIndexDict = new Dictionary<string, int>();

        private void SetHeaderList(string header)
        {
            //List<string> values = parseCSVLine(header);
            string[] values = parseCSVLine(header);
            listBoxHeaders.Items.Clear();

            for(int i = 0; i < values.Length; i++)
            {
                string column = values[i];
                listBoxHeaders.Items.Add(column);
                headerIndexDict[column] = i;
            }
        }

        List<List<string>> data;

        private List<List<string>> MakeRowbasedDataStructure(string filename)
        {
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open),
                Encoding.Default);

            var line = sr.ReadLine();
            SetHeaderList(line);

            data = new List<List<string>>();

            //int row = 0;
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                //List<string> values = parseCSVLine(line);
                string[] values = parseCSVLine(line);

                data.Add(values.ToList());

                //   if (row++ == 10)
                //       break;
            }

            sr.Close();
            return data;
        }

        private void printRowData_rowbased(List<List<string>> data, TextBox textbox)
        {
            string str = "";
            foreach (List<string> rowlist in data)
            {
                foreach (string value in rowlist)
                    str += value + "\t";
                str += "\r\n";
            }

            textbox.Text = str;
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
            var FD = new OpenFileDialog();
            DialogResult dResult = FD.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                string filename = FD.FileName;
                MessageBox.Show(filename, "확인");
                List<List<string>> data = MakeRowbasedDataStructure(filename);
                printRowData_rowbased(data, textBoxCSVViewer);

            }

            //printColumnData_rowbased(data, 1);


            //List<List<string>> data = MakeCloumnarDataStructure();
            //printColumnData_columnbased(data, 1);
            //printRowData_columnbased(data);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearchKeyword.Text;

            if (keyword == "")
            {
                MessageBox.Show("검색 키워드를 입력하세요.", "확인");
                return;
            }

            if (listBoxHeaders.SelectedItem == null)
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }

            string column = listBoxHeaders.SelectedItem.ToString();
            if (column == "")
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }

            MessageBox.Show("컬럼: " + column + " / 키워드: " + keyword);

            DoSearch(keyword, column);


        }

        private void DoSearch(string keyword, string column)
        {
            // 1. 대상 컬럼 확인
            if(headerIndexDict.ContainsKey(column) == false)
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }
            int targetColumnIndex = headerIndexDict[column];

            // 2. 대상 컬럼에서 키워드를 포함하는지 확인
            List<List<string>> resultData = new List<List<string>>();
            foreach(List<string> row in data)
            {
                string value = row[targetColumnIndex];
                if(value.Contains(keyword))
                {
                    resultData.Add(row);
                }
            }

            printRowData_rowbased(resultData, textBoxSearchResult);

        }
    }
}
