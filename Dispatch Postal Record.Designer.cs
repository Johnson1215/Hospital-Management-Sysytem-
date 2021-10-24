
namespace Hospital_Management_System
{
    partial class Dispatch_Postal_Record
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
            this.Dname = new System.Windows.Forms.TextBox();
            this.DReferenceNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DAttach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DNote1 = new System.Windows.Forms.TextBox();
            this.DFromAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.Dname);
            this.panel1.Controls.Add(this.DReferenceNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DAttach);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FromName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DNote1);
            this.panel1.Controls.Add(this.DFromAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(239, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 332);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Dname
            // 
            this.Dname.Location = new System.Drawing.Point(190, 48);
            this.Dname.Name = "Dname";
            this.Dname.Size = new System.Drawing.Size(158, 20);
            this.Dname.TabIndex = 0;
            // 
            // DReferenceNumber
            // 
            this.DReferenceNumber.Location = new System.Drawing.Point(190, 85);
            this.DReferenceNumber.Name = "DReferenceNumber";
            this.DReferenceNumber.Size = new System.Drawing.Size(158, 20);
            this.DReferenceNumber.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "To Name";
            // 
            // DAttach
            // 
            this.DAttach.Location = new System.Drawing.Point(190, 261);
            this.DAttach.Name = "DAttach";
            this.DAttach.Size = new System.Drawing.Size(158, 20);
            this.DAttach.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Reference Number";
            // 
            // FromName
            // 
            this.FromName.Location = new System.Drawing.Point(190, 191);
            this.FromName.Name = "FromName";
            this.FromName.Size = new System.Drawing.Size(158, 20);
            this.FromName.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Date (default set to current date)";
            // 
            // DNote1
            // 
            this.DNote1.Location = new System.Drawing.Point(190, 156);
            this.DNote1.Name = "DNote1";
            this.DNote1.Size = new System.Drawing.Size(158, 20);
            this.DNote1.TabIndex = 22;
            // 
            // DFromAddress
            // 
            this.DFromAddress.Location = new System.Drawing.Point(190, 120);
            this.DFromAddress.Name = "DFromAddress";
            this.DFromAddress.Size = new System.Drawing.Size(158, 20);
            this.DFromAddress.TabIndex = 20;
            this.DFromAddress.TextChanged += new System.EventHandler(this.DFromAddress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "From Name";
            // 
            // DDate
            // 
            this.DDate.Location = new System.Drawing.Point(188, 226);
            this.DDate.Name = "DDate";
            this.DDate.Size = new System.Drawing.Size(158, 20);
            this.DDate.TabIndex = 26;
            this.DDate.TextChanged += new System.EventHandler(this.DDate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "From Address";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(681, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 20);
            this.button4.TabIndex = 34;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(681, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 21);
            this.button3.TabIndex = 33;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 20);
            this.button2.TabIndex = 32;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 88);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 261);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Attachment";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Dispatch_Postal_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Dispatch_Postal_Record";
            this.Text = "Dispatch_Postal_Record";
            this.Load += new System.EventHandler(this.Dispatch_Postal_Record_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Dname;
        private System.Windows.Forms.TextBox DReferenceNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DAttach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FromName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DNote1;
        private System.Windows.Forms.TextBox DFromAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
    }
}