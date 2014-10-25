using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorxBox
{
    public partial class Form1 : Form
    {

        /// <summary>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void SetWindowText(int hWnd, String text);

        int hej = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
