
namespace Hospital_Management_System
{
    partial class Visitors_View
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
            this.VisitorsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1074, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VisitorsView
            // 
            this.VisitorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorsView.Location = new System.Drawing.Point(12, 23);
            this.VisitorsView.Name = "VisitorsView";
            this.VisitorsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VisitorsView.Size = new System.Drawing.Size(1137, 383);
            this.VisitorsView.TabIndex = 19;
            this.VisitorsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisitorsView_CellContentClick);
            // 
            // Visitors_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 456);
            this.Controls.Add(this.VisitorsView);
            this.Controls.Add(this.button1);
            this.Name = "Visitors_View";
            this.Text = "Visitors_View";
            this.Load += new System.EventHandler(this.Visitors_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView VisitorsView;
    }
}