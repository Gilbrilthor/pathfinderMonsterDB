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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.where1Combo = new System.Windows.Forms.ComboBox();
            this.equality1Combo = new System.Windows.Forms.ComboBox();
            this.where1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.selectListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selectListBox.Size = new System.Drawing.Size(120, 381);
            this.selectListBox.TabIndex = 1;
            this.selectListBox.SelectedIndexChanged += new System.EventHandler(this.selectListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(861, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(765, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Execute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // where1Combo
            // 
            this.where1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.where1Combo.FormattingEnabled = true;
            this.where1Combo.Location = new System.Drawing.Point(6, 19);
            this.where1Combo.Name = "where1Combo";
            this.where1Combo.Size = new System.Drawing.Size(121, 21);
            this.where1Combo.TabIndex = 4;
            // 
            // equality1Combo
            // 
            this.equality1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equality1Combo.FormattingEnabled = true;
            this.equality1Combo.Items.AddRange(new object[] {
            "equals",
            "is like",
            "greater than",
            "less than"});
            this.equality1Combo.Location = new System.Drawing.Point(133, 19);
            this.equality1Combo.Name = "equality1Combo";
            this.equality1Combo.Size = new System.Drawing.Size(121, 21);
            this.equality1Combo.TabIndex = 5;
            // 
            // where1TextBox
            // 
            this.where1TextBox.Location = new System.Drawing.Point(260, 20);
            this.where1TextBox.Name = "where1TextBox";
            this.where1TextBox.Size = new System.Drawing.Size(414, 20);
            this.where1TextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.where1Combo);
            this.groupBox1.Controls.Add(this.where1TextBox);
            this.groupBox1.Controls.Add(this.equality1Combo);
            this.groupBox1.Location = new System.Drawing.Point(12, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narrow Your Results";
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectListBox);
            this.Controls.Add(this.panel1);
            this.Name = "SimpleForm";
            this.Text = "SimpleForm";
            this.Load += new System.EventHandler(this.SimpleForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.ListBox selectListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox where1Combo;
        private System.Windows.Forms.ComboBox equality1Combo;
        private System.Windows.Forms.TextBox where1TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}