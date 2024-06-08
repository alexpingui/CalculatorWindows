using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public int curentTextBoxCursorPosition;
        public Form1()
        {
            InitializeComponent();
            curentTextBoxCursorPosition = ResultBox.TextLength;
        }
        
        private void ResultBox_MouseClick(object sender, MouseEventArgs e)
        {
            curentTextBoxCursorPosition = ResultBox.SelectionStart;
        }

        private void DigitButtons_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsValidChar(((Button)sender).Text[0], ResultBox.Text.Length))
            {
                FontSizeCorrect();
                ResultBox.Text += ((Button)sender).Text;
                curentTextBoxCursorPosition = ResultBox.TextLength;
            }
        }

        private void ClearEnter(object sender, MouseEventArgs e)
        {
            ResultBox.Clear();
            curentTextBoxCursorPosition = ResultBox.TextLength;
        }

        private void ClearAll(object sender, EventArgs e)
        {
            ResultBox.Clear();
            ContainerLbl.ResetText();
            curentTextBoxCursorPosition = ResultBox.TextLength;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length > 0)
            {
                ResultBox.Text = ResultBox.Text.Remove(ResultBox.Text.Length - 1);
            }
            FontSizeCorrect();

            if(curentTextBoxCursorPosition > -1)
                curentTextBoxCursorPosition -= 1;
        }

        private const int ratioLengthFont = 440;
        private readonly char[] validSpecСharacters = new char[] { '+', '-', '/', ',', '*', '^', ','};
        
        /// <summary>
        /// Проверяет число ли мы вводим, не вводится ли спец символ вначале или дважды. В случае ошибки отменяет
        /// ввод
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="e">EEEEEEEEEEEEEEEEEEE</param>
        private void InputValidation(object sender, KeyPressEventArgs e)
        {
            if (IsValidChar(e.KeyChar, ResultBox.SelectionStart))
            {
                FontSizeCorrect();
            }
            else e.Handled = true;

            if (e.KeyChar == '\b') // \b = BackSpace
            {
                int start = ResultBox.SelectionStart;
                int distance = ResultBox.SelectionLength;
                DeleteSimbols(start, distance);
            }

            if(e.KeyChar == 61 || e.KeyChar == 32 || e.KeyChar == 13) // 61 = '=',  32 = Space, 13 = Enter
            {
                ContainerLbl.Text = ResultBox.Text + " =";
                ResultBox.Text = Solver.GetSolution(ResultBox.Text).ToString();
                ResultBox.SelectionStart = ResultBox.TextLength;
            }
        }

        private void DeleteSimbols(int start, int distance)
        {
            if (ResultBox.TextLength != 0)
            {
                if (distance > 0)
                {
                    ResultBox.Text = ResultBox.Text.ToString().Remove(start, distance);
                    ResultBox.SelectionStart = start;

                }

                else if (start > 0)
                {
                    ResultBox.Text = ResultBox.Text.ToString().Remove(start - 1, 1);
                    ResultBox.SelectionStart = start - 1;
                }

                FontSizeCorrect();
            }
            curentTextBoxCursorPosition = ResultBox.SelectionStart;
        }

        private void FontSizeCorrect()
        {
            if (ResultBox.Text.Length >= 12)
            {
                int lengthofstring = ratioLengthFont / ResultBox.Text.Length;
                ResultBox.Font = new Font(ResultBox.Font.FontFamily, lengthofstring, FontStyle.Bold);
            }
            else ResultBox.Font = new Font(ResultBox.Font.FontFamily, 40, FontStyle.Bold);
        }

        private bool IsValidChar(char ch, int cursorPos)
        {
            if (char.IsDigit(ch) && IsDigitLengthGood(cursorPos - 1))
                return true;
            
            if (validSpecСharacters.Contains(ch))
                if (ResultBox.Text.Length > 0 && char.IsDigit(ResultBox.Text.Last()))
                {
                    ContainerLbl.Text = Solver.GetSolution(ResultBox.Text).ToString();
                    return true;
                }
            return false;
        }

        public bool IsDigitLengthGood(int cursorPos)
        {
            string digit = String.Empty;
            if (ResultBox.Text.Length == 0) return true;

            int beginningOfDigit = 0;

            if (ResultBox.Text.Length > 0)
            {
                for (int curentPos = cursorPos; curentPos > -1; curentPos--)
                {
                    if (!Char.IsDigit(ResultBox.Text[curentPos])) {beginningOfDigit = curentPos; break;}
                }

                for (int lastPos = beginningOfDigit + 1; lastPos < ResultBox.Text.Length && lastPos > -1; lastPos++)
                {
                    if (Char.IsDigit(ResultBox.Text[lastPos]))
                    {
                        digit += ResultBox.Text[lastPos];
                        if (digit.Length >= 15) return false;
                    }
                    else break;
                }
            }
            return true;
        }

        private void ActionBtns_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsValidChar(((Button)sender).Text[0], ResultBox.Text.Length))
            {
                FontSizeCorrect();
                ResultBox.Text += ((Button)sender).Text;
                ContainerLbl.Text = "= " + Solver.GetSolution(ResultBox.Text).ToString();
            }
            curentTextBoxCursorPosition = ResultBox.TextLength;
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            ContainerLbl.Text = ResultBox.Text + " =";
            ResultBox.Text = Solver.GetSolution(ResultBox.Text).ToString();
            FontSizeCorrect();
            curentTextBoxCursorPosition = ResultBox.TextLength;
        }

        private void SpecFunctions_MouseClick(object sender, MouseEventArgs e)
        {
            if (ResultBox.Text.Length == 0) return;

            int cursorPos = curentTextBoxCursorPosition;
            string digit = String.Empty;
            int beginningOfDigit = 0;

            if (ResultBox.Text.Length > 0)
            {
                if (cursorPos != 0) cursorPos--;

                for (int curentPos = cursorPos; curentPos > -1; curentPos--)
                {
                    if (!Char.IsDigit(ResultBox.Text[curentPos]) && !(ResultBox.Text[curentPos] == ',')) { beginningOfDigit = curentPos + 1; break; }
                }

                if (beginningOfDigit == 1) beginningOfDigit --;

                for (int lastPos = beginningOfDigit; lastPos < ResultBox.Text.Length && lastPos > -1; lastPos++)
                {
                    if (lastPos == ResultBox.Text.Length) lastPos--;

                    if (Char.IsDigit(ResultBox.Text[lastPos]) || ResultBox.Text[lastPos] == ',')
                    {
                        digit += ResultBox.Text[lastPos];
                    }
                    else break;
                }
            }

            if (digit.Length == 0) return;

            double tempDigit = double.Parse(digit);

           



            switch (((Button)sender).Name)
            {
                case "powBtn":
                    tempDigit = Math.Pow(tempDigit, 2);
                    break;

                case "percentBtn":
                    tempDigit /= 100;
                    break;

                case "sqrtBtn":
                    tempDigit = Math.Sqrt(tempDigit);
                    break;

                case "oppositeBtn":
                    tempDigit = Math.Pow(tempDigit, -1);
                    break;

            }

            string newDigit = tempDigit.ToString();

            string newResult = ResultBox.Text;
            
            newResult = newResult.Remove(beginningOfDigit, digit.Length);
            
            newResult = newResult.Insert(beginningOfDigit, newDigit);           

            ResultBox.Text = newResult;
            curentTextBoxCursorPosition = ResultBox.TextLength;
            FontSizeCorrect();
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = ResultBox.Text.Insert(curentTextBoxCursorPosition, ",");
        }

        private void тёмнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button[] digitButtons = new Button[] {oneBtn, twoBtn, threeBtn, fourBtn, fiveBtn, sixBtn, sevenBtn, eightBtn,
            nineBtn, zeroBtn, dotBtn, ChSightBtn};

            Button[] actionButtons = new Button[] {percentBtn, CEbtn, Cbtn, oppositeBtn, sqrtBtn, powBtn, multiplicationBtn,
            divideBtn, BackBtn, minusBtn, plusBtn};

            foreach (Button digitButton in digitButtons)
            {
                digitButton.BackColor = Color.SlateGray;
                digitButton.ForeColor = Color.WhiteSmoke;
            }

            foreach (Button actionButton in actionButtons)
            {
                actionButton.BackColor = Color.DarkSlateGray;
                actionButton.ForeColor = Color.WhiteSmoke;
            }

            resultBtn.BackColor = Color.RoyalBlue;
            resultBtn.ForeColor = Color.WhiteSmoke;

            ResultBox.BackColor = Color.DarkSeaGreen;
            ResultBox.ForeColor = Color.WhiteSmoke;

            ContainerLbl.BackColor = Color.DarkSeaGreen;
            
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button[] digitButtons = new Button[] {oneBtn, twoBtn, threeBtn, fourBtn, fiveBtn, sixBtn, sevenBtn, eightBtn,
            nineBtn, zeroBtn, dotBtn, ChSightBtn};

            Button[] actionButtons = new Button[] {percentBtn, CEbtn, Cbtn, oppositeBtn, sqrtBtn, powBtn, multiplicationBtn,
            divideBtn, BackBtn, minusBtn, plusBtn};

            foreach (Button digitButton in digitButtons)
            {
                digitButton.BackColor = Color.LightGray;
                digitButton.ForeColor = Color.Black;
            }

            foreach (Button actionButton in actionButtons)
            {
                actionButton.BackColor = Color.WhiteSmoke;
                actionButton.ForeColor = Color.Black;
            }

            resultBtn.BackColor = Color.LightSteelBlue;
            resultBtn.ForeColor = Color.Black;

            ResultBox.BackColor = Color.White;
            ResultBox.ForeColor = Color.Black;

            ContainerLbl.BackColor = Color.White;
        }
    }
}