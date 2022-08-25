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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_Jogador1 = new System.Windows.Forms.TextBox();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Iniciar = new System.Windows.Forms.Button();
            this.bt_Reiniciar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_Opcoes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Placar = new System.Windows.Forms.GroupBox();
            this.gb_Empate = new System.Windows.Forms.GroupBox();
            this.lb_jogador = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            // 
            // bt1
            // 
            resources.ApplyResources(this.bt1, "bt1");
            this.bt1.Name = "bt1";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // bt9
            // 
            resources.ApplyResources(this.bt9, "bt9");
            this.bt9.Name = "bt9";
            this.bt9.UseVisualStyleBackColor = true;
            // 
            // bt6
            // 
            resources.ApplyResources(this.bt6, "bt6");
            this.bt6.Name = "bt6";
            this.bt6.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            resources.ApplyResources(this.bt3, "bt3");
            this.bt3.Name = "bt3";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt8
            // 
            resources.ApplyResources(this.bt8, "bt8");
            this.bt8.Name = "bt8";
            this.bt8.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            resources.ApplyResources(this.bt5, "bt5");
            this.bt5.Name = "bt5";
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            resources.ApplyResources(this.bt4, "bt4");
            this.bt4.Name = "bt4";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            resources.ApplyResources(this.bt7, "bt7");
            this.bt7.Name = "bt7";
            this.bt7.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            resources.ApplyResources(this.bt2, "bt2");
            this.bt2.Name = "bt2";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lb_jogador);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.tb_Jogador1);
            this.panel2.Controls.Add(this.bt_Sair);
            this.panel2.Controls.Add(this.bt_Iniciar);
            this.panel2.Controls.Add(this.bt_Reiniciar);
            this.panel2.Controls.Add(this.bt_Salvar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.gb_Opcoes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.gb_Placar);
            this.panel2.Controls.Add(this.gb_Empate);
            this.panel2.Controls.Add(this.gb_Jogadores);
            this.panel2.Name = "panel2";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // tb_Jogador1
            // 
            resources.ApplyResources(this.tb_Jogador1, "tb_Jogador1");
            this.tb_Jogador1.Name = "tb_Jogador1";
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
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // gb_Opcoes
            // 
            resources.ApplyResources(this.gb_Opcoes, "gb_Opcoes");
            this.gb_Opcoes.Name = "gb_Opcoes";
            this.gb_Opcoes.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // lb_jogador
            // 
            resources.ApplyResources(this.lb_jogador, "lb_jogador");
            this.lb_jogador.Name = "lb_jogador";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
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
        private Label label4;
        private Label label3;
        private GroupBox gb_Opcoes;
        private Label label2;
        private Label label1;
        private GroupBox gb_Placar;
        private GroupBox gb_Empate;
        private Button bt_Sair;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox2;
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
        private Label label7;
        private Label lb_jogador;
    }
}