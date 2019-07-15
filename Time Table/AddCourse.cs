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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Course.checkCID(textBox1.Text) == true)
            {
                MessageBox.Show("ID is Unavailable");
            }
            else
            {
                string s = comboBox1.Text;
                string t = comboBox2.Text;

                Course.addNewCourse(textBox1.Text, textBox2.Text, textBox2.Text, int.Parse(textBox3.Text), s,t);
                MessageBox.Show("Done");
                Close();
            }

       }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Instructor.Instructorlist.Count; i++)
            {
                string name = Instructor.Instructorlist[i].getIname();
                comboBox1.Items.Add(name);
               
            }
            for (int i = 0; i < Data.courselist.Count; i++)
            {
                string name = Data.courselist[i].getCTA();
                comboBox2.Items.Add(name);

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
            
        }
    }
}
