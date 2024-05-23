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
            if (IsTextLengthValid())
            {
                FontSizeCorrect();
                ResultBox.Text += ((Button)sender).Text;
            }  
        }

        private bool IsTextLengthValid()
        {
            return ResultBox.Text.Length <= 30;
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
            if (ResultBox.Text.Length > 0)
            {
                ResultBox.Text = ResultBox.Text.Remove(ResultBox.Text.Length - 1);
            }
            FontSizeCorrect();
        }

        private const int ratioLengthFont = 440;
        private readonly char[] validSpecСharacters = new char[] {'+', '-', '/', ',', '*', '^'};

        /// <summary>
        /// Проверяет число ли мы вводим, не вводится ли спец символ вначале или дважды. В случае ошибки отменяет
        /// ввод
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="e">EEEEEEEEEEEEEEEEEEE</param>
        private void InputValidation(object sender, KeyPressEventArgs e)
        {
            if (IsTextLengthValid())
            {
                FontSizeCorrect();
                IsValidChar(e.KeyChar);
                return;
            }
            e.Handled = true;
        }

        private void FontSizeCorrect()
        { 
            if (ResultBox.Text.Length >= 12)
            {
                int lengthofstring = ratioLengthFont / ResultBox.Text.Length;
                ResultBox.Font = new Font(ResultBox.Font.FontFamily, lengthofstring, FontStyle.Bold);
            }
        }

        private bool IsValidChar(char ch)
        {
            if (char.IsDigit(ch)) return true;

            if (validSpecСharacters.Contains(ch))
                if (ResultBox.Text.Length > 0 && char.IsDigit(ResultBox.Text.Last()))
                    return true;
            return false;
        }
    }
}
