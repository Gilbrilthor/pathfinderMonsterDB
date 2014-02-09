namespace MonsterDBForm
{
    partial class DatabaseSelectorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.monsterCheckBox = new System.Windows.Forms.CheckBox();
            this.spellCheckBox = new System.Windows.Forms.CheckBox();
            this.featCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pick Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monsterCheckBox
            // 
            this.monsterCheckBox.AutoSize = true;
            this.monsterCheckBox.Location = new System.Drawing.Point(13, 13);
            this.monsterCheckBox.Name = "monsterCheckBox";
            this.monsterCheckBox.Size = new System.Drawing.Size(69, 17);
            this.monsterCheckBox.TabIndex = 3;
            this.monsterCheckBox.Text = "Monsters";
            this.monsterCheckBox.UseVisualStyleBackColor = true;
            // 
            // spellCheckBox
            // 
            this.spellCheckBox.AutoSize = true;
            this.spellCheckBox.Location = new System.Drawing.Point(13, 37);
            this.spellCheckBox.Name = "spellCheckBox";
            this.spellCheckBox.Size = new System.Drawing.Size(54, 17);
            this.spellCheckBox.TabIndex = 4;
            this.spellCheckBox.Text = "Spells";
            this.spellCheckBox.UseVisualStyleBackColor = true;
            // 
            // featCheckBox
            // 
            this.featCheckBox.AutoSize = true;
            this.featCheckBox.Location = new System.Drawing.Point(13, 61);
            this.featCheckBox.Name = "featCheckBox";
            this.featCheckBox.Size = new System.Drawing.Size(52, 17);
            this.featCheckBox.TabIndex = 5;
            this.featCheckBox.Text = "Feats";
            this.featCheckBox.UseVisualStyleBackColor = true;
            // 
            // DatabaseSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.featCheckBox);
            this.Controls.Add(this.spellCheckBox);
            this.Controls.Add(this.monsterCheckBox);
            this.Controls.Add(this.button1);
            this.Name = "DatabaseSelectorForm";
            this.Text = "DatabaseSelectorForm";
            this.Load += new System.EventHandler(this.DatabaseSelectorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox monsterCheckBox;
        private System.Windows.Forms.CheckBox spellCheckBox;
        private System.Windows.Forms.CheckBox featCheckBox;

    }
}