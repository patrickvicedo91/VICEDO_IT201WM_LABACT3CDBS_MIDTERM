using System.Windows.Forms;

namespace VICEDO_IT201WM_LABACT3CDBS_MIDTERM
{
    public class LoginForm : Form
    {
        private Button btnLogin;
        public bool LoggedIn { get; private set; }
        public LoginForm()
        {
            Text = "Welcome";
            Width = 300;
            Height = 180;
            btnLogin = new Button();
            btnLogin.Text = "Enter";
            btnLogin.Location = new System.Drawing.Point(100, 70);
            btnLogin.Click += BtnLogin_Click;
            Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            LoggedIn = true;
            Close();
        }
    }
}
