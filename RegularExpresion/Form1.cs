using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;



namespace RegularExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Assigning the entered text from text box to a Regex variable
                Regex myRegularExpression = new Regex(textBoxPattern.Text);

                // Check if the string from right text box respects Regular Expression (pattern) specified above
                if (myRegularExpression.IsMatch(textBoxString.Text))
                {
                    // If it resrects pattern, pop-up an MessageBox with Success text
                    MessageBox.Show("SUCCESS! String respects the pattern!");
                }
                else
                {
                    // If it doesn't resrects pattern, pop-up an MessageBox with Error text
                    MessageBox.Show("ERROR! String doesn't respect the pattern!");
                }
            }
            catch (Exception)
            {
                // Catch an error if the pattern inserted respects Regular Expression format
                // And return an MessageBox with specific error
                MessageBox.Show("ERROR! The pattern doesn't respect Regular Expression format!");
            }
          
        }

        private void textBoxPattern_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxString_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
