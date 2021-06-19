namespace WindowsFormsApp_Temp
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_birthdate = new System.Windows.Forms.TextBox();
            this.label_birthdate = new System.Windows.Forms.Label();
            this.textBox_class = new System.Windows.Forms.TextBox();
            this.textBox_sex = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Class = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Sex = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(61, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(285, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_birthdate);
            this.groupBox2.Controls.Add(this.label_birthdate);
            this.groupBox2.Controls.Add(this.textBox_class);
            this.groupBox2.Controls.Add(this.textBox_sex);
            this.groupBox2.Controls.Add(this.textBox_Name);
            this.groupBox2.Controls.Add(this.textBox_ID);
            this.groupBox2.Controls.Add(this.label_Class);
            this.groupBox2.Controls.Add(this.label_Name);
            this.groupBox2.Controls.Add(this.label_Sex);
            this.groupBox2.Controls.Add(this.label_ID);
            this.groupBox2.Location = new System.Drawing.Point(379, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(504, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // textBox_birthdate
            // 
            this.textBox_birthdate.Location = new System.Drawing.Point(132, 212);
            this.textBox_birthdate.Name = "textBox_birthdate";
            this.textBox_birthdate.ReadOnly = true;
            this.textBox_birthdate.Size = new System.Drawing.Size(168, 27);
            this.textBox_birthdate.TabIndex = 9;
            // 
            // label_birthdate
            // 
            this.label_birthdate.AutoSize = true;
            this.label_birthdate.Location = new System.Drawing.Point(42, 220);
            this.label_birthdate.Name = "label_birthdate";
            this.label_birthdate.Size = new System.Drawing.Size(75, 19);
            this.label_birthdate.TabIndex = 8;
            this.label_birthdate.Text = "Birth Date";
            // 
            // textBox_class
            // 
            this.textBox_class.Location = new System.Drawing.Point(352, 139);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.ReadOnly = true;
            this.textBox_class.Size = new System.Drawing.Size(100, 27);
            this.textBox_class.TabIndex = 7;
            // 
            // textBox_sex
            // 
            this.textBox_sex.Location = new System.Drawing.Point(121, 136);
            this.textBox_sex.Name = "textBox_sex";
            this.textBox_sex.ReadOnly = true;
            this.textBox_sex.Size = new System.Drawing.Size(100, 27);
            this.textBox_sex.TabIndex = 6;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(352, 38);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(100, 27);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(121, 38);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(100, 27);
            this.textBox_ID.TabIndex = 4;
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Location = new System.Drawing.Point(293, 144);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(44, 19);
            this.label_Class.TabIndex = 3;
            this.label_Class.Text = "Class";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(290, 38);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(47, 19);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Name";
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Location = new System.Drawing.Point(42, 139);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(56, 19);
            this.label_Sex.TabIndex = 1;
            this.label_Sex.Text = "Gender";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(38, 38);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(76, 19);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "Student ID";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_birthdate;
        private System.Windows.Forms.Label label_birthdate;
        private System.Windows.Forms.TextBox textBox_class;
        private System.Windows.Forms.TextBox textBox_sex;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Class;
        private System.Windows.Forms.Label label_Name;
    }
}