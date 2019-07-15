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
    public partial class DeleteCourse : Form
    {
        public DeleteCourse()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Course.checkCID(textBox1.Text) == false)
            {
                MessageBox.Show("ID is NotFound");
            }
            else
            {
                Course.Delete(textBox1.Text);
                MessageBox.Show("Done");
                Close();
            }
        }
    }
}
