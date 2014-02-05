namespace MonsterDBForm
{
    partial class InfoBox
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
            this.infoTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoTextLabel
            // 
            this.infoTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextLabel.Location = new System.Drawing.Point(0, 0);
            this.infoTextLabel.Margin = new System.Windows.Forms.Padding(10);
            this.infoTextLabel.MaximumSize = new System.Drawing.Size(300, 237);
            this.infoTextLabel.Name = "infoTextLabel";
            this.infoTextLabel.Padding = new System.Windows.Forms.Padding(10);
            this.infoTextLabel.Size = new System.Drawing.Size(284, 199);
            this.infoTextLabel.TabIndex = 2;
            this.infoTextLabel.Text = "Info Box Label Text";
            this.infoTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.infoTextLabel);
            this.Name = "InfoBox";
            this.Text = "InfoBox";
            this.Load += new System.EventHandler(this.InfoBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoTextLabel;

    }
}