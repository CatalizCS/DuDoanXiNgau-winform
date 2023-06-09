namespace Thuc_Hanh_Buoi_1
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void LoginView_Load_1(object sender, EventArgs e)
        {

        }

        private void exit_clicked(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void clear_clicked(object sender, EventArgs e)
        {
            Username_BOX.Clear();
            Password_BOX.Clear();
            Username_BOX.Focus();
        }

        private void Password_BOX_TextChanged(object sender, EventArgs e)
        {

        }

        private List<(string, string)> validCredentials = new List<(string, string)>
        {
            ("admin", "password"),
            ("user1", "pass123"),
            ("user2", "qwerty"),
            ("a", "a")
        };

        private int retry = 0;


        private void login_clicked(object sender, EventArgs e)
        {
            String username, password;

            username = Username_BOX.Text;
            password = Password_BOX.Text;

            if (retry > 3) {
                MessageBox.Show("You have reached maximum number of retries", "LOGIN FAILED");
                this.Close();
                Application.Exit();
            }

            if (username.Equals("") || password.Equals(""))
            {
                retry++;
                MessageBox.Show("Please enter username and password", "LOGIN FAILED");
                return;
            }

            foreach (var credential in validCredentials)
            {
                if (credential.Item1.Equals(username) && credential.Item2.Equals(password))
                {
                    MessageBox.Show("Welcome " + username, "LOGIN SUCCESSFUL");
                    this.Hide();
                    new MainView(username).Show();
                    return;
                }
            }

            retry++;
            MessageBox.Show("Invalid username or password", "LOGIN FAILED");
        }
    }
}