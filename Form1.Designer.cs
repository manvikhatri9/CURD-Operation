
namespace Curd_operation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.StudentRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentRecordDataGridView
            // 
            this.StudentRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecordDataGridView.Location = new System.Drawing.Point(12, 531);
            this.StudentRecordDataGridView.Name = "StudentRecordDataGridView";
            this.StudentRecordDataGridView.RowHeadersWidth = 51;
            this.StudentRecordDataGridView.RowTemplate.Height = 29;
            this.StudentRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentRecordDataGridView.Size = new System.Drawing.Size(832, 216);
            this.StudentRecordDataGridView.TabIndex = 3;
            this.StudentRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordDataGridView_CellContentClick);
            this.StudentRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordDataGridView_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(614, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "FatherName :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "MobileNumber :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 30);
            this.txtName.TabIndex = 11;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(193, 184);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(221, 30);
            this.txtFatherName.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(193, 318);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(221, 30);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(193, 381);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(221, 30);
            this.txtMobileNumber.TabIndex = 14;
            this.txtMobileNumber.TextChanged += new System.EventHandler(this.txtMobileNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Roll Number :";
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.Location = new System.Drawing.Point(193, 253);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(221, 30);
            this.txtRollNumber.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Student Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 759);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRollNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StudentRecordDataGridView);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobileNumber;
        public System.Windows.Forms.DataGridView StudentRecordDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.Label label1;
    }
}

