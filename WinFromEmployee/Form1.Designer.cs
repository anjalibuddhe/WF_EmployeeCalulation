namespace WinFromEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.Emp_name1 = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.Label();
            this.empdept = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.Cal_salary = new System.Windows.Forms.Label();
            this.Cal_Hra = new System.Windows.Forms.Label();
            this.Cal_Ta = new System.Windows.Forms.Label();
            this.Cal_basic = new System.Windows.Forms.Label();
            this.Emp_name = new System.Windows.Forms.TextBox();
            this.Emp_id = new System.Windows.Forms.TextBox();
            this.Emp_Company = new System.Windows.Forms.TextBox();
            this.Loation = new System.Windows.Forms.TextBox();
            this.Emp_Salary = new System.Windows.Forms.TextBox();
            this.Emp_HRA = new System.Windows.Forms.TextBox();
            this.Emp_TA = new System.Windows.Forms.TextBox();
            this.Emp_Basic = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Calda = new System.Windows.Forms.Label();
            this.gross_sal = new System.Windows.Forms.Label();
            this.cal_Da = new System.Windows.Forms.TextBox();
            this.cal_gs = new System.Windows.Forms.TextBox();
            this.Dep_list = new System.Windows.Forms.ComboBox();
            this.Showdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            // 
            // Emp_name1
            // 
            this.Emp_name1.AutoSize = true;
            this.Emp_name1.Location = new System.Drawing.Point(32, 64);
            this.Emp_name1.Name = "Emp_name1";
            this.Emp_name1.Size = new System.Drawing.Size(84, 13);
            this.Emp_name1.TabIndex = 1;
            this.Emp_name1.Text = "Employee Name";
            // 
            // empid
            // 
            this.empid.AutoSize = true;
            this.empid.Location = new System.Drawing.Point(32, 108);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(65, 13);
            this.empid.TabIndex = 2;
            this.empid.Text = "Employee Id";
            // 
            // empdept
            // 
            this.empdept.AutoSize = true;
            this.empdept.Location = new System.Drawing.Point(32, 153);
            this.empdept.Name = "empdept";
            this.empdept.Size = new System.Drawing.Size(108, 13);
            this.empdept.TabIndex = 3;
            this.empdept.Text = "Employee Deparment";
            this.empdept.Click += new System.EventHandler(this.label4_Click);
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Location = new System.Drawing.Point(32, 200);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(51, 13);
            this.company.TabIndex = 4;
            this.company.Text = "Company";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(32, 241);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(48, 13);
            this.location.TabIndex = 5;
            this.location.Text = "Location";
            // 
            // Cal_salary
            // 
            this.Cal_salary.AutoSize = true;
            this.Cal_salary.Location = new System.Drawing.Point(383, 64);
            this.Cal_salary.Name = "Cal_salary";
            this.Cal_salary.Size = new System.Drawing.Size(20, 13);
            this.Cal_salary.TabIndex = 6;
            this.Cal_salary.Text = "PF";
            // 
            // Cal_Hra
            // 
            this.Cal_Hra.AutoSize = true;
            this.Cal_Hra.Location = new System.Drawing.Point(383, 94);
            this.Cal_Hra.Name = "Cal_Hra";
            this.Cal_Hra.Size = new System.Drawing.Size(30, 13);
            this.Cal_Hra.TabIndex = 7;
            this.Cal_Hra.Text = "HRA";
            // 
            // Cal_Ta
            // 
            this.Cal_Ta.AutoSize = true;
            this.Cal_Ta.Location = new System.Drawing.Point(391, 126);
            this.Cal_Ta.Name = "Cal_Ta";
            this.Cal_Ta.Size = new System.Drawing.Size(21, 13);
            this.Cal_Ta.TabIndex = 8;
            this.Cal_Ta.Text = "TA";
            // 
            // Cal_basic
            // 
            this.Cal_basic.AutoSize = true;
            this.Cal_basic.Location = new System.Drawing.Point(383, 210);
            this.Cal_basic.Name = "Cal_basic";
            this.Cal_basic.Size = new System.Drawing.Size(59, 13);
            this.Cal_basic.TabIndex = 9;
            this.Cal_basic.Text = "Basics_Sal";
            this.Cal_basic.Click += new System.EventHandler(this.label10_Click);
            // 
            // Emp_name
            // 
            this.Emp_name.Location = new System.Drawing.Point(152, 64);
            this.Emp_name.Name = "Emp_name";
            this.Emp_name.Size = new System.Drawing.Size(100, 20);
            this.Emp_name.TabIndex = 10;
            // 
            // Emp_id
            // 
            this.Emp_id.Location = new System.Drawing.Point(152, 108);
            this.Emp_id.Name = "Emp_id";
            this.Emp_id.Size = new System.Drawing.Size(100, 20);
            this.Emp_id.TabIndex = 11;
            // 
            // Emp_Company
            // 
            this.Emp_Company.Location = new System.Drawing.Point(152, 200);
            this.Emp_Company.Name = "Emp_Company";
            this.Emp_Company.Size = new System.Drawing.Size(100, 20);
            this.Emp_Company.TabIndex = 13;
            // 
            // Loation
            // 
            this.Loation.Location = new System.Drawing.Point(152, 241);
            this.Loation.Name = "Loation";
            this.Loation.Size = new System.Drawing.Size(100, 20);
            this.Loation.TabIndex = 14;
            // 
            // Emp_Salary
            // 
            this.Emp_Salary.Enabled = false;
            this.Emp_Salary.Location = new System.Drawing.Point(470, 61);
            this.Emp_Salary.Name = "Emp_Salary";
            this.Emp_Salary.Size = new System.Drawing.Size(100, 20);
            this.Emp_Salary.TabIndex = 15;
            // 
            // Emp_HRA
            // 
            this.Emp_HRA.Enabled = false;
            this.Emp_HRA.Location = new System.Drawing.Point(470, 87);
            this.Emp_HRA.Name = "Emp_HRA";
            this.Emp_HRA.Size = new System.Drawing.Size(100, 20);
            this.Emp_HRA.TabIndex = 16;
            // 
            // Emp_TA
            // 
            this.Emp_TA.Enabled = false;
            this.Emp_TA.Location = new System.Drawing.Point(470, 126);
            this.Emp_TA.Name = "Emp_TA";
            this.Emp_TA.Size = new System.Drawing.Size(100, 20);
            this.Emp_TA.TabIndex = 17;
            // 
            // Emp_Basic
            // 
            this.Emp_Basic.Location = new System.Drawing.Point(470, 203);
            this.Emp_Basic.Name = "Emp_Basic";
            this.Emp_Basic.Size = new System.Drawing.Size(100, 20);
            this.Emp_Basic.TabIndex = 18;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(344, 241);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(158, 34);
            this.Calculate.TabIndex = 19;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Calda
            // 
            this.Calda.AutoSize = true;
            this.Calda.Location = new System.Drawing.Point(391, 160);
            this.Calda.Name = "Calda";
            this.Calda.Size = new System.Drawing.Size(22, 13);
            this.Calda.TabIndex = 20;
            this.Calda.Text = "DA";
            // 
            // gross_sal
            // 
            this.gross_sal.AutoSize = true;
            this.gross_sal.Location = new System.Drawing.Point(381, 181);
            this.gross_sal.Name = "gross_sal";
            this.gross_sal.Size = new System.Drawing.Size(61, 13);
            this.gross_sal.TabIndex = 21;
            this.gross_sal.Text = "Grosssalary";
            // 
            // cal_Da
            // 
            this.cal_Da.Enabled = false;
            this.cal_Da.Location = new System.Drawing.Point(470, 153);
            this.cal_Da.Name = "cal_Da";
            this.cal_Da.Size = new System.Drawing.Size(100, 20);
            this.cal_Da.TabIndex = 22;
            // 
            // cal_gs
            // 
            this.cal_gs.Enabled = false;
            this.cal_gs.Location = new System.Drawing.Point(470, 174);
            this.cal_gs.Name = "cal_gs";
            this.cal_gs.Size = new System.Drawing.Size(100, 20);
            this.cal_gs.TabIndex = 23;
            // 
            // Dep_list
            // 
            this.Dep_list.FormattingEnabled = true;
            this.Dep_list.Items.AddRange(new object[] {
            "HR",
            "Sales",
            "Admin",
            "development",
            "testing"});
            this.Dep_list.Location = new System.Drawing.Point(146, 145);
            this.Dep_list.Name = "Dep_list";
            this.Dep_list.Size = new System.Drawing.Size(121, 21);
            this.Dep_list.TabIndex = 24;
            this.Dep_list.SelectedIndexChanged += new System.EventHandler(this.Dep_list_SelectedIndexChanged);
            // 
            // Showdata
            // 
            this.Showdata.Location = new System.Drawing.Point(528, 247);
            this.Showdata.Name = "Showdata";
            this.Showdata.Size = new System.Drawing.Size(75, 23);
            this.Showdata.TabIndex = 25;
            this.Showdata.Text = "Show";
            this.Showdata.UseVisualStyleBackColor = true;
            this.Showdata.Click += new System.EventHandler(this.Showdata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Showdata);
            this.Controls.Add(this.Dep_list);
            this.Controls.Add(this.cal_gs);
            this.Controls.Add(this.cal_Da);
            this.Controls.Add(this.gross_sal);
            this.Controls.Add(this.Calda);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Emp_Basic);
            this.Controls.Add(this.Emp_TA);
            this.Controls.Add(this.Emp_HRA);
            this.Controls.Add(this.Emp_Salary);
            this.Controls.Add(this.Loation);
            this.Controls.Add(this.Emp_Company);
            this.Controls.Add(this.Emp_id);
            this.Controls.Add(this.Emp_name);
            this.Controls.Add(this.Cal_basic);
            this.Controls.Add(this.Cal_Ta);
            this.Controls.Add(this.Cal_Hra);
            this.Controls.Add(this.Cal_salary);
            this.Controls.Add(this.location);
            this.Controls.Add(this.company);
            this.Controls.Add(this.empdept);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.Emp_name1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Emp_name1;
        private System.Windows.Forms.Label empid;
        private System.Windows.Forms.Label empdept;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label Cal_salary;
        private System.Windows.Forms.Label Cal_Hra;
        private System.Windows.Forms.Label Cal_Ta;
        private System.Windows.Forms.Label Cal_basic;
        private System.Windows.Forms.TextBox Emp_name;
        private System.Windows.Forms.TextBox Emp_id;
        private System.Windows.Forms.TextBox Emp_Company;
        private System.Windows.Forms.TextBox Loation;
        private System.Windows.Forms.TextBox Emp_Salary;
        private System.Windows.Forms.TextBox Emp_HRA;
        private System.Windows.Forms.TextBox Emp_TA;
        private System.Windows.Forms.TextBox Emp_Basic;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Calda;
        private System.Windows.Forms.Label gross_sal;
        private System.Windows.Forms.TextBox cal_Da;
        private System.Windows.Forms.TextBox cal_gs;
        private System.Windows.Forms.ComboBox Dep_list;
        private System.Windows.Forms.Button Showdata;
    }
}

