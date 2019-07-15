using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table
{
    public partial class AddInstructor : Form
    {
        public AddInstructor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                if (Instructor.checkIID(int.Parse(textBox1.Text)) == true)
                     {
                        MessageBox.Show("ID is Unavailable");
                     }

                 else if (Instructor.checkIID(int.Parse(textBox1.Text)) == false)
                     {
                Instructor.addNewInstructor(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("Done");
                Close();
                      }
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == true)
            {
                if ( Teacher_Assistant.checkTID(int.Parse(textBox1.Text)) == true)
                {
                    MessageBox.Show("ID is Unavailable");
                }
                else if (Teacher_Assistant.checkTID(int.Parse(textBox1.Text)) == false)
                {
                    Teacher_Assistant.addNewTA(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    MessageBox.Show("Done");
                    Close();
                }
            }
            else if ((checkBox1.Checked == true && checkBox2.Checked == true) || (checkBox1.Checked == false && checkBox2.Checked == false))
            {
                MessageBox.Show("You Should Determine TA Or Instructor");
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
