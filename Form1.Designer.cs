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
            btEditar = new Button();
            btDeletar = new Button();
            btSair = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            dgvFuncionario = new DataGridView();
            comboBox1 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
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
            // btEditar
            // 
            btEditar.Location = new Point(373, 616);
            btEditar.Margin = new Padding(3, 4, 3, 4);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(126, 79);
            btEditar.TabIndex = 1;
            btEditar.Text = "EDITAR";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btDeletar
            // 
            btDeletar.Location = new Point(633, 619);
            btDeletar.Margin = new Padding(3, 4, 3, 4);
            btDeletar.Name = "btDeletar";
            btDeletar.Size = new Size(128, 79);
            btDeletar.TabIndex = 2;
            btDeletar.Text = "DELETAR";
            btDeletar.UseVisualStyleBackColor = true;
            btDeletar.Click += btDeletar_Click;
            // 
            // btSair
            // 
            btSair.Location = new Point(854, 616);
            btSair.Margin = new Padding(3, 4, 3, 4);
            btSair.Name = "btSair";
            btSair.Size = new Size(131, 79);
            btSair.TabIndex = 3;
            btSair.Text = "SAIR";
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
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
            // dgvFuncionario
            // 
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Location = new Point(31, 135);
            dgvFuncionario.Margin = new Padding(3, 4, 3, 4);
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.RowHeadersWidth = 51;
            dgvFuncionario.Size = new Size(1109, 445);
            dgvFuncionario.TabIndex = 8;
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
            Controls.Add(dgvFuncionario);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(btSair);
            Controls.Add(btDeletar);
            Controls.Add(btEditar);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btEditar;
        private Button btDeletar;
        private Button btSair;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
        private Label label1;
        private DataGridView dgvFuncionario;
        private ComboBox comboBox1;
        private Label label2;
    }
}
