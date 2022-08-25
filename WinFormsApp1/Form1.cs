namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string Njogador1, Njogador2, jogada; /*nome do jogadores ex: Njogador1*/
        int cont = 0, Pjogador1 = 0, Pjogador2 = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Caixa_Saida_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvar(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void txtB1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Qualé já vai porra?", "Amigão sai não em seu vacilão!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void vencedor()
        {
            

        }
        public void limpar()
        {
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
        }
        public void habilitar_botoes()
        {
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt9.Enabled = true;
        }

        private void bt_Iniciar_Click(object sender, EventArgs e)
        {
            Njogador1 = tb_Jogador1.Text;
            tb_Jogador1.Visible = false;
        }
    }
}