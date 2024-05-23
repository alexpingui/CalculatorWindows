using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button22_MouseClick(object sender, MouseEventArgs e)
        {
            ResultBox.Text += ((Button)sender).Text;  
        }

        private void ClearEnter(object sender, MouseEventArgs e)
        {
            ResultBox.Clear();
        }

        private void ClearAll(object sender, EventArgs e)
        {
            ResultBox.Clear();
            ContainerLbl.ResetText();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if(ResultBox.Text.Length > 0)
            {
                ResultBox.Text = ResultBox.Text.Remove(ResultBox.Text.Length - 1);
                
            }
            
        }

        private void ResultBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyValue) && !char.IsControl((char)e.KeyValue))
            {
                e.Handled = true;
            }
        }
    }
}
