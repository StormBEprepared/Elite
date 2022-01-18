namespace Elite
{
    partial class Journal
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.journalLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eliteDBDataSet3 = new Elite.EliteDBDataSet3();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.journalLocationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eliteDBDataSet2 = new Elite.EliteDBDataSet2();
            this.eliteDBDataSet1 = new Elite.EliteDBDataSet1();
            this.journalLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journal_LocationTableAdapter = new Elite.EliteDBDataSet1TableAdapters.Journal_LocationTableAdapter();
            this.journalLocationTableAdapter = new Elite.EliteDBDataSet2TableAdapters.JournalLocationTableAdapter();
            this.journalLocationsTableAdapter = new Elite.EliteDBDataSet3TableAdapters.JournalLocationsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalLocationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalLocationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalLocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(1133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Journal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 800);
            this.panel1.TabIndex = 1;
            // 
            // journalLocationsBindingSource
            // 
            this.journalLocationsBindingSource.DataMember = "JournalLocations";
            this.journalLocationsBindingSource.DataSource = this.eliteDBDataSet3;
            // 
            // eliteDBDataSet3
            // 
            this.eliteDBDataSet3.DataSetName = "EliteDBDataSet3";
            this.eliteDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.button2.Location = new System.Drawing.Point(489, 739);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.button1.Location = new System.Drawing.Point(606, 739);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1228, 718);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // journalLocationBindingSource1
            // 
            this.journalLocationBindingSource1.DataMember = "JournalLocation";
            this.journalLocationBindingSource1.DataSource = this.eliteDBDataSet2;
            // 
            // eliteDBDataSet2
            // 
            this.eliteDBDataSet2.DataSetName = "EliteDBDataSet2";
            this.eliteDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eliteDBDataSet1
            // 
            this.eliteDBDataSet1.DataSetName = "EliteDBDataSet1";
            this.eliteDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalLocationBindingSource
            // 
            this.journalLocationBindingSource.DataMember = "Journal Location";
            this.journalLocationBindingSource.DataSource = this.eliteDBDataSet1;
            // 
            // journal_LocationTableAdapter
            // 
            this.journal_LocationTableAdapter.ClearBeforeFill = true;
            // 
            // journalLocationTableAdapter
            // 
            this.journalLocationTableAdapter.ClearBeforeFill = true;
            // 
            // journalLocationsTableAdapter
            // 
            this.journalLocationsTableAdapter.ClearBeforeFill = true;
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1284, 877);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1284, 877);
            this.Name = "Journal";
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.Journal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.journalLocationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalLocationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliteDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalLocationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private EliteDBDataSet1 eliteDBDataSet1;
        private System.Windows.Forms.BindingSource journalLocationBindingSource;
        private EliteDBDataSet1TableAdapters.Journal_LocationTableAdapter journal_LocationTableAdapter;
        private System.Windows.Forms.Button button2;
        private EliteDBDataSet2 eliteDBDataSet2;
        private System.Windows.Forms.BindingSource journalLocationBindingSource1;
        private EliteDBDataSet2TableAdapters.JournalLocationTableAdapter journalLocationTableAdapter;
        private EliteDBDataSet3 eliteDBDataSet3;
        private System.Windows.Forms.BindingSource journalLocationsBindingSource;
        private EliteDBDataSet3TableAdapters.JournalLocationsTableAdapter journalLocationsTableAdapter;
    }
}