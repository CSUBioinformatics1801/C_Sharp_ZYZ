namespace WindowsFormsApp_Temp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_end = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_fore = new System.Windows.Forms.Button();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.tablescoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temp_dbDataSet = new WindowsFormsApp_Temp.Temp_dbDataSet();
            this.textBox_sub = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sub = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.table_scoreTableAdapter = new WindowsFormsApp_Temp.Temp_dbDataSetTableAdapters.Table_scoreTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablescoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_end);
            this.groupBox1.Controls.Add(this.button_home);
            this.groupBox1.Controls.Add(this.button_next);
            this.groupBox1.Controls.Add(this.button_fore);
            this.groupBox1.Controls.Add(this.textBox_Score);
            this.groupBox1.Controls.Add(this.textBox_sub);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.textBox_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_sub);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Controls.Add(this.label_ID);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score Browser";
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(384, 243);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(40, 23);
            this.button_end.TabIndex = 11;
            this.button_end.Text = "-->|";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(90, 243);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(40, 23);
            this.button_home.TabIndex = 10;
            this.button_home.Text = "|<--";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(319, 245);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(40, 23);
            this.button_next.TabIndex = 9;
            this.button_next.Text = "->";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_fore
            // 
            this.button_fore.Location = new System.Drawing.Point(145, 245);
            this.button_fore.Name = "button_fore";
            this.button_fore.Size = new System.Drawing.Size(40, 23);
            this.button_fore.TabIndex = 8;
            this.button_fore.Text = "<-";
            this.button_fore.UseVisualStyleBackColor = true;
            this.button_fore.Click += new System.EventHandler(this.button_fore_Click);
            // 
            // textBox_Score
            // 
            this.textBox_Score.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablescoreBindingSource, "Score", true));
            this.textBox_Score.Location = new System.Drawing.Point(170, 113);
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(100, 21);
            this.textBox_Score.TabIndex = 7;
            // 
            // tablescoreBindingSource
            // 
            this.tablescoreBindingSource.DataMember = "Table_score";
            this.tablescoreBindingSource.DataSource = this.temp_dbDataSet;
            // 
            // temp_dbDataSet
            // 
            this.temp_dbDataSet.DataSetName = "Temp_dbDataSet";
            this.temp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_sub
            // 
            this.textBox_sub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablescoreBindingSource, "Subject_name", true));
            this.textBox_sub.Location = new System.Drawing.Point(170, 64);
            this.textBox_sub.Name = "textBox_sub";
            this.textBox_sub.Size = new System.Drawing.Size(100, 21);
            this.textBox_sub.TabIndex = 6;
            // 
            // textBox_name
            // 
            this.textBox_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablescoreBindingSource, "St_name", true));
            this.textBox_name.Location = new System.Drawing.Point(170, 27);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_ID
            // 
            this.textBox_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablescoreBindingSource, "St_ID", true));
            this.textBox_ID.Location = new System.Drawing.Point(200, 245);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 21);
            this.textBox_ID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // label_sub
            // 
            this.label_sub.AutoSize = true;
            this.label_sub.Location = new System.Drawing.Point(35, 74);
            this.label_sub.Name = "label_sub";
            this.label_sub.Size = new System.Drawing.Size(47, 12);
            this.label_sub.TabIndex = 2;
            this.label_sub.Text = "Subject";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(35, 37);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(77, 12);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Student Name";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(214, 269);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(65, 12);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "Student ID";
            // 
            // table_scoreTableAdapter
            // 
            this.table_scoreTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 366);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablescoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_sub;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.TextBox textBox_sub;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_ID;
        private Temp_dbDataSet temp_dbDataSet;
        private System.Windows.Forms.BindingSource tablescoreBindingSource;
        private Temp_dbDataSetTableAdapters.Table_scoreTableAdapter table_scoreTableAdapter;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_fore;
    }
}