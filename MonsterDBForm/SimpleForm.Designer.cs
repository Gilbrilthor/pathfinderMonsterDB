namespace MonsterDBForm
{
    partial class SimpleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.selectListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultsGridView);
            this.panel1.Location = new System.Drawing.Point(161, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 391);
            this.panel1.TabIndex = 0;
            // 
            // resultsGridView
            // 
            this.resultsGridView.AllowUserToAddRows = false;
            this.resultsGridView.AllowUserToDeleteRows = false;
            this.resultsGridView.AllowUserToOrderColumns = true;
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGridView.Location = new System.Drawing.Point(0, 0);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.ReadOnly = true;
            this.resultsGridView.Size = new System.Drawing.Size(775, 391);
            this.resultsGridView.TabIndex = 0;
            // 
            // selectListBox
            // 
            this.selectListBox.FormattingEnabled = true;
            this.selectListBox.Location = new System.Drawing.Point(13, 13);
            this.selectListBox.Name = "selectListBox";
            this.selectListBox.Size = new System.Drawing.Size(120, 238);
            this.selectListBox.TabIndex = 1;
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 578);
            this.Controls.Add(this.selectListBox);
            this.Controls.Add(this.panel1);
            this.Name = "SimpleForm";
            this.Text = "SimpleForm";
            this.Load += new System.EventHandler(this.SimpleForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.ListBox selectListBox;
    }
}