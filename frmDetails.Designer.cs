namespace yazilim_Yapimi
{
    partial class frmDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetails));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yazilim_YapimiDataSet = new yazilim_Yapimi.yazilim_YapimiDataSet();
            this.tblEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EventTableAdapter = new yazilim_Yapimi.yazilim_YapimiDataSetTableAdapters.tbl_EventTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_YapimiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 24);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 429);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.eventDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEventBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // yazilim_YapimiDataSet
            // 
            this.yazilim_YapimiDataSet.DataSetName = "yazilim_YapimiDataSet";
            this.yazilim_YapimiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEventBindingSource
            // 
            this.tblEventBindingSource.DataMember = "tbl_Event";
            this.tblEventBindingSource.DataSource = this.yazilim_YapimiDataSet;
            // 
            // tbl_EventTableAdapter
            // 
            this.tbl_EventTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // eventDataGridViewTextBoxColumn
            // 
            this.eventDataGridViewTextBoxColumn.DataPropertyName = "Event";
            this.eventDataGridViewTextBoxColumn.HeaderText = "Event";
            this.eventDataGridViewTextBoxColumn.Name = "eventDataGridViewTextBoxColumn";
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(471, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmDetails";
            this.Text = "frmDetails";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_YapimiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yazilim_YapimiDataSet yazilim_YapimiDataSet;
        private System.Windows.Forms.BindingSource tblEventBindingSource;
        private yazilim_YapimiDataSetTableAdapters.tbl_EventTableAdapter tbl_EventTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn;
    }
}