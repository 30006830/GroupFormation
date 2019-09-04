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
            e1.Name = textBoxName.Text;
            e1.Age = int.Parse(textBoxAge.Text);
            e1.Bank = textBoxBankAccNo.Text;
            e1.IRD = int.Parse(textBoxIRDNo.Text);
            e1.Pay = double.Parse(textBoxPayPerHr.Text);
            e1.Hrs = double.Parse(textBoxHoursWorked.Text);
            label1.Text = e1.EmployeeDetails();

        }

        private void listBoxDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
