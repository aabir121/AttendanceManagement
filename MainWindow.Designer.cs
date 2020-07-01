namespace SDProject
{
    partial class MainWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.regContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regUser = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.logPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.logUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.regContact);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.regConfirm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.regPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.regUser);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(72, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.BackgroundImage = global::SDProject.Properties.Resources.Andrew_Classroom_De_La_Salle_University;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(143, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // regContact
            // 
            this.regContact.BackColor = System.Drawing.SystemColors.Info;
            this.regContact.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regContact.Location = new System.Drawing.Point(223, 169);
            this.regContact.Name = "regContact";
            this.regContact.Size = new System.Drawing.Size(212, 33);
            this.regContact.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact Number";
            // 
            // regConfirm
            // 
            this.regConfirm.BackColor = System.Drawing.SystemColors.Info;
            this.regConfirm.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regConfirm.Location = new System.Drawing.Point(223, 134);
            this.regConfirm.MaxLength = 1000;
            this.regConfirm.Name = "regConfirm";
            this.regConfirm.PasswordChar = '*';
            this.regConfirm.Size = new System.Drawing.Size(212, 33);
            this.regConfirm.TabIndex = 5;
            this.regConfirm.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password";
            // 
            // regPass
            // 
            this.regPass.BackColor = System.Drawing.SystemColors.Info;
            this.regPass.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPass.Location = new System.Drawing.Point(223, 95);
            this.regPass.MaxLength = 1000;
            this.regPass.Name = "regPass";
            this.regPass.PasswordChar = '*';
            this.regPass.Size = new System.Drawing.Size(212, 33);
            this.regPass.TabIndex = 3;
            this.regPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // regUser
            // 
            this.regUser.BackColor = System.Drawing.SystemColors.Info;
            this.regUser.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUser.Location = new System.Drawing.Point(223, 56);
            this.regUser.Name = "regUser";
            this.regUser.Size = new System.Drawing.Size(212, 33);
            this.regUser.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Username.Location = new System.Drawing.Point(6, 56);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(116, 29);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.logPass);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.logUser);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(645, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 202);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.BackgroundImage = global::SDProject.Properties.Resources.Andrew_Classroom_De_La_Salle_University;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(154, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logPass
            // 
            this.logPass.BackColor = System.Drawing.SystemColors.Info;
            this.logPass.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPass.Location = new System.Drawing.Point(223, 95);
            this.logPass.Name = "logPass";
            this.logPass.Size = new System.Drawing.Size(212, 33);
            this.logPass.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password";
            // 
            // logUser
            // 
            this.logUser.BackColor = System.Drawing.SystemColors.Info;
            this.logUser.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logUser.Location = new System.Drawing.Point(223, 56);
            this.logUser.Name = "logUser";
            this.logUser.Size = new System.Drawing.Size(212, 33);
            this.logUser.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDProject.Properties.Resources.Andrew_Classroom_De_La_Salle_University1;
            this.ClientSize = new System.Drawing.Size(1143, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox regContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regUser;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox logPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox logUser;
        private System.Windows.Forms.Label label8;
    }
}

