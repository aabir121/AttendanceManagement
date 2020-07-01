namespace SDProject
{
    partial class Report
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
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.percentageTextBox = new System.Windows.Forms.TextBox();
            this.absentTextBox = new System.Windows.Forms.TextBox();
            this.presentTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generateBtn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // courseComboBox
            // 
            this.courseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(215, 68);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(201, 33);
            this.courseComboBox.TabIndex = 1;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // idComboBox
            // 
            this.idComboBox.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(215, 131);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(201, 32);
            this.idComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Course";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.Transparent;
            this.generateBtn.Controls.Add(this.button1);
            this.generateBtn.Controls.Add(this.label3);
            this.generateBtn.Controls.Add(this.idComboBox);
            this.generateBtn.Controls.Add(this.label2);
            this.generateBtn.Controls.Add(this.courseComboBox);
            this.generateBtn.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.Silver;
            this.generateBtn.Location = new System.Drawing.Point(152, 278);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(444, 235);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.TabStop = false;
            this.generateBtn.Text = "Generate Report";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SDProject.Properties.Resources.Andrew_Classroom_De_La_Salle_University;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(176, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.percentageTextBox);
            this.panel1.Controls.Add(this.absentTextBox);
            this.panel1.Controls.Add(this.presentTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(748, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 188);
            this.panel1.TabIndex = 5;
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageTextBox.Location = new System.Drawing.Point(270, 138);
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.ReadOnly = true;
            this.percentageTextBox.Size = new System.Drawing.Size(190, 27);
            this.percentageTextBox.TabIndex = 9;
            // 
            // absentTextBox
            // 
            this.absentTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentTextBox.Location = new System.Drawing.Point(270, 107);
            this.absentTextBox.Name = "absentTextBox";
            this.absentTextBox.ReadOnly = true;
            this.absentTextBox.Size = new System.Drawing.Size(190, 27);
            this.absentTextBox.TabIndex = 8;
            // 
            // presentTextBox
            // 
            this.presentTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentTextBox.Location = new System.Drawing.Point(270, 74);
            this.presentTextBox.Name = "presentTextBox";
            this.presentTextBox.ReadOnly = true;
            this.presentTextBox.Size = new System.Drawing.Size(190, 27);
            this.presentTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(270, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(190, 27);
            this.nameTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(270, 14);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(190, 27);
            this.idTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Attendance Percentage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Absent";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Present";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student ID";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDProject.Properties.Resources.Andrew_Classroom_De_La_Salle_University1;
            this.ClientSize = new System.Drawing.Size(1279, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.generateBtn.ResumeLayout(false);
            this.generateBtn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox generateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox percentageTextBox;
        private System.Windows.Forms.TextBox absentTextBox;
        private System.Windows.Forms.TextBox presentTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}