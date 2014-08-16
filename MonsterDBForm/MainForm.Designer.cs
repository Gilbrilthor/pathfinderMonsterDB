namespace MonsterDBForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBlockViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.monstersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PathfinderDBParser_MonsterContextDataSet = new MonsterDBForm._PathfinderDBParser_MonsterContextDataSet();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.monstersTableAdapter = new MonsterDBForm._PathfinderDBParser_MonsterContextDataSetTableAdapters.MonstersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monstersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PathfinderDBParser_MonsterContextDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.importToolStripMenuItem,
            this.openBlockViewerToolStripMenuItem,
            this.exportToCSVToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.AutoToolTip = true;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.ToolTipText = "Open an existing database for querying.";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.AutoToolTip = true;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.importToolStripMenuItem.Text = "Create Database...";
            this.importToolStripMenuItem.ToolTipText = "Import a .csv file for saving to a database. Must save after to allow queries.";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.createDatabaseToolStripMenuItem_Click);
            // 
            // openBlockViewerToolStripMenuItem
            // 
            this.openBlockViewerToolStripMenuItem.Enabled = false;
            this.openBlockViewerToolStripMenuItem.Name = "openBlockViewerToolStripMenuItem";
            this.openBlockViewerToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.openBlockViewerToolStripMenuItem.Text = "Open Block Viewer";
            this.openBlockViewerToolStripMenuItem.Click += new System.EventHandler(this.openBlockViewerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            this.resultsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsGridView.Size = new System.Drawing.Size(976, 349);
            this.resultsGridView.TabIndex = 1;
            this.resultsGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // monstersBindingSource
            // 
            this.monstersBindingSource.DataMember = "Monsters";
            this.monstersBindingSource.DataSource = this._PathfinderDBParser_MonsterContextDataSet;
            // 
            // _PathfinderDBParser_MonsterContextDataSet
            // 
            this._PathfinderDBParser_MonsterContextDataSet.DataSetName = "_PathfinderDBParser_MonsterContextDataSet";
            this._PathfinderDBParser_MonsterContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queryTextBox
            // 
            this.queryTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.queryTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.queryTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryTextBox.Location = new System.Drawing.Point(0, 373);
            this.queryTextBox.Multiline = true;
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(1116, 71);
            this.queryTextBox.TabIndex = 2;
            this.queryTextBox.Text = "Select * from Monsters";
            this.queryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // queryButton
            // 
            this.queryButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.queryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryButton.Location = new System.Drawing.Point(976, 24);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(140, 349);
            this.queryButton.TabIndex = 3;
            this.queryButton.Text = "Execute &Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // monstersTableAdapter
            // 
            this.monstersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultsGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 349);
            this.panel1.TabIndex = 4;
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.exportToCSVToolStripMenuItem.Text = "Export To CSV...";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Pathfinder Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monstersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PathfinderDBParser_MonsterContextDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.Button queryButton;
        private _PathfinderDBParser_MonsterContextDataSet _PathfinderDBParser_MonsterContextDataSet;
        private System.Windows.Forms.BindingSource monstersBindingSource;
        private _PathfinderDBParser_MonsterContextDataSetTableAdapters.MonstersTableAdapter monstersTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBlockViewerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
    }
}

