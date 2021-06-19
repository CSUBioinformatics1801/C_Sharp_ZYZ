namespace WindowsFormsApp_Temp
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.temp_dbDataSet = new WindowsFormsApp_Temp.Temp_dbDataSet();
            this.tempdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablescoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_scoreTableAdapter = new WindowsFormsApp_Temp.Temp_dbDataSetTableAdapters.Table_scoreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.temp_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablescoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(35, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(618, 328);
            this.listBox1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temp_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablescoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource tempdbDataSetBindingSource;
        private Temp_dbDataSet temp_dbDataSet;
        private System.Windows.Forms.BindingSource tablescoreBindingSource;
        private Temp_dbDataSetTableAdapters.Table_scoreTableAdapter table_scoreTableAdapter;
    }
}