using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }
        public Form2(string i)
        {
            InitializeComponent();
            label1.Text= "Your time: "+i +" Play again?" ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnValue1 = "No";
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnValue1 = "Yes";
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
