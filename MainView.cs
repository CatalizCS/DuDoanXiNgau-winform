using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuc_Hanh_Buoi_1
{
    public partial class MainView : Form
    {
        private string username;
        public MainView(string username)
        {
            InitializeComponent();
            this.username = username;
            this.welcome_LABEL.Text = "Welcome back, " + username + "!";
        }

        private int allGuest = 0,
                    win = 0,
                    lose = 0,
                    guessNumber = 0,
                    diceNumber = 0;
        private string diceImage = "",
                       dicePath = "";

        Random rand = new Random();

        private List<string> diceImages = new List<string>()
        {
            "dice1.png",
            "dice2.png",
            "dice3.png",
            "dice4.png",
            "dice5.png",
            "dice6.png"
        };

        ListViewItem historyItem = new ListViewItem("");



        private void dice_clicked(object sender, EventArgs e)
        {
            roll_clicked(sender, e);
        }

        private void roll_clicked(object sender, EventArgs e)
        {
            if (GuessNumber_BOX.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số cần dự đoán!", "Missing guess number");
                return;
            }

            guessNumber = int.Parse(GuessNumber_BOX.Text);
            if (guessNumber < 1 || guessNumber > 6)
            {
                MessageBox.Show("Vui lòng nhập số từ 1 đến 6!", "Invalid guess number");
                return;
            }
            diceNumber = rand.Next(1, 7);
            diceImage = diceImages[diceNumber - 1];
            dicePath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "../", "../", "../", @"Dices\", diceImage);
            allGuest++;

            history_BOX.AppendText("guess: " + guessNumber + " - dice: " + diceNumber + Environment.NewLine);

            if (guessNumber == diceNumber)
            {
                win++;
                underText_TEXT.Text = "Bạn đã thắng!";
            }
            else
            {
                lose++;
                underText_TEXT.Text = "Bạn đã thua!";
            }

            winCount.Text = "Thắng: " + win.ToString();
            LoseCount.Text = "Thua: " + lose.ToString();
            rateWin.Text = "Tỉ lệ thắng:    " + ((double)win / allGuest * 100).ToString("0.00") + "%";
            DiceBox_IMG.Image = Image.FromFile(dicePath);
        }

        private void end_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Tỉ lệ thắng: " + ((double)win / allGuest * 100).ToString("0.00") + "%" + Environment.NewLine +
                                           "Số lần thắng: " + win + Environment.NewLine +
                                                                      "Số lần thua: " + lose + Environment.NewLine +
                                                                                                 "Số lần đoán: " + allGuest, "Kết quả");

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.Close();
                LoginView loginView = new LoginView();
                loginView.Show();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void winCount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void welcome_LABEL_Click(object sender, EventArgs e)
        {

        }

        private void GuessNumber_BOX_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void rateWin_Click(object sender, EventArgs e)
        {
        }

        private void LoseCount_Click(object sender, EventArgs e)
        {
        }

        private void underText_TEXT_Click(object sender, EventArgs e)
        {
        }

        private void history_BOX_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
