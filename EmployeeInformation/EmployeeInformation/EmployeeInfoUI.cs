using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public partial class EmployeeInfoUI : Form
    {
        public EmployeeInfoUI()
        {
            InitializeComponent();
        }
        EmpolyeeInfo aEmpolyeeInfo=new EmpolyeeInfo();
        

        private void showButton_Click(object sender, EventArgs e)
        {
            
            //salary1 = Convert.ToString(salary);
            aEmpolyeeInfo.id = idtextBox.Text;
            aEmpolyeeInfo.name = nametextBox.Text;
            aEmpolyeeInfo.salary = Convert.ToDouble(salarytextBox.Text);
            MessageBox.Show(aEmpolyeeInfo.id+"\n"+aEmpolyeeInfo.name+"\n"+aEmpolyeeInfo.salary);
            idtextBox.Clear();
            nametextBox.Clear();
            salarytextBox.Clear();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idtextBox.Text = aEmpolyeeInfo.id;
            nametextBox.Text = aEmpolyeeInfo.name;
            //aEmpolyeeInfo.salary = Convert.ToDouble(salarytextBox.Text);
            salarytextBox.Text = aEmpolyeeInfo.salary.ToString();
        }
    }
}
