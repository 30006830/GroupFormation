using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeBackEnd;

namespace EmployeeFrontEnd
{
    public partial class Form1 : Form
    {

        Employee e1 = new Employee();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAge_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelBankAccNo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBankAccNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIRDNo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIRDNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPayPerHr_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPayPerHr_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelHoursWorked_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHoursWorked_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length >1 )
            {
                if (textBoxAge.Text.Length >= 1 && int.TryParse(textBoxAge.Text, out int success1))
                {
                    if (textBoxBankAccNo.Text.Length >= 15)
                    {
                        if (textBoxIRDNo.Text.Length > 1)
                        {
                            if (textBoxPayPerHr.Text.Length > 1 && double.TryParse(textBoxPayPerHr.Text, out double success2))
                            {
                                if (textBoxHoursWorked.Text.Length > 1 && double.TryParse(textBoxHoursWorked.Text, out double success3))
                                {
                                    e1.Name = textBoxName.Text;
                                    e1.Age = int.Parse(textBoxAge.Text);
                                    e1.Bank = textBoxBankAccNo.Text;
                                    e1.IRD = textBoxIRDNo.Text;
                                    e1.Pay = double.Parse(textBoxPayPerHr.Text);
                                    e1.Hrs = double.Parse(textBoxHoursWorked.Text);
                                    labelDetails.Text = e1.EmployeeDetails();
                                    labelHoursWorked.Text = "Hours Worked:";
                                }
                                else
                                {
                                    labelHoursWorked.Text = "Hours Worked: *This Feild is reqired*";
                                    labelName.Text = "Name:";
                                    labelAge.Text = "Age:";
                                    labelBankAccNo.Text = "Bank Account No:";
                                    labelIRDNo.Text = "IRD No:";
                                    labelPayPerHr.Text = "Pay (Hr):";
                                }
                            }
                            else
                            {
                                labelPayPerHr.Text = "Pay (Hr): *This Feild is reqired*";
                                labelName.Text = "Name:";
                                labelAge.Text = "Age:";
                                labelBankAccNo.Text = "Bank Account No:";
                                labelIRDNo.Text = "IRD No:";
                            }
                        }
                        else
                        {
                            labelIRDNo.Text = "IRD No: *This Feild is reqired*";
                            labelName.Text = "Name:";
                            labelAge.Text = "Age:";
                            labelBankAccNo.Text = "Bank Account No:";
                        }
                        
                    }
                    else
                    {
                        labelBankAccNo.Text = "Bank Account No: *This Field is reqired*";
                        labelName.Text = "Name:";
                        labelAge.Text = "Age:";
                    }
                }
                else
                {
                    labelAge.Text = "Age: *This Field is reqired*";
                    labelName.Text = "Name:";
                }
            }
            else
            {
                labelName.Text = "Name: *This Field is reqired*";
            }   

        }

        private void listBoxDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
