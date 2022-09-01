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
            if (MessageBox.Show("Já acabou a partida?", "Amigão sai não bebe!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

        private void lb_jogador2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Jogador1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void bt1_Click(object sender, EventArgs e)
        {

            if (rb_X.Checked)
            {

                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt1.Text = jogada;
                bt1.Enabled = true;

            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt1.Text = jogada;
                bt1.Enabled = true;
            }
            cont++;
            vencedor();


        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {

                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt2.Text = jogada;
                bt2.Enabled = true;

            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt2.Text = jogada;
                bt2.Enabled = true;
            }
            cont++;
            vencedor();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {

                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt3.Text = jogada;
                bt3.Enabled = true;
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt3.Text = jogada;
                bt3.Enabled = true;
            }
            cont++;
            vencedor();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {

                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt4.Text = jogada;
                bt4.Enabled = true;

            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt4.Text = jogada;
                bt4.Enabled = true;

            }
            cont++;
            vencedor();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {

                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt5.Text = jogada;
                bt5.Enabled = true;

            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt5.Text = jogada;
                bt5.Enabled = true;

            }
            cont++;
            vencedor();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {

                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt6.Text = jogada;
                bt6.Enabled = true;

            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt6.Text = jogada;
                bt6.Enabled = true;

            }
            cont++;
            vencedor();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {

                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt7.Text = jogada;
                bt7.Enabled = true;

            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt7.Text = jogada;
                bt7.Enabled = true;

            }
            cont++;
            vencedor();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {

                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt8.Text = jogada;
                bt8.Enabled = true;

            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt8.Text = jogada;
                bt8.Enabled = true;

            }
            cont++;
            vencedor();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {

                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt9.Text = jogada;
                bt9.Enabled = true;

            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt9.Text = jogada;
                bt9.Enabled = true;

            }
            cont++;
            vencedor();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i == 9; i--) ;
        }

        private void bt_Reiniciar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void vencedor()
        { if
            (
            (bt1.Text == "O") && (bt2.Text == "O") && (bt3.Text == "O") ||
            (bt4.Text == "O") && (bt5.Text == "O") && (bt6.Text == "O") ||
            (bt7.Text == "O") && (bt8.Text == "O") && (bt9.Text == "O")
            )
            {
                MessageBox.Show("Bola venceu", "CARALHO");
                limpar();
                panel1.Enabled = true;
            }
            else
            if (
                (bt1.Text == "X") && (bt2.Text == "X") && (bt3.Text == "X") ||
               (bt4.Text == "X") && (bt5.Text == "X") && (bt6.Text == "X") ||
               (bt7.Text == "X") && (bt8.Text == "X") && (bt9.Text == "X")
               )
                {
                MessageBox.Show("X ganhou", "CARALHO");
                limpar();
            }

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
            lb_Jogador1.Text = Njogador1 + " Joga com ";

            Njogador2 = tb_Jogador2.Text;
            tb_Jogador2.Visible = false;
            lb_Jogador2.Text = Njogador2 + " Joga com ";

            if (rb_X.Checked)
            {
                lb_Jogador1.Text = lb_Jogador1.Text + " X ";
                lb_Jogador2.Text = lb_Jogador2.Text + " O ";
            }
            else if (rb_O.Checked)
            {
                lb_Jogador1.Text = lb_Jogador1.Text + " O ";
                lb_Jogador2.Text = lb_Jogador2.Text + " X";
            }
          gb_Opcoes.Enabled = false;
            panel1.Enabled = true;
            lb_Pjogador1.Text = "0 -  Vitórias";
            lb_Pjogador2.Text = "0 - Vitórias";
           
        

        }
    }
}