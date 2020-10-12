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

namespace BasicFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            textBoxDisplay.Text = "반갑습니다~";
        }

        private void buttonBinaryWriter_Click(object sender, EventArgs e)
        {
            //long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("Write Data Start.");
            long someValue = 1234567;
            Stream outStream = new FileStream("a.dat", FileMode.Create);
            byte[] wbytes = BitConverter.GetBytes(someValue);

            outStream.Write(wbytes, 0, wbytes.Length);

            outStream.Close();
            Console.WriteLine("Write Data Done.");
        }

        private void buttonBinaryReader_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Read Data Start ");
            byte[] rBytes = new byte[8];
            Stream inStream = new FileStream("a.dat", FileMode.Open);

            inStream.Read(rBytes, 0, rBytes.Length);

            long readValue = BitConverter.ToInt64(rBytes, 0);

            Console.WriteLine("Read Data = " + readValue);

            inStream.Close();


        }

        private void buttonStreamWriter_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
            sw.WriteLine(int.MaxValue);
            sw.WriteLine("Good morning");
            sw.WriteLine(uint.MaxValue);
            sw.WriteLine("안녕하세요!");
            sw.WriteLine(double.MaxValue);
            sw.Close();
        }

        private void buttonStreamReader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));

            textBoxDisplay.Text = "";
            while (sr.EndOfStream == false)
            {
                textBoxDisplay.Text += sr.ReadLine();
                textBoxDisplay.Text += "\r\n";
            }

            sr.Close();

        }
    }
}
