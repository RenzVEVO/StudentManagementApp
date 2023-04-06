namespace StudentManagingApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.txt_dia_chi = new System.Windows.Forms.TextBox();
            this.txt_ten_hs = new System.Windows.Forms.TextBox();
            this.txt_ma_hs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_hoc_sinh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoc_sinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_ngay_sinh);
            this.groupBox1.Controls.Add(this.txt_dia_chi);
            this.groupBox1.Controls.Add(this.txt_ten_hs);
            this.groupBox1.Controls.Add(this.txt_ma_hs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // dt_ngay_sinh
            // 
            this.dt_ngay_sinh.Location = new System.Drawing.Point(160, 193);
            this.dt_ngay_sinh.Name = "dt_ngay_sinh";
            this.dt_ngay_sinh.Size = new System.Drawing.Size(470, 30);
            this.dt_ngay_sinh.TabIndex = 8;
            // 
            // txt_dia_chi
            // 
            this.txt_dia_chi.Location = new System.Drawing.Point(160, 241);
            this.txt_dia_chi.Name = "txt_dia_chi";
            this.txt_dia_chi.Size = new System.Drawing.Size(473, 30);
            this.txt_dia_chi.TabIndex = 7;
            // 
            // txt_ten_hs
            // 
            this.txt_ten_hs.Location = new System.Drawing.Point(281, 89);
            this.txt_ten_hs.Name = "txt_ten_hs";
            this.txt_ten_hs.Size = new System.Drawing.Size(352, 30);
            this.txt_ten_hs.TabIndex = 5;
            // 
            // txt_ma_hs
            // 
            this.txt_ma_hs.Location = new System.Drawing.Point(281, 41);
            this.txt_ma_hs.Name = "txt_ma_hs";
            this.txt_ma_hs.Size = new System.Drawing.Size(352, 30);
            this.txt_ma_hs.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(18, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(18, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student First/Last Name:";
            // 
            // dg_hoc_sinh
            // 
            this.dg_hoc_sinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_hoc_sinh.Location = new System.Drawing.Point(24, 333);
            this.dg_hoc_sinh.Name = "dg_hoc_sinh";
            this.dg_hoc_sinh.RowHeadersWidth = 51;
            this.dg_hoc_sinh.RowTemplate.Height = 24;
            this.dg_hoc_sinh.Size = new System.Drawing.Size(978, 188);
            this.dg_hoc_sinh.TabIndex = 2;
            this.dg_hoc_sinh.SelectionChanged += new System.EventHandler(this.dg_hoc_sinh_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Exit);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(740, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 293);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Info Tool";
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Exit.Location = new System.Drawing.Point(75, 235);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(134, 31);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Edit.Location = new System.Drawing.Point(75, 176);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(134, 31);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Del.Location = new System.Drawing.Point(75, 111);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(134, 31);
            this.btn_Del.TabIndex = 1;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Add.Location = new System.Drawing.Point(75, 44);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(134, 31);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dg_hoc_sinh);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Student Dossier Managing Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoc_sinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dia_chi;
        private System.Windows.Forms.TextBox txt_ten_hs;
        private System.Windows.Forms.TextBox txt_ma_hs;
        private System.Windows.Forms.DataGridView dg_hoc_sinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dt_ngay_sinh;
    }
}

