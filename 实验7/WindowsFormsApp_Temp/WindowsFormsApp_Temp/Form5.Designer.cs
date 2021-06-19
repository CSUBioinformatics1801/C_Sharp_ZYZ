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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.temp_dbDataSet = new WindowsFormsApp_Temp.Temp_dbDataSet();
            this.tempdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablescoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_scoreTableAdapter = new WindowsFormsApp_Temp.Temp_dbDataSetTableAdapters.Table_scoreTableAdapter();
            this.stIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id_search = new System.Windows.Forms.TextBox();
            this.label_sub = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_column = new System.Windows.Forms.ComboBox();
            this.radioButton_ASC = new System.Windows.Forms.RadioButton();
            this.radioButton_DESC = new System.Windows.Forms.RadioButton();
            this.button_sort = new System.Windows.Forms.Button();
            this.comboBox_sub = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablescoreBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stIDDataGridViewTextBoxColumn,
            this.stnameDataGridViewTextBoxColumn,
            this.subjectnameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablescoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(528, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // temp_dbDataSet
            // 
            this.temp_dbDataSet.DataSetName = "Temp_dbDataSet";
            this.temp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tempdbDataSetBindingSource
            // 
            this.tempdbDataSetBindingSource.DataSource = this.temp_dbDataSet;
            this.tempdbDataSetBindingSource.Position = 0;
            // 
            // tablescoreBindingSource
            // 
            this.tablescoreBindingSource.DataMember = "Table_score";
            this.tablescoreBindingSource.DataSource = this.tempdbDataSetBindingSource;
            // 
            // table_scoreTableAdapter
            // 
            this.table_scoreTableAdapter.ClearBeforeFill = true;
            // 
            // stIDDataGridViewTextBoxColumn
            // 
            this.stIDDataGridViewTextBoxColumn.DataPropertyName = "St_ID";
            this.stIDDataGridViewTextBoxColumn.HeaderText = "St_ID";
            this.stIDDataGridViewTextBoxColumn.Name = "stIDDataGridViewTextBoxColumn";
            // 
            // stnameDataGridViewTextBoxColumn
            // 
            this.stnameDataGridViewTextBoxColumn.DataPropertyName = "St_name";
            this.stnameDataGridViewTextBoxColumn.HeaderText = "St_name";
            this.stnameDataGridViewTextBoxColumn.Name = "stnameDataGridViewTextBoxColumn";
            // 
            // subjectnameDataGridViewTextBoxColumn
            // 
            this.subjectnameDataGridViewTextBoxColumn.DataPropertyName = "Subject_name";
            this.subjectnameDataGridViewTextBoxColumn.HeaderText = "Subject_name";
            this.subjectnameDataGridViewTextBoxColumn.Name = "subjectnameDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_sub);
            this.groupBox1.Controls.Add(this.button_reset);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.label_sub);
            this.groupBox1.Controls.Add(this.textBox_id_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "St_ID";
            // 
            // textBox_id_search
            // 
            this.textBox_id_search.Location = new System.Drawing.Point(68, 24);
            this.textBox_id_search.Name = "textBox_id_search";
            this.textBox_id_search.Size = new System.Drawing.Size(100, 22);
            this.textBox_id_search.TabIndex = 1;
            // 
            // label_sub
            // 
            this.label_sub.AutoSize = true;
            this.label_sub.Location = new System.Drawing.Point(7, 79);
            this.label_sub.Name = "label_sub";
            this.label_sub.Size = new System.Drawing.Size(46, 14);
            this.label_sub.TabIndex = 2;
            this.label_sub.Text = "Subject";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(10, 150);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search Now";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(117, 150);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.button_sort);
            this.groupbox2.Controls.Add(this.radioButton_DESC);
            this.groupbox2.Controls.Add(this.radioButton_ASC);
            this.groupbox2.Controls.Add(this.comboBox_column);
            this.groupbox2.Location = new System.Drawing.Point(303, 408);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(257, 182);
            this.groupbox2.TabIndex = 2;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Sort";
            // 
            // comboBox_column
            // 
            this.comboBox_column.FormattingEnabled = true;
            this.comboBox_column.Location = new System.Drawing.Point(59, 43);
            this.comboBox_column.Name = "comboBox_column";
            this.comboBox_column.Size = new System.Drawing.Size(121, 22);
            this.comboBox_column.TabIndex = 0;
            // 
            // radioButton_ASC
            // 
            this.radioButton_ASC.AutoSize = true;
            this.radioButton_ASC.Location = new System.Drawing.Point(32, 104);
            this.radioButton_ASC.Name = "radioButton_ASC";
            this.radioButton_ASC.Size = new System.Drawing.Size(81, 18);
            this.radioButton_ASC.TabIndex = 1;
            this.radioButton_ASC.TabStop = true;
            this.radioButton_ASC.Text = "Ascending";
            this.radioButton_ASC.UseVisualStyleBackColor = true;
            // 
            // radioButton_DESC
            // 
            this.radioButton_DESC.AutoSize = true;
            this.radioButton_DESC.Location = new System.Drawing.Point(139, 105);
            this.radioButton_DESC.Name = "radioButton_DESC";
            this.radioButton_DESC.Size = new System.Drawing.Size(89, 18);
            this.radioButton_DESC.TabIndex = 2;
            this.radioButton_DESC.TabStop = true;
            this.radioButton_DESC.Text = "Descending";
            this.radioButton_DESC.UseVisualStyleBackColor = true;
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(89, 150);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(75, 23);
            this.button_sort.TabIndex = 3;
            this.button_sort.Text = "Sort Now";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // comboBox_sub
            // 
            this.comboBox_sub.FormattingEnabled = true;
            this.comboBox_sub.Location = new System.Drawing.Point(68, 79);
            this.comboBox_sub.Name = "comboBox_sub";
            this.comboBox_sub.Size = new System.Drawing.Size(121, 22);
            this.comboBox_sub.TabIndex = 6;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 623);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablescoreBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tempdbDataSetBindingSource;
        private Temp_dbDataSet temp_dbDataSet;
        private System.Windows.Forms.BindingSource tablescoreBindingSource;
        private Temp_dbDataSetTableAdapters.Table_scoreTableAdapter table_scoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_sub;
        private System.Windows.Forms.TextBox textBox_id_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.RadioButton radioButton_DESC;
        private System.Windows.Forms.RadioButton radioButton_ASC;
        private System.Windows.Forms.ComboBox comboBox_column;
        private System.Windows.Forms.ComboBox comboBox_sub;
    }
}