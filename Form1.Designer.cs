namespace BDtrabalhoAluno
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            sexo = new DataGridViewTextBoxColumn();
            dataNasc = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            dataAdmissao = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(129, 619);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(131, 81);
            button1.TabIndex = 0;
            button1.Text = "NOVO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(373, 616);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(126, 79);
            button2.TabIndex = 1;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(633, 619);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(128, 79);
            button3.TabIndex = 2;
            button3.Text = "DELETAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(854, 616);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(131, 79);
            button4.TabIndex = 3;
            button4.Text = "SAIR";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 69);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(449, 68);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 5;
            button5.Text = "pesquisar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(553, 68);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 6;
            button6.Text = "limpar";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 43);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 7;
            label1.Text = "Localizar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, sexo, dataNasc, cpf, telefone, email, cargo, dataAdmissao });
            dataGridView1.Location = new Point(31, 135);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1109, 445);
            dataGridView1.TabIndex = 8;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.MinimumWidth = 6;
            Código.Name = "Código";
            Código.Width = 125;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // sexo
            // 
            sexo.HeaderText = "Sexo";
            sexo.MinimumWidth = 6;
            sexo.Name = "sexo";
            sexo.Width = 125;
            // 
            // dataNasc
            // 
            dataNasc.HeaderText = "Data Nascimento";
            dataNasc.MinimumWidth = 6;
            dataNasc.Name = "dataNasc";
            dataNasc.Width = 125;
            // 
            // cpf
            // 
            cpf.HeaderText = "CPF";
            cpf.MinimumWidth = 6;
            cpf.Name = "cpf";
            cpf.Width = 125;
            // 
            // telefone
            // 
            telefone.HeaderText = "Telefone";
            telefone.MinimumWidth = 6;
            telefone.Name = "telefone";
            telefone.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 125;
            // 
            // cargo
            // 
            cargo.HeaderText = "Cargo";
            cargo.MinimumWidth = 6;
            cargo.Name = "cargo";
            cargo.Width = 125;
            // 
            // dataAdmissao
            // 
            dataAdmissao.HeaderText = "Data Admissão";
            dataAdmissao.MinimumWidth = 6;
            dataAdmissao.Name = "dataAdmissao";
            dataAdmissao.Width = 125;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Código", "Nome", "CPF" });
            comboBox1.Location = new Point(40, 69);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 12);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 10;
            label2.Text = "CONSULTAR FUNCIONÁRIOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 764);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label2;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn sexo;
        private DataGridViewTextBoxColumn dataNasc;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn cargo;
        private DataGridViewTextBoxColumn dataAdmissao;
    }
}
