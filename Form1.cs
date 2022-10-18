using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Employee> employees = new List<Employee>();
        List<Customer> customers = new List<Customer>();


        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(txt_id.Text);
            customer.FirstName = txt_name.Text;
            customer.LastName = txt_lastname.Text;
            customer.Address = txt_address.Text;
            customers.Add(customer);
            clearTxtBox();
        }
        public void clearTxtBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = " ";
            }
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(txt_id.Text);
            employee.FirstName = txt_name.Text;
            employee.LastName = txt_lastname.Text;
            employee.Address = txt_address.Text;
            employees.Add(employee);
            clearTxtBox();
        }

        private void btn_list_customer_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IPerson x in customers)
                listBox1.Items.Add(x.Id +" "+x.FirstName + " " + x.LastName+" "+ x.Address);
            comboBox1.Items.Clear();
            foreach (IPerson x in customers)
                comboBox1.Items.Add(x.Id);
        }

        private void btn_list_employee_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IPerson x in employees)
                listBox1.Items.Add(x.Id + " " + x.FirstName + " " + x.LastName + " " + x.Address);
        }


        private void btn_remove_customer_Click(object sender, EventArgs e)
        {
            customers.RemoveAll(x == x.Id == Convert.ToInt32(comboBox1.SelectedItem));


        }
    }
}
