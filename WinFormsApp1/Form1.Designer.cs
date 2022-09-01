namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gb_Jogadores = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Contador = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_Jogador2 = new System.Windows.Forms.TextBox();
            this.tb_Jogador1 = new System.Windows.Forms.TextBox();
            this.lb_Jogador2 = new System.Windows.Forms.Label();
            this.lb_Jogador1 = new System.Windows.Forms.Label();
            this.rb_O = new System.Windows.Forms.RadioButton();
            this.rb_X = new System.Windows.Forms.RadioButton();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Iniciar = new System.Windows.Forms.Button();
            this.bt_Reiniciar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Pjogador2 = new System.Windows.Forms.Label();
            this.lb_Pjogador1 = new System.Windows.Forms.Label();
            this.gb_Opcoes = new System.Windows.Forms.GroupBox();
            this.gb_Placar = new System.Windows.Forms.GroupBox();
            this.gb_Empate = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Salvar
            // 
            resources.ApplyResources(this.bt_Salvar, "bt_Salvar");
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.Salvar);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // gb_Jogadores
            // 
            resources.ApplyResources(this.gb_Jogadores, "gb_Jogadores");
            this.gb_Jogadores.Name = "gb_Jogadores";
            this.gb_Jogadores.TabStop = false;
            this.gb_Jogadores.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lb_Contador);
            this.panel1.Controls.Add(this.bt1);
            this.panel1.Controls.Add(this.bt9);
            this.panel1.Controls.Add(this.bt6);
            this.panel1.Controls.Add(this.bt3);
            this.panel1.Controls.Add(this.bt8);
            this.panel1.Controls.Add(this.bt5);
            this.panel1.Controls.Add(this.bt4);
            this.panel1.Controls.Add(this.bt7);
            this.panel1.Controls.Add(this.bt2);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_Contador
            // 
            resources.ApplyResources(this.lb_Contador, "lb_Contador");
            this.lb_Contador.Name = "lb_Contador";
            this.lb_Contador.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt1
            // 
            resources.ApplyResources(this.bt1, "bt1");
            this.bt1.Name = "bt1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt9
            // 
            resources.ApplyResources(this.bt9, "bt9");
            this.bt9.Name = "bt9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt6
            // 
            resources.ApplyResources(this.bt6, "bt6");
            this.bt6.Name = "bt6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt3
            // 
            resources.ApplyResources(this.bt3, "bt3");
            this.bt3.Name = "bt3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt8
            // 
            resources.ApplyResources(this.bt8, "bt8");
            this.bt8.Name = "bt8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt5
            // 
            resources.ApplyResources(this.bt5, "bt5");
            this.bt5.Name = "bt5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            resources.ApplyResources(this.bt4, "bt4");
            this.bt4.Name = "bt4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt7
            // 
            resources.ApplyResources(this.bt7, "bt7");
            this.bt7.Name = "bt7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt2
            // 
            resources.ApplyResources(this.bt2, "bt2");
            this.bt2.Name = "bt2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.tb_Jogador2);
            this.panel2.Controls.Add(this.tb_Jogador1);
            this.panel2.Controls.Add(this.lb_Jogador2);
            this.panel2.Controls.Add(this.lb_Jogador1);
            this.panel2.Controls.Add(this.rb_O);
            this.panel2.Controls.Add(this.rb_X);
            this.panel2.Controls.Add(this.bt_Sair);
            this.panel2.Controls.Add(this.bt_Iniciar);
            this.panel2.Controls.Add(this.bt_Reiniciar);
            this.panel2.Controls.Add(this.bt_Salvar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lb_Pjogador2);
            this.panel2.Controls.Add(this.lb_Pjogador1);
            this.panel2.Controls.Add(this.gb_Opcoes);
            this.panel2.Controls.Add(this.gb_Placar);
            this.panel2.Controls.Add(this.gb_Empate);
            this.panel2.Controls.Add(this.gb_Jogadores);
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tb_Jogador2
            // 
            resources.ApplyResources(this.tb_Jogador2, "tb_Jogador2");
            this.tb_Jogador2.Name = "tb_Jogador2";
            this.tb_Jogador2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_Jogador1
            // 
            resources.ApplyResources(this.tb_Jogador1, "tb_Jogador1");
            this.tb_Jogador1.Name = "tb_Jogador1";
            this.tb_Jogador1.TextChanged += new System.EventHandler(this.tb_Jogador1_TextChanged);
            // 
            // lb_Jogador2
            // 
            resources.ApplyResources(this.lb_Jogador2, "lb_Jogador2");
            this.lb_Jogador2.Name = "lb_Jogador2";
            // 
            // lb_Jogador1
            // 
            resources.ApplyResources(this.lb_Jogador1, "lb_Jogador1");
            this.lb_Jogador1.Name = "lb_Jogador1";
            // 
            // rb_O
            // 
            resources.ApplyResources(this.rb_O, "rb_O");
            this.rb_O.Name = "rb_O";
            this.rb_O.TabStop = true;
            this.rb_O.UseVisualStyleBackColor = true;
            // 
            // rb_X
            // 
            resources.ApplyResources(this.rb_X, "rb_X");
            this.rb_X.Name = "rb_X";
            this.rb_X.TabStop = true;
            this.rb_X.UseVisualStyleBackColor = true;
            // 
            // bt_Sair
            // 
            resources.ApplyResources(this.bt_Sair, "bt_Sair");
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Iniciar
            // 
            resources.ApplyResources(this.bt_Iniciar, "bt_Iniciar");
            this.bt_Iniciar.Name = "bt_Iniciar";
            this.bt_Iniciar.UseVisualStyleBackColor = true;
            this.bt_Iniciar.Click += new System.EventHandler(this.bt_Iniciar_Click);
            // 
            // bt_Reiniciar
            // 
            resources.ApplyResources(this.bt_Reiniciar, "bt_Reiniciar");
            this.bt_Reiniciar.Name = "bt_Reiniciar";
            this.bt_Reiniciar.UseVisualStyleBackColor = true;
            this.bt_Reiniciar.Click += new System.EventHandler(this.bt_Reiniciar_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lb_Pjogador2
            // 
            resources.ApplyResources(this.lb_Pjogador2, "lb_Pjogador2");
            this.lb_Pjogador2.Name = "lb_Pjogador2";
            // 
            // lb_Pjogador1
            // 
            resources.ApplyResources(this.lb_Pjogador1, "lb_Pjogador1");
            this.lb_Pjogador1.Name = "lb_Pjogador1";
            // 
            // gb_Opcoes
            // 
            resources.ApplyResources(this.gb_Opcoes, "gb_Opcoes");
            this.gb_Opcoes.Name = "gb_Opcoes";
            this.gb_Opcoes.TabStop = false;
            // 
            // gb_Placar
            // 
            resources.ApplyResources(this.gb_Placar, "gb_Placar");
            this.gb_Placar.Name = "gb_Placar";
            this.gb_Placar.TabStop = false;
            // 
            // gb_Empate
            // 
            resources.ApplyResources(this.gb_Empate, "gb_Empate");
            this.gb_Empate.Name = "gb_Empate";
            this.gb_Empate.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button bt_Salvar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private GroupBox gb_Jogadores;
        private Panel panel1;
        private Panel panel2;
        private Button bt_Iniciar;
        private Button bt_Reiniciar;
        private Label label5;
        private Label lb_Pjogador2;
        private Label lb_Pjogador1;
        private GroupBox gb_Opcoes;
        private GroupBox gb_Placar;
        private GroupBox gb_Empate;
        private Button bt_Sair;
        private RadioButton rb_O;
        private RadioButton rb_X;
        private TextBox tb_Jogador2;
        private TextBox tb_Jogador1;
        private Button bt9;
        private Button bt6;
        private Button bt3;
        private Button bt8;
        private Button bt5;
        private Button bt4;
        private Button bt7;
        private Button bt2;
        private Button bt1;
        private Label lb_Jogador2;
        private Label lb_Jogador1;
        private Label lb_Contador;
    }
}