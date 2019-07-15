using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Time_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[,] PostionLabel = new Button[6, 6];
        private void Form1_Load(object sender, EventArgs e)
        {
            Data.read();
            for (int i = 0; i < Data.courselist.Count; i++)
            {
                string name = Data.courselist[i].getCLecname();
                comboBox2.Items.Add(name);
                comboBox1.Items.Add(name);
            }

            
            PostionLabel[0, 0] = b1;
            PostionLabel[0, 1] = b2;
            PostionLabel[0, 2] = b3;
            PostionLabel[0, 3] = b4;
            PostionLabel[0, 4] = b5;
            PostionLabel[0, 5] = b6;

            PostionLabel[1, 0] = b11;
            PostionLabel[1, 1] = b12;
            PostionLabel[1, 2] = b13;
            PostionLabel[1, 3] = b14;
            PostionLabel[1, 4] = b15;
            PostionLabel[1, 5] = b16;

            PostionLabel[2, 0] = b21;
            PostionLabel[2, 1] = b22;
            PostionLabel[2, 2] = b23;
            PostionLabel[2, 3] = b24;
            PostionLabel[2, 4] = b25;
            PostionLabel[2, 5] = b26;

            PostionLabel[3, 0] = b31;
            PostionLabel[3, 1] = b32;
            PostionLabel[3, 2] = b33;
            PostionLabel[3, 3] = b34;
            PostionLabel[3, 4] = b35;
            PostionLabel[3, 5] = b36;

            PostionLabel[4, 0] = b41;
            PostionLabel[4, 1] = b42;
            PostionLabel[4, 2] = b43;
            PostionLabel[4, 3] = b44;
            PostionLabel[4, 4] = b45;
            PostionLabel[4, 5] = b46;

            PostionLabel[5, 0] = b51;
            PostionLabel[5, 1] = b52;
            PostionLabel[5, 2] = b53;
            PostionLabel[5, 3] = b54;
            PostionLabel[5, 4] = b55;
            PostionLabel[5, 5] = b56;
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Controls.Add(new Label() { Text = "ID" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Course Lec" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Teacher Assistant" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Instructor" }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Priority" }, 4, 0);
            for (int i = 0; i < Data.courselist.Count; i++)
            {

                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1; // size of rows
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                // Data , colomn index, row index
                tableLayoutPanel1.Controls.Add(new Label() { Text = Data.courselist[i].getCid().ToString() }, 0, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Data.courselist[i].getCLecname() }, 1, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Data.courselist[i].getCTA() }, 2, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Data.courselist[i].getInstructor() }, 3, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Data.courselist[i].getCprty().ToString() }, 4, tableLayoutPanel1.RowCount - 1);

            }
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Controls.Add(new Label() { Text = "ID" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Ins. Name" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Email" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Phone" }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Address" }, 4, 0);

            for (int i = 0; i < Instructor.Instructorlist.Count; i++)
            {

                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1; // size of rows
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                // Data , colomn index, row index
                tableLayoutPanel1.Controls.Add(new Label() { Text = Instructor.Instructorlist[i].getIid().ToString() }, 0, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Instructor.Instructorlist[i].getIname() }, 1, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Instructor.Instructorlist[i].getIemail() }, 2, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Instructor.Instructorlist[i].getIphone() }, 3, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Instructor.Instructorlist[i].getIads() }, 4, tableLayoutPanel1.RowCount - 1);

            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Controls.Add(new Label() { Text = "ID" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Room Name" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Room Place" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Capacity" }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Type " }, 4, 0);

            for (int i = 0; i < Room.roomlist.Count; i++)
            {

                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1; // size of rows
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                // Data , colomn index, row index
                tableLayoutPanel1.Controls.Add(new Label() { Text = Room.roomlist[i].getid().ToString() }, 0, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Room.roomlist[i].getRnum() }, 1, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Room.roomlist[i].getplace() }, 2, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Room.roomlist[i].getcap().ToString() }, 3, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Room.roomlist[i].gettype() }, 4, tableLayoutPanel1.RowCount - 1);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(TimeTable.courselist[6].getCprty().ToString());
            int k = 0;

            int x = 0;
            while (k < Data.courselist.Count)
            {
                for (int i = 0; i < 6; i++)
                {
                    int j = 0;
                    {
                        while (j < 6)
                        {
                            if (x == Room.roomlist.Count)
                            {
                                x = 0;
                            }

                            PostionLabel[i, j].Text = Data.courselist[k].getCLecname() + Environment.NewLine +
                                Data.courselist[k].getInstructor() + Environment.NewLine + Room.roomlist[x].getRnum();
                            j++;
                            x++;
                            PostionLabel[i, j].Text = Data.courselist[k].getCLabname() + Environment.NewLine+ Data.courselist[i].getCTA() +Environment.NewLine + Room.roomlist[x].getRnum();
                            j++;

                            x++;
                            k++;


                        }
                    }
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
           bool x= TimeTable.Priority(comboBox2.Text, comboBox1.Text);
            if(x==true)
            {
                MessageBox.Show("Done");
                b1.Text = "";
                b2.Text = "";
                b3.Text = "";
                b4.Text = "";
                b5.Text = "";
                b6.Text = "";
                b11.Text = "";
                b12.Text = "";
                b13.Text = "";
                b14.Text = "";
                b15.Text = "";
                b16.Text = "";
                b21.Text = "";
                b22.Text = "";
                b23.Text = "";
                b24.Text = "";
                b25.Text = "";
                b26.Text = "";
                b31.Text = "";
                b32.Text = "";
                b33.Text = "";
                b34.Text = "";
                b35.Text = "";
                b36.Text = "";
                b41.Text = "";
                b42.Text = "";
                b43.Text = "";
                b44.Text = "";
                b45.Text = "";
                b46.Text = "";
                b51.Text = "";
                b52.Text = "";
                b53.Text = "";
                b54.Text = "";
                b55.Text = "";
                b56.Text = "";
            }
            if (x == false)
            {
                MessageBox.Show("Priority of new Course is less than Priority of new Course ");
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            AddCourse c = new AddCourse();
            c.Show();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            AddInstructor c = new AddInstructor();
            c.Show();
        }
        private void button27_Click(object sender, EventArgs e)
        {
            AddRoom c = new AddRoom();
            c.Show();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            EditCourse c = new EditCourse();
            c.Show();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            EditInstructor c = new EditInstructor();
            c.Show();
        }
        private void button26_Click(object sender, EventArgs e)
        {
            EditRoom c = new EditRoom();
            c.Show();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            DeleteCourse c = new DeleteCourse();
            c.Show();
        }
        private void button28_Click(object sender, EventArgs e)
        {
            DeleteRoom c = new DeleteRoom();
            c.Show();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            DeleteInstructor c = new DeleteInstructor();
            c.Show();
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Data.write();
            MessageBox.Show("Done");

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Data.write();
            MessageBox.Show("Done");
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Data.write();
            MessageBox.Show("Done");
        }
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Data.write();
            MessageBox.Show("Done");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void saveToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Data.write();
            MessageBox.Show("Done");
        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Controls.Add(new Label() { Text = "ID" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "TA Name" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "TA Email" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "TA Phone" }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "TA Adress " }, 4, 0);

            for (int i = 0; i < Teacher_Assistant.TAlist.Count; i++)
            {

                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1; // size of rows
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                // Data , colomn index, row index
                tableLayoutPanel1.Controls.Add(new Label() { Text = Teacher_Assistant.TAlist[i].getTAid().ToString() }, 0, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Teacher_Assistant.TAlist[i].getTAname() }, 1, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Teacher_Assistant.TAlist[i].getTAmail() }, 2, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Teacher_Assistant.TAlist[i].getTAphone() }, 3, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = Teacher_Assistant.TAlist[i].getTAads() }, 4, tableLayoutPanel1.RowCount - 1);

            }
        }

        private void b1_Click(object sender, EventArgs e)
        {

        }
    }
}
