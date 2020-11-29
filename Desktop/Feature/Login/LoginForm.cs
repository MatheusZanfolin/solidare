using Solidare.Core.Architecture.Model;
using Solidare.Feature.Menu;
using System.Windows.Forms;

namespace Solidare.Feature.Login
{
    public partial class LoginForm : Form
    {
        private LoginController controller;

        public LoginForm()
        {
            InitializeComponent();

            controller = new LoginController(this);
        }

        private void BtnSignIn_Click(object sender, System.EventArgs e)
        {
            controller.OnLoginButtonClicked(TxtLogin.Text, TxtPassword.Text);
        }

        public void ShowErrorMessage()
        {
            MessageBox.Show("Login ou senha inválidos", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowMenuScreen(Administrator administrator)
        {
            ShowDialog(new MenuForm(administrator));
        }
    }
}
