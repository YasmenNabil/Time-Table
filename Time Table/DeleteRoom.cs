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
    public partial class DeleteRoom : Form
    {
        public DeleteRoom()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Room.checkRID(textBox1.Text) == false)
            {
                MessageBox.Show("ID is NotFound");
            }
            else
            {
                Room.Delete(textBox1.Text);
                MessageBox.Show("Done");
                Close();
            }
        }
    }
}
