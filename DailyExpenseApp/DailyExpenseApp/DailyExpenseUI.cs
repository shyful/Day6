using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace DailyExpenseApp
{
    public partial class DailyExpenseUI : Form
    {
        public DailyExpenseUI()
        {
            InitializeComponent();
        }
        string pathName = @"F:\DailyExpenseInfo.csv";
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathName))
            {
                FileStream aStream = new FileStream(pathName, FileMode.Append);
                CsvFileWriter csvWriter = new CsvFileWriter(aStream);
                List<string> infoList = new List<string>();
                infoList.Add(amounttextBox.Text);
                infoList.Add(categorycomboBox.Text);
                infoList.Add(particulartextBox.Text);
                csvWriter.WriteRow(infoList);
                aStream.Close();
                MessageBox.Show("New Information Add");
            }
            else
            {
                FileStream aStream = new FileStream(pathName, FileMode.Append);
                CsvFileWriter csvWriter = new CsvFileWriter(aStream);
                List<string> infoList = new List<string>();
                infoList.Add(amounttextBox.Text);
                infoList.Add(categorycomboBox.Text);
                infoList.Add(particulartextBox.Text);
                csvWriter.WriteRow(infoList);
                aStream.Close();
                MessageBox.Show("New Information Add");
            }
        }

        private void show_summaryButton_Click(object sender, EventArgs e)
        {
             
                //infoListView.Items.Clear();
                FileStream aStream = new FileStream(pathName, FileMode.Open);
                CsvFileReader csvReader = new CsvFileReader(aStream);
                List<string> infoList = new List<string>();
                double salary, totalAmount = 0;
              
            while (csvReader.ReadRow(infoList))
            {
                //string[] infoStrings = infoList.Split(',');
                //infoList.Add(amounttextBox.Text);
                ListViewItem myView = new ListViewItem(infoList[0]);
                salary = Convert.ToDouble(infoList[0]);
               
                totalAmount += salary;
                
            }
            salary = double.MaxValue;
            maximum_expensetextBox.Text = salary.ToString();
                //infoList[0].ToString().Max().ToString();     
            total_expensetextBox.Text = totalAmount.ToString();
             
            aStream.Close();
        }

        private void category_selectionButton_Click(object sender, EventArgs e)
        {
            infolistView.Items.Clear();

            FileStream aStream = new FileStream(pathName, FileMode.Open);
            CsvFileReader csvReader = new CsvFileReader(aStream);
            List<string> infoList = new List<string>();
            double salary, totalAmount = 0;
            while (csvReader.ReadRow(infoList))
            {
                if (view_categorycomboBox.Text == "House Rent")
                {
                    //string search = infoList[0];
                    string gainword = view_categorycomboBox.Text;
                    //bool b=true;
                    ListViewItem myView = new ListViewItem(infoList[0]);
                    if (infoList[1].ToLower().Contains(gainword.ToLower()))
                    {
                        //showalllistView.Items.Add(aStudentDataRead[0]);
                        for (int i = 1; i < 3; i++)
                            myView.SubItems.Add(infoList[i]);
                        infolistView.Items.Add(myView);
                        salary = Convert.ToDouble(infoList[0]);
                        totalAmount += salary;
                    }
                    total_amounttextBox.Text = totalAmount.ToString();
                }
                else if (view_categorycomboBox.Text == "Utility Bill")
                {
                    string search = infoList[0];
                    string gainword = view_categorycomboBox.Text;
                    //bool b=true;
                    ListViewItem myView = new ListViewItem(infoList[0]);
                    if (infoList[1].ToLower().Contains(gainword.ToLower()))
                    {
                        //showalllistView.Items.Add(aStudentDataRead[0]);
                        for (int i = 1; i < 3; i++)
                            myView.SubItems.Add(infoList[i]);
                        infolistView.Items.Add(myView);
                        salary = Convert.ToDouble(infoList[0]);
                        totalAmount += salary;
                    }
                    total_amounttextBox.Text = totalAmount.ToString();
                }
                else if (view_categorycomboBox.Text == "Conveyance")
                {
                    string search = infoList[0];
                    string gainword = view_categorycomboBox.Text;
                    //bool b=true;
                    ListViewItem myView = new ListViewItem(infoList[0]);
                    if (infoList[1].ToLower().Contains(gainword.ToLower()))
                    {
                        //showalllistView.Items.Add(aStudentDataRead[0]);
                        for (int i = 1; i < 3; i++)
                            myView.SubItems.Add(infoList[i]);
                        infolistView.Items.Add(myView);
                        salary = Convert.ToDouble(infoList[0]);
                        totalAmount += salary;
                    }
                    total_amounttextBox.Text = totalAmount.ToString();
                }
                else if (view_categorycomboBox.Text == "Grocery")
                {
                    string search = infoList[0];
                    string gainword = view_categorycomboBox.Text;
                    //bool b=true;
                    ListViewItem myView = new ListViewItem(infoList[0]);
                    if (infoList[1].ToLower().Contains(gainword.ToLower()))
                    {
                        //showalllistView.Items.Add(aStudentDataRead[0]);
                        for (int i = 1; i < 3; i++)
                            myView.SubItems.Add(infoList[i]);
                        infolistView.Items.Add(myView);
                        salary = Convert.ToDouble(infoList[0]);
                        totalAmount += salary;
                    }
                    total_amounttextBox.Text = totalAmount.ToString();

                }
                else if (view_categorycomboBox.Text == "Misc")
                {
                    string search = infoList[0];
                    string gainword = view_categorycomboBox.Text;
                    //bool b=true;
                    ListViewItem myView = new ListViewItem(infoList[0]);
                    if (infoList[1].ToLower().Contains(gainword.ToLower()))
                    {
                        //showalllistView.Items.Add(aStudentDataRead[0]);
                        for (int i = 1; i < 3; i++)
                            myView.SubItems.Add(infoList[i]);
                        infolistView.Items.Add(myView);
                        salary = Convert.ToDouble(infoList[0]);
                        totalAmount += salary;
                    }
                    total_amounttextBox.Text = totalAmount.ToString();

                }

            }

            aStream.Close();
        }

        private void DailyExpenseUI_Load(object sender, EventArgs e)
                {
                    infolistView.Columns.Add(label4.Text);
                    infolistView.Columns.Add(label5.Text);
                    infolistView.Columns.Add(label6.Text);
                    //view_categorycomboBox.Text = view_categorycomboBox.Items[0].ToString();
                }

            }
        }
