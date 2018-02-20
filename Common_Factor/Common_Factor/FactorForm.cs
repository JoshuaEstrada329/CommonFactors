using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common_Factor
{
    public partial class FactorForm : Form
    {
        public FactorForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grcLb.Text = "";
            lcbLb.Text = "";
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int num1, num2;        

            if (Int32.TryParse(num1TxtBx.Text, out num1) && Int32.TryParse(num2TxtBx.Text, out num2))
            {
                if (num1 > 0 && num2 > 0)
                {
                    grcLb.Text = GreatestCommonFactor(num1, num2).ToString();
                    lcbLb.Text = LeastCommonFactor(num1, num2).ToString();                  
                }
                else
                {
                    MessageBox.Show($"Number 1 or Number 2 cannot be 0 or negative please enter a different number", $"Error in input!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    num1TxtBx.Text = "";
                    num2TxtBx.Text = "";
                }
            }
            else
            {
                MessageBox.Show($"Cannot convert number 1 or 2 to whole numbers, please try again", $"Error in input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                num1TxtBx.Text = "";
                num2TxtBx.Text = "";
            }
        }
        /// <summary>
        /// A method that find's the Greast Common Factor using Euclidean's recursive algorithm
        /// </summary>
        /// <param name="num1">The first number</param>
        /// <param name="num2">The second number</param>
        /// <returns>The Greatest Common Factor between two numbers</returns>
        private int GreatestCommonFactor(int num1, int num2)
        {
            //if number 1 (a) is 0 then b is the GCF
            if (num1 == 0)
                return num2;
            //if number 2 (b) is 0 then a is the GCF
            else if (num2 == 0)
                return num1;
            else
            {
                //Call the method again but pass in b for num1 and remainder of a/b for num 2
                int returnval = GreatestCommonFactor(num2, (num1 % num2));
                return returnval;
            }
        }
        /// <summary>
        /// Finds the Least Common Factor between two numbers
        /// </summary>
        /// <param name="num1">The first number</param>
        /// <param name="num2">The second number</param>
        /// <returns>The Least Common Factor between two numbers</returns>
        private int LeastCommonFactor(int num1, int num2)
        {          
            return ((num1*num2)/GreatestCommonFactor(num1, num2));
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            grcLb.Text = "";
            lcbLb.Text = "";
            num1TxtBx.Text = "";
            num2TxtBx.Text = "";
        }
    }
}
