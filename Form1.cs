namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            txt_Usuario.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_Usuario.Text == "User001" && txt_Senha.Text == "12345")
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Senha_Enter(object sender, EventArgs e)
        {
            txt_Senha.BackColor = Color.Yellow;
        }

        private void txt_Senha_Leave(object sender, EventArgs e)
        {
            txt_Senha.BackColor = Color.White;
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            txt_Usuario.BackColor = Color.White;
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8 && tecla != 32)
            {
                e.Handled = true;
                MessageBox.Show("Apenas letras, números e espaços são permitidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Usuario.Focus();
                txt_Usuario.SelectAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Tem certeza de que quer cancelar?", "Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (escolha == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Ótima decisão!", "Você fez a escolha certa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Senha_KeyPress(object sender, KeyPressEventArgs e)
        { 
                
            

        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_Senha_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
    }
}
