namespace homework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_remove_employee = new System.Windows.Forms.Button();
            this.btn_list_employee = new System.Windows.Forms.Button();
            this.btn_add_employee = new System.Windows.Forms.Button();
            this.btn_remove_customer = new System.Windows.Forms.Button();
            this.btn_list_customer = new System.Windows.Forms.Button();
            this.btn_add_customer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(89, 105);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(123, 20);
            this.txt_lastname.TabIndex = 3;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(89, 138);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(123, 20);
            this.txt_address.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(89, 72);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(123, 20);
            this.txt_name.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(89, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 20);
            this.txt_id.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(245, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 82);
            this.listBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(494, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_remove_employee
            // 
            this.btn_remove_employee.Location = new System.Drawing.Point(501, 172);
            this.btn_remove_employee.Name = "btn_remove_employee";
            this.btn_remove_employee.Size = new System.Drawing.Size(115, 31);
            this.btn_remove_employee.TabIndex = 10;
            this.btn_remove_employee.Text = "Remove Employee";
            this.btn_remove_employee.UseVisualStyleBackColor = true;
            this.btn_remove_employee.Click += new System.EventHandler(this.btn_remove_employee_Click);
            // 
            // btn_list_employee
            // 
            this.btn_list_employee.Location = new System.Drawing.Point(115, 206);
            this.btn_list_employee.Name = "btn_list_employee";
            this.btn_list_employee.Size = new System.Drawing.Size(97, 31);
            this.btn_list_employee.TabIndex = 8;
            this.btn_list_employee.Text = "List Employee";
            this.btn_list_employee.UseVisualStyleBackColor = true;
            this.btn_list_employee.Click += new System.EventHandler(this.btn_list_employee_Click);
            // 
            // btn_add_employee
            // 
            this.btn_add_employee.Location = new System.Drawing.Point(14, 206);
            this.btn_add_employee.Name = "btn_add_employee";
            this.btn_add_employee.Size = new System.Drawing.Size(97, 31);
            this.btn_add_employee.TabIndex = 6;
            this.btn_add_employee.Text = "Add Employee";
            this.btn_add_employee.UseVisualStyleBackColor = true;
            this.btn_add_employee.Click += new System.EventHandler(this.btn_add_employee_Click);
            // 
            // btn_remove_customer
            // 
            this.btn_remove_customer.Location = new System.Drawing.Point(245, 172);
            this.btn_remove_customer.Name = "btn_remove_customer";
            this.btn_remove_customer.Size = new System.Drawing.Size(115, 31);
            this.btn_remove_customer.TabIndex = 9;
            this.btn_remove_customer.Text = "Remove Customer";
            this.btn_remove_customer.UseVisualStyleBackColor = true;
            this.btn_remove_customer.Click += new System.EventHandler(this.btn_remove_customer_Click);
            // 
            // btn_list_customer
            // 
            this.btn_list_customer.Location = new System.Drawing.Point(115, 172);
            this.btn_list_customer.Name = "btn_list_customer";
            this.btn_list_customer.Size = new System.Drawing.Size(97, 31);
            this.btn_list_customer.TabIndex = 7;
            this.btn_list_customer.Text = "List Customer";
            this.btn_list_customer.UseVisualStyleBackColor = true;
            this.btn_list_customer.Click += new System.EventHandler(this.btn_list_customer_Click);
            // 
            // btn_add_customer
            // 
            this.btn_add_customer.Location = new System.Drawing.Point(14, 172);
            this.btn_add_customer.Name = "btn_add_customer";
            this.btn_add_customer.Size = new System.Drawing.Size(97, 31);
            this.btn_add_customer.TabIndex = 5;
            this.btn_add_customer.Text = "Add Customer";
            this.btn_add_customer.UseVisualStyleBackColor = true;
            this.btn_add_customer.Click += new System.EventHandler(this.btn_add_customer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Emp. Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cust ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 285);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_remove_employee);
            this.Controls.Add(this.btn_list_employee);
            this.Controls.Add(this.btn_add_employee);
            this.Controls.Add(this.btn_remove_customer);
            this.Controls.Add(this.btn_list_customer);
            this.Controls.Add(this.btn_add_customer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_remove_employee;
        private System.Windows.Forms.Button btn_list_employee;
        private System.Windows.Forms.Button btn_add_employee;
        private System.Windows.Forms.Button btn_remove_customer;
        private System.Windows.Forms.Button btn_list_customer;
        private System.Windows.Forms.Button btn_add_customer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

