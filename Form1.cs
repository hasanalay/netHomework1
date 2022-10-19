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
        private void listCustomers()
        {
            listBox1.Items.Clear();
            foreach (IPerson x in customers)
                listBox1.Items.Add(x.Id + " " + x.FirstName + " " + x.LastName + " " + x.Address);
            comboBox1.Items.Clear();
            foreach (IPerson x in customers)
                comboBox1.Items.Add(x.Id);
        }

        private void listEmployees()
        {
            listBox1.Items.Clear();
            foreach (IPerson x in employees)
                listBox1.Items.Add(x.Id + " " + x.FirstName + " " + x.LastName + " " + x.Address);
            comboBox2.Items.Clear();
            foreach (IPerson x in employees)
                comboBox2.Items.Add(x.Id);
        }

        private void btn_list_employee_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IPerson x in employees)
                listBox1.Items.Add(x.Id + " " + x.FirstName + " " + x.LastName + " " + x.Address);
            comboBox2.Items.Clear();
            foreach (IPerson x in employees)
                comboBox2.Items.Add(x.Id);
        }


        private void btn_remove_customer_Click(object sender, EventArgs e)
        {
            customers.Remove(customers[listBox1.SelectedIndex]);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            listCustomers();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Customer customer = customers[comboBox1.SelectedIndex];
            listBox1.Items.Add(Convert.ToString(customer.Id) + " " + customer.FirstName + " " + customer.LastName + " " + customer.Address);
        }

        private void btn_remove_employee_Click(object sender, EventArgs e)
        {
            employees.Remove(employees[listBox1.SelectedIndex]);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
            listEmployees();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Employee employee = employees[comboBox2.SelectedIndex];
            listBox1.Items.Add(Convert.ToString(employee.Id) + " " + employee.FirstName + " " + employee.LastName + " " + employee.Address);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
