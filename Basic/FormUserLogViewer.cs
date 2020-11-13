using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic
{
    public partial class FormUserLogViewer : Form
    {
        private string text;
        public FormUserLogViewer()
        {
            InitializeComponent();
        }

        public void SetLogText(string text)
        {
            this.text = text;
        }
    }
}
