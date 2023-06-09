namespace Thuc_Hanh_Buoi_1
{
    partial class LoginView
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            Username_BOX = new TextBox();
            Password_BOX = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            LOGIN_BTN = new Button();
            EXIT_BTN = new Button();
            ClearField_BTN = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 74);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "USERNAME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(12, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 2);
            panel1.TabIndex = 2;
            // 
            // Username_BOX
            // 
            Username_BOX.BorderStyle = BorderStyle.None;
            Username_BOX.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Username_BOX.Location = new Point(12, 168);
            Username_BOX.Multiline = true;
            Username_BOX.Name = "Username_BOX";
            Username_BOX.Size = new Size(279, 24);
            Username_BOX.TabIndex = 3;
            // 
            // Password_BOX
            // 
            Password_BOX.BorderStyle = BorderStyle.None;
            Password_BOX.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Password_BOX.Location = new Point(12, 233);
            Password_BOX.Multiline = true;
            Password_BOX.Name = "Password_BOX";
            Password_BOX.PasswordChar = '*';
            Password_BOX.Size = new Size(279, 24);
            Password_BOX.TabIndex = 6;
            Password_BOX.TextChanged += Password_BOX_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(12, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 2);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 210);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 4;
            label3.Text = "PASSWORD";
            // 
            // LOGIN_BTN
            // 
            LOGIN_BTN.BackColor = Color.DodgerBlue;
            LOGIN_BTN.FlatAppearance.BorderSize = 0;
            LOGIN_BTN.FlatStyle = FlatStyle.Flat;
            LOGIN_BTN.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LOGIN_BTN.ForeColor = Color.White;
            LOGIN_BTN.Location = new Point(12, 278);
            LOGIN_BTN.Name = "LOGIN_BTN";
            LOGIN_BTN.Size = new Size(132, 37);
            LOGIN_BTN.TabIndex = 7;
            LOGIN_BTN.Text = "LOG IN";
            LOGIN_BTN.UseVisualStyleBackColor = false;
            LOGIN_BTN.Click += login_clicked;
            // 
            // EXIT_BTN
            // 
            EXIT_BTN.BackColor = Color.DodgerBlue;
            EXIT_BTN.FlatAppearance.BorderSize = 0;
            EXIT_BTN.FlatStyle = FlatStyle.Flat;
            EXIT_BTN.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EXIT_BTN.ForeColor = Color.White;
            EXIT_BTN.Location = new Point(159, 278);
            EXIT_BTN.Name = "EXIT_BTN";
            EXIT_BTN.Size = new Size(132, 37);
            EXIT_BTN.TabIndex = 8;
            EXIT_BTN.Text = "EXIT";
            EXIT_BTN.UseVisualStyleBackColor = false;
            EXIT_BTN.Click += exit_clicked;
            // 
            // ClearField_BTN
            // 
            ClearField_BTN.AutoSize = true;
            ClearField_BTN.Font = new Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ClearField_BTN.ForeColor = SystemColors.MenuHighlight;
            ClearField_BTN.Location = new Point(95, 327);
            ClearField_BTN.Name = "ClearField_BTN";
            ClearField_BTN.Size = new Size(113, 20);
            ClearField_BTN.TabIndex = 9;
            ClearField_BTN.Text = "CLEAR FIELDS";
            ClearField_BTN.Click += clear_clicked;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(303, 391);
            Controls.Add(ClearField_BTN);
            Controls.Add(EXIT_BTN);
            Controls.Add(LOGIN_BTN);
            Controls.Add(Password_BOX);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(Username_BOX);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += LoginView_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox Username_BOX;
        private TextBox Password_BOX;
        private Panel panel2;
        private Label label3;
        private Button LOGIN_BTN;
        private Button EXIT_BTN;
        private Label ClearField_BTN;
    }
}