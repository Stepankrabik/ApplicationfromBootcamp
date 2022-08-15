using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_boi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool isNumber = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KeyDownTxt(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9
                || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9
               || e.KeyCode == Keys.Back;
        }

        private void KeyPressTxt(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;

            switch(e.KeyChar)
            {
                case '-':
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '.':
                    if (box.Text.Length == 0)
                        break;
                    if (box.Text[0] == '-' && box.Text.Length == 1)
                        break;
                    if (box.Text.IndexOf('-') == -1)
                        isNumber = true;
                    break;

            }
            if (!isNumber)
                e.Handled = true;

        }
        private double numFirst, numSecond, numres;
        private void btnClicked(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtFirst.Text);
            string strSecond = string.Copy(txtSecond.Text);

            int pos = strFirst.IndexOf('.');
            if (pos != -1)
            {
                strFirst = strFirst.Substring(0, pos) + ',' + strFirst.Substring(pos + 1);
            }
             pos = strSecond.IndexOf('.');
            if (pos != -1)
            {
                strFirst = strSecond.Substring(0, pos) + ',' + strSecond.Substring(pos + 1);
            }

            if (txtFirst.Text.Length > 0)
                numFirst = Convert.ToDouble(strFirst);
            else
                numFirst = 0.0D;

            if (txtSecond.Text.Length > 0)
                numSecond = Convert.ToDouble(strSecond);
            else
                numSecond = 0.0D;
            
            
            string btnText = "";
            Button btn = (Button)sender;

            switch(btn.Name)
            {
                case "btnIncrement":
                    btnText = "\"+\"";
                    numres = numFirst + numSecond;
                    txtResult.Text = numres.ToString();
                    break;
                case "btnDecrement":
                    btnText = "\"-\"";
                    numres = numFirst - numSecond;
                    txtResult.Text = numres.ToString();
                    break;

                case "btnIncrease":
                    btnText = "\"*\"";
                    numres = numFirst * numSecond;
                    txtResult.Text = numres.ToString();
                    break;

                case "btnDivide":
                    btnText = "\"/\"";
                    numres = numFirst / numSecond;
                    txtResult.Text = numres.ToString();
                    break;
            }
            System.Diagnostics.Debug.WriteLine("Button Pressed" + btnText);
        }
    }
}
