namespace WindowsFormsApp_Temp
{
    partial class Form4
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
            this.stIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablescoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temp_dbDataSet = new WindowsFormsApp_Temp.Temp_dbDataSet();
            this.table_scoreTableAdapter = new WindowsFormsApp_Temp.Temp_dbDataSetTableAdapters.Table_scoreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablescoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stIDDataGridViewTextBoxColumn,
            this.stnameDataGridViewTextBoxColumn,
            this.subjectnameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablescoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(375, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // stIDDataGridViewTextBoxColumn
            // 
            this.stIDDataGridViewTextBoxColumn.DataPropertyName = "St_ID";
            this.stIDDataGridViewTextBoxColumn.HeaderText = "St_ID";
            this.stIDDataGridViewTextBoxColumn.Name = "stIDDataGridViewTextBoxColumn";
            this.stIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // stnameDataGridViewTextBoxColumn
            // 
            this.stnameDataGridViewTextBoxColumn.DataPropertyName = "St_name";
            this.stnameDataGridViewTextBoxColumn.HeaderText = "St_name";
            this.stnameDataGridViewTextBoxColumn.Name = "stnameDataGridViewTextBoxColumn";
            this.stnameDataGridViewTextBoxColumn.Width = 72;
            // 
            // subjectnameDataGridViewTextBoxColumn
            // 
            this.subjectnameDataGridViewTextBoxColumn.DataPropertyName = "Subject_name";
            this.subjectnameDataGridViewTextBoxColumn.HeaderText = "Subject_name";
            this.subjectnameDataGridViewTextBoxColumn.Name = "subjectnameDataGridViewTextBoxColumn";
            this.subjectnameDataGridViewTextBoxColumn.Width = 102;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.Width = 60;
            // 
            // tablescoreBindingSource
            // 
            this.tablescoreBindingSource.DataMember = "Table_score";
            this.tablescoreBindingSource.DataSource = this.tempdbDataSetBindingSource;
            // 
            // tempdbDataSetBindingSource
            // 
            this.tempdbDataSetBindingSource.DataSource = this.temp_dbDataSet;
            this.tempdbDataSetBindingSource.Position = 0;
            // 
            // temp_dbDataSet
            // 
            this.temp_dbDataSet.DataSetName = "Temp_dbDataSet";
            this.temp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_scoreTableAdapter
            // 
            this.table_scoreTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablescoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_dbDataSet)).EndInit();
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
    }
}