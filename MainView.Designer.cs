namespace Thuc_Hanh_Buoi_1
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            label1 = new Label();
            DiceBox_IMG = new PictureBox();
            label2 = new Label();
            GuessNumber_BOX = new TextBox();
            panel1 = new Panel();
            welcome_LABEL = new Label();
            ROLL_BTN = new Button();
            rateWin = new Label();
            winCount = new Label();
            LoseCount = new Label();
            END_BTN = new Button();
            underText_TEXT = new Label();
            history_BOX = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DiceBox_IMG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 14);
            label1.Name = "label1";
            label1.Size = new Size(188, 33);
            label1.TabIndex = 0;
            label1.Text = "Đoán Xí Ngầu";
            label1.Click += label1_Click;
            // 
            // DiceBox_IMG
            // 
            DiceBox_IMG.Image = (Image)resources.GetObject("DiceBox_IMG.Image");
            DiceBox_IMG.Location = new Point(12, 89);
            DiceBox_IMG.Name = "DiceBox_IMG";
            DiceBox_IMG.Size = new Size(150, 150);
            DiceBox_IMG.SizeMode = PictureBoxSizeMode.StretchImage;
            DiceBox_IMG.TabIndex = 1;
            DiceBox_IMG.TabStop = false;
            DiceBox_IMG.Click += dice_clicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(182, 82);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 2;
            label2.Text = "Số dự đoán";
            label2.Click += label2_Click;
            // 
            // GuessNumber_BOX
            // 
            GuessNumber_BOX.BorderStyle = BorderStyle.None;
            GuessNumber_BOX.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            GuessNumber_BOX.Location = new Point(182, 103);
            GuessNumber_BOX.Multiline = true;
            GuessNumber_BOX.Name = "GuessNumber_BOX";
            GuessNumber_BOX.Size = new Size(86, 24);
            GuessNumber_BOX.TabIndex = 4;
            GuessNumber_BOX.TextAlign = HorizontalAlignment.Center;
            GuessNumber_BOX.TextChanged += GuessNumber_BOX_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(182, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 1);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // welcome_LABEL
            // 
            welcome_LABEL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            welcome_LABEL.Location = new Point(145, 47);
            welcome_LABEL.Name = "welcome_LABEL";
            welcome_LABEL.Size = new Size(163, 15);
            welcome_LABEL.TabIndex = 6;
            welcome_LABEL.Text = "Welcome back, USERNAME!";
            welcome_LABEL.TextAlign = ContentAlignment.MiddleCenter;
            welcome_LABEL.Click += welcome_LABEL_Click;
            // 
            // ROLL_BTN
            // 
            ROLL_BTN.BackColor = Color.Red;
            ROLL_BTN.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ROLL_BTN.ForeColor = Color.White;
            ROLL_BTN.Location = new Point(182, 136);
            ROLL_BTN.Name = "ROLL_BTN";
            ROLL_BTN.Size = new Size(86, 44);
            ROLL_BTN.TabIndex = 7;
            ROLL_BTN.Text = "ROLL";
            ROLL_BTN.UseVisualStyleBackColor = false;
            ROLL_BTN.Click += roll_clicked;
            // 
            // rateWin
            // 
            rateWin.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            rateWin.Location = new Point(294, 68);
            rateWin.Name = "rateWin";
            rateWin.Size = new Size(151, 18);
            rateWin.TabIndex = 8;
            rateWin.Text = "Tỉ lệ thắng:    100%";
            rateWin.Click += rateWin_Click;
            // 
            // winCount
            // 
            winCount.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            winCount.Location = new Point(294, 242);
            winCount.Name = "winCount";
            winCount.Size = new Size(68, 18);
            winCount.TabIndex = 8;
            winCount.Text = "Thắng: 0";
            winCount.Click += winCount_Click;
            // 
            // LoseCount
            // 
            LoseCount.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            LoseCount.Location = new Point(377, 242);
            LoseCount.Name = "LoseCount";
            LoseCount.Size = new Size(68, 18);
            LoseCount.TabIndex = 8;
            LoseCount.Text = "Thua: 0";
            LoseCount.Click += LoseCount_Click;
            // 
            // END_BTN
            // 
            END_BTN.BackColor = Color.LimeGreen;
            END_BTN.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            END_BTN.ForeColor = Color.White;
            END_BTN.Location = new Point(182, 186);
            END_BTN.MaximumSize = new Size(86, 44);
            END_BTN.Name = "END_BTN";
            END_BTN.Size = new Size(86, 44);
            END_BTN.TabIndex = 7;
            END_BTN.Text = "END";
            END_BTN.UseVisualStyleBackColor = false;
            END_BTN.Click += end_clicked;
            // 
            // underText_TEXT
            // 
            underText_TEXT.Font = new Font("Montserrat", 8.749999F, FontStyle.Bold, GraphicsUnit.Point);
            underText_TEXT.ForeColor = SystemColors.ControlText;
            underText_TEXT.Location = new Point(119, 260);
            underText_TEXT.Name = "underText_TEXT";
            underText_TEXT.Size = new Size(211, 37);
            underText_TEXT.TabIndex = 9;
            underText_TEXT.Text = "Hãy Nhập số cần đoán và ấn phím ROLL";
            underText_TEXT.TextAlign = ContentAlignment.MiddleCenter;
            underText_TEXT.Click += underText_TEXT_Click;
            // 
            // history_BOX
            // 
            history_BOX.AcceptsReturn = true;
            history_BOX.BackColor = Color.White;
            history_BOX.Font = new Font("Montserrat SemiBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
            history_BOX.ForeColor = SystemColors.WindowText;
            history_BOX.Location = new Point(294, 89);
            history_BOX.Multiline = true;
            history_BOX.Name = "history_BOX";
            history_BOX.ReadOnly = true;
            history_BOX.Size = new Size(151, 141);
            history_BOX.TabIndex = 11;
            history_BOX.WordWrap = false;
            history_BOX.TextChanged += history_BOX_TextChanged;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 324);
            Controls.Add(history_BOX);
            Controls.Add(underText_TEXT);
            Controls.Add(LoseCount);
            Controls.Add(winCount);
            Controls.Add(rateWin);
            Controls.Add(END_BTN);
            Controls.Add(ROLL_BTN);
            Controls.Add(welcome_LABEL);
            Controls.Add(panel1);
            Controls.Add(GuessNumber_BOX);
            Controls.Add(label2);
            Controls.Add(DiceBox_IMG);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainView";
            Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)DiceBox_IMG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox DiceBox_IMG;
        private Label label2;
        private TextBox GuessNumber_BOX;
        private Panel panel1;
        private Label welcome_LABEL;
        private Button ROLL_BTN;
        private Label rateWin;
        private Label winCount;
        private Label LoseCount;
        private Button END_BTN;
        private Label underText_TEXT;
        private Label label3;
        private TextBox history_BOX;
    }
}