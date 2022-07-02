namespace Mystat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbl_SwapTeacher = new System.Windows.Forms.Label();
            this.lbl_MainTeacher = new System.Windows.Forms.Label();
            this.lbl_GroupInfo = new System.Windows.Forms.Label();
            this.pnl_LessonContent = new System.Windows.Forms.Panel();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tBox_Content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_CrystalCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.student5 = new Mystat.Student();
            this.student4 = new Mystat.Student();
            this.student3 = new Mystat.Student();
            this.student2 = new Mystat.Student();
            this.student1 = new Mystat.Student();
            this.panel1.SuspendLayout();
            this.pnl_LessonContent.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.lbl_SwapTeacher);
            this.panel1.Controls.Add(this.lbl_MainTeacher);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(25, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 128);
            this.panel1.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 74);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.radioButton1.Location = new System.Drawing.Point(8, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // lbl_SwapTeacher
            // 
            this.lbl_SwapTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_SwapTeacher.AutoSize = true;
            this.lbl_SwapTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_SwapTeacher.Location = new System.Drawing.Point(36, 70);
            this.lbl_SwapTeacher.Name = "lbl_SwapTeacher";
            this.lbl_SwapTeacher.Size = new System.Drawing.Size(168, 23);
            this.lbl_SwapTeacher.TabIndex = 10;
            this.lbl_SwapTeacher.Text = "Müəllim əvəz olunur";
            // 
            // lbl_MainTeacher
            // 
            this.lbl_MainTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_MainTeacher.AutoSize = true;
            this.lbl_MainTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_MainTeacher.Location = new System.Drawing.Point(41, 31);
            this.lbl_MainTeacher.Name = "lbl_MainTeacher";
            this.lbl_MainTeacher.Size = new System.Drawing.Size(116, 23);
            this.lbl_MainTeacher.TabIndex = 9;
            this.lbl_MainTeacher.Text = "Əsas müəllim";
            // 
            // lbl_GroupInfo
            // 
            this.lbl_GroupInfo.AutoSize = true;
            this.lbl_GroupInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GroupInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GroupInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(246)))));
            this.lbl_GroupInfo.Location = new System.Drawing.Point(12, 26);
            this.lbl_GroupInfo.Name = "lbl_GroupInfo";
            this.lbl_GroupInfo.Size = new System.Drawing.Size(558, 32);
            this.lbl_GroupInfo.TabIndex = 3;
            this.lbl_GroupInfo.Text = "FBAS_2214_AZ (Windows Forms and WPF (CT - 3))";
            // 
            // pnl_LessonContent
            // 
            this.pnl_LessonContent.Controls.Add(this.btn_pen);
            this.pnl_LessonContent.Controls.Add(this.btn_add);
            this.pnl_LessonContent.Controls.Add(this.btn_cancel);
            this.pnl_LessonContent.Controls.Add(this.btn_save);
            this.pnl_LessonContent.Controls.Add(this.tBox_Content);
            this.pnl_LessonContent.Controls.Add(this.label1);
            this.pnl_LessonContent.Enabled = false;
            this.pnl_LessonContent.Location = new System.Drawing.Point(479, 80);
            this.pnl_LessonContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_LessonContent.Name = "pnl_LessonContent";
            this.pnl_LessonContent.Size = new System.Drawing.Size(507, 131);
            this.pnl_LessonContent.TabIndex = 16;
            // 
            // btn_pen
            // 
            this.btn_pen.Location = new System.Drawing.Point(149, 3);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(38, 29);
            this.btn_pen.TabIndex = 19;
            this.btn_pen.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Location = new System.Drawing.Point(329, 73);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(164, 43);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add Material";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Location = new System.Drawing.Point(424, 29);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(78, 38);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Location = new System.Drawing.Point(323, 29);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(78, 38);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // tBox_Content
            // 
            this.tBox_Content.Enabled = false;
            this.tBox_Content.Location = new System.Drawing.Point(3, 32);
            this.tBox_Content.Multiline = true;
            this.tBox_Content.Name = "tBox_Content";
            this.tBox_Content.Size = new System.Drawing.Size(314, 84);
            this.tBox_Content.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dərsin Mövzusu:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_CrystalCount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 64);
            this.panel2.TabIndex = 17;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(560, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 33;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mystat.Properties.Resources.icons_diamond_34;
            this.pictureBox1.Location = new System.Drawing.Point(923, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_CrystalCount
            // 
            this.lbl_CrystalCount.AutoSize = true;
            this.lbl_CrystalCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lbl_CrystalCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CrystalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_CrystalCount.Location = new System.Drawing.Point(894, 26);
            this.lbl_CrystalCount.Name = "lbl_CrystalCount";
            this.lbl_CrystalCount.Size = new System.Drawing.Size(23, 28);
            this.lbl_CrystalCount.TabIndex = 31;
            this.lbl_CrystalCount.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label8.Location = new System.Drawing.Point(774, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Sinifdə iş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label7.Location = new System.Drawing.Point(669, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Yoxlama işlər";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(496, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hər kəsi qeyd etmək";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(326, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "MyStats\'a daxil olub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(133, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Adı / Soyadı / Ata adı";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.student5);
            this.panel3.Controls.Add(this.student4);
            this.panel3.Controls.Add(this.student3);
            this.panel3.Controls.Add(this.student2);
            this.panel3.Controls.Add(this.student1);
            this.panel3.Location = new System.Drawing.Point(25, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 471);
            this.panel3.TabIndex = 18;
            // 
            // student5
            // 
            this.student5.Location = new System.Drawing.Point(0, 378);
            this.student5.Name = "student5";
            this.student5.Size = new System.Drawing.Size(1025, 90);
            this.student5.TabIndex = 0;
            // 
            // student4
            // 
            this.student4.Location = new System.Drawing.Point(0, 288);
            this.student4.Name = "student4";
            this.student4.Size = new System.Drawing.Size(1025, 90);
            this.student4.TabIndex = 0;
            // 
            // student3
            // 
            this.student3.Location = new System.Drawing.Point(0, 192);
            this.student3.Name = "student3";
            this.student3.Size = new System.Drawing.Size(1025, 90);
            this.student3.TabIndex = 0;
            // 
            // student2
            // 
            this.student2.Location = new System.Drawing.Point(0, 96);
            this.student2.Name = "student2";
            this.student2.Size = new System.Drawing.Size(1025, 90);
            this.student2.TabIndex = 0;
            // 
            // student1
            // 
            this.student1.Location = new System.Drawing.Point(0, 0);
            this.student1.Name = "student1";
            this.student1.Size = new System.Drawing.Size(1025, 90);
            this.student1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 789);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_LessonContent);
            this.Controls.Add(this.lbl_GroupInfo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_LessonContent.ResumeLayout(false);
            this.pnl_LessonContent.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lbl_SwapTeacher;
        private Label lbl_MainTeacher;
        private Label lbl_GroupInfo;
        private Panel pnl_LessonContent;
        private Button btn_add;
        private Button btn_cancel;
        private Button btn_save;
        private TextBox tBox_Content;
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel2;
        private RadioButton radioButton3;
        private PictureBox pictureBox1;
        public Label lbl_CrystalCount;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Panel panel3;
        private Student student1;
        private Student student5;
        private Student student4;
        private Student student3;
        private Student student2;
        private Button btn_pen;
    }
}