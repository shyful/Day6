using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }
        Student aStudent=new Student();
        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.reg = regtextBox.Text;
            aStudent.first_name = fnametextBox.Text;
            aStudent.last_name = lnametextBox.Text;
            MessageBox.Show(aStudent.GetFullName() +"'s Reg no is "+aStudent.reg);
            regtextBox.Clear();
            fnametextBox.Clear();
            lnametextBox.Clear();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regtextBox.Text = aStudent.reg;
            fnametextBox.Text = aStudent.first_name;
            lnametextBox.Text = aStudent.last_name;
        }
    }
}
