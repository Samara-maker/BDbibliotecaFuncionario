namespace BDtrabalhoFuncionario.formularios
{
    partial class NovoFuncionario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            id_func = new TextBox();
            tbNome = new TextBox();
            cbSexo = new ComboBox();
            tbCpf = new TextBox();
            tbTelefone = new TextBox();
            tbemail = new TextBox();
            cbCargo = new ComboBox();
            btCancelar = new Button();
            btGravar = new Button();
            dtAdmissao = new DateTimePicker();
            dtDataNasc = new DateTimePicker();
            dataDemissao = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 41);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 41);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 2;
            label3.Text = "Data Nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(670, 41);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Sexo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 164);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 4;
            label5.Text = "CPF";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 164);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 5;
            label6.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(434, 164);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Cargo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(632, 164);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 271);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 8;
            label9.Text = "Admissão";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(389, 271);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 9;
            label10.Text = "Demissão";
            // 
            // id_func
            // 
            id_func.Enabled = false;
            id_func.Location = new Point(31, 67);
            id_func.Margin = new Padding(3, 4, 3, 4);
            id_func.Name = "id_func";
            id_func.ReadOnly = true;
            id_func.Size = new Size(52, 27);
            id_func.TabIndex = 10;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(127, 65);
            tbNome.Margin = new Padding(3, 4, 3, 4);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(209, 27);
            tbNome.TabIndex = 11;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Location = new Point(670, 65);
            cbSexo.Margin = new Padding(3, 4, 3, 4);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(138, 28);
            cbSexo.TabIndex = 13;
            // 
            // tbCpf
            // 
            tbCpf.Location = new Point(30, 188);
            tbCpf.Margin = new Padding(3, 4, 3, 4);
            tbCpf.Name = "tbCpf";
            tbCpf.Size = new Size(151, 27);
            tbCpf.TabIndex = 14;
            tbCpf.TextChanged += tbCpf_TextChanged;
            // 
            // tbTelefone
            // 
            tbTelefone.Location = new Point(218, 188);
            tbTelefone.Margin = new Padding(3, 4, 3, 4);
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(173, 27);
            tbTelefone.TabIndex = 15;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(632, 188);
            tbemail.Margin = new Padding(3, 4, 3, 4);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(209, 27);
            tbemail.TabIndex = 16;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(434, 188);
            cbCargo.Margin = new Padding(3, 4, 3, 4);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(159, 28);
            cbCargo.TabIndex = 17;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(670, 397);
            btCancelar.Margin = new Padding(3, 4, 3, 4);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(120, 68);
            btCancelar.TabIndex = 18;
            btCancelar.Text = "CANCELAR";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btGravar
            // 
            btGravar.Location = new Point(505, 397);
            btGravar.Margin = new Padding(3, 4, 3, 4);
            btGravar.Name = "btGravar";
            btGravar.Size = new Size(120, 68);
            btGravar.TabIndex = 19;
            btGravar.Text = "GRAVAR";
            btGravar.UseVisualStyleBackColor = true;
            btGravar.Click += btGravar_Click;
            // 
            // dtAdmissao
            // 
            dtAdmissao.Location = new Point(35, 295);
            dtAdmissao.Margin = new Padding(3, 4, 3, 4);
            dtAdmissao.Name = "dtAdmissao";
            dtAdmissao.Size = new Size(279, 27);
            dtAdmissao.TabIndex = 20;
            // 
            // dtDataNasc
            // 
            dtDataNasc.Location = new Point(360, 67);
            dtDataNasc.Margin = new Padding(3, 4, 3, 4);
            dtDataNasc.Name = "dtDataNasc";
            dtDataNasc.Size = new Size(279, 27);
            dtDataNasc.TabIndex = 21;
            // 
            // dataDemissao
            // 
            dataDemissao.Enabled = false;
            dataDemissao.Location = new Point(389, 297);
            dataDemissao.Margin = new Padding(3, 4, 3, 4);
            dataDemissao.Name = "dataDemissao";
            dataDemissao.Size = new Size(173, 27);
            dataDemissao.TabIndex = 22;
            // 
            // NovoFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 496);
            Controls.Add(dataDemissao);
            Controls.Add(dtDataNasc);
            Controls.Add(dtAdmissao);
            Controls.Add(btGravar);
            Controls.Add(btCancelar);
            Controls.Add(cbCargo);
            Controls.Add(tbemail);
            Controls.Add(tbTelefone);
            Controls.Add(tbCpf);
            Controls.Add(cbSexo);
            Controls.Add(tbNome);
            Controls.Add(id_func);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NovoFuncionario";
            Text = "NovoFuncionario";
            Load += NovoFuncionario_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox id_func;
        private TextBox tbNome;
        private ComboBox cbSexo;
        private TextBox tbCpf;
        private TextBox tbTelefone;
        private TextBox tbemail;
        private ComboBox cbCargo;
        private Button btCancelar;
        private Button btGravar;
        private DateTimePicker dtAdmissao;
        private DateTimePicker dtDataNasc;
        private TextBox dataDemissao;
    }
}