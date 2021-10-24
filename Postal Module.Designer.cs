
namespace Hospital_Management_System
{
    partial class Postal_Module
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedPostalRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchPostalRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedPostalRecordToolStripMenuItem1,
            this.dispatchPostalRecordToolStripMenuItem1});
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.mailToolStripMenuItem.Text = "Mail";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.mailToolStripMenuItem_Click);
            // 
            // receivedPostalRecordToolStripMenuItem1
            // 
            this.receivedPostalRecordToolStripMenuItem1.Name = "receivedPostalRecordToolStripMenuItem1";
            this.receivedPostalRecordToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.receivedPostalRecordToolStripMenuItem1.Text = "Received Postal Record";
            this.receivedPostalRecordToolStripMenuItem1.Click += new System.EventHandler(this.receivedPostalRecordToolStripMenuItem1_Click);
            // 
            // dispatchPostalRecordToolStripMenuItem1
            // 
            this.dispatchPostalRecordToolStripMenuItem1.Name = "dispatchPostalRecordToolStripMenuItem1";
            this.dispatchPostalRecordToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.dispatchPostalRecordToolStripMenuItem1.Text = "Dispatch Postal Record";
            this.dispatchPostalRecordToolStripMenuItem1.Click += new System.EventHandler(this.dispatchPostalRecordToolStripMenuItem1_Click);
            // 
            // Postal_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Postal_Module";
            this.Text = "Postal_Module";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedPostalRecordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dispatchPostalRecordToolStripMenuItem1;
    }
}