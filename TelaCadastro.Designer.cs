namespace cyberbank
{
    partial class TelaCadastro
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
            textBoxnomecliente = new TextBox();
            labelnome = new Label();
            labeldatanasc = new Label();
            labelgenero = new Label();
            labelrg = new Label();
            textBoxrg = new TextBox();
            labelcpf = new Label();
            labelestado = new Label();
            textBoxestado = new TextBox();
            labelcidade = new Label();
            textBoxcidade = new TextBox();
            labelbairro = new Label();
            textBoxbairro = new TextBox();
            labelrua = new Label();
            textBoxrua = new TextBox();
            labelnumero = new Label();
            textBoxnumero = new TextBox();
            buttoncriarconta = new Button();
            labelsenha = new Label();
            textBoxsenha = new TextBox();
            buttoncancelar = new Button();
            labelconfirmarsenha = new Label();
            textBoxconfirmarconta = new TextBox();
            comboBoxgenero = new ComboBox();
            textBoxcpf = new MaskedTextBox();
            label2 = new Label();
            sada = new Label();
            label3 = new Label();
            label4 = new Label();
            textdatanascimento = new DateTimePicker();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxnomecliente
            // 
            textBoxnomecliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxnomecliente.Location = new Point(379, 283);
            textBoxnomecliente.Name = "textBoxnomecliente";
            textBoxnomecliente.Size = new Size(226, 34);
            textBoxnomecliente.TabIndex = 1;
            // 
            // labelnome
            // 
            labelnome.AutoSize = true;
            labelnome.BackColor = Color.White;
            labelnome.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelnome.ForeColor = Color.Gray;
            labelnome.Location = new Point(379, 248);
            labelnome.Name = "labelnome";
            labelnome.Size = new Size(199, 32);
            labelnome.TabIndex = 1;
            labelnome.Text = "Nome Completo:";
            labelnome.Click += labelnome_Click;
            // 
            // labeldatanasc
            // 
            labeldatanasc.AutoSize = true;
            labeldatanasc.BackColor = Color.White;
            labeldatanasc.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labeldatanasc.ForeColor = Color.Gray;
            labeldatanasc.Location = new Point(377, 335);
            labeldatanasc.Name = "labeldatanasc";
            labeldatanasc.Size = new Size(242, 32);
            labeldatanasc.TabIndex = 3;
            labeldatanasc.Text = "Data de Nascimento:";
            // 
            // labelgenero
            // 
            labelgenero.AutoSize = true;
            labelgenero.BackColor = Color.White;
            labelgenero.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelgenero.ForeColor = Color.Gray;
            labelgenero.Location = new Point(902, 335);
            labelgenero.Name = "labelgenero";
            labelgenero.Size = new Size(100, 32);
            labelgenero.TabIndex = 7;
            labelgenero.Text = "Genêro:";
            // 
            // labelrg
            // 
            labelrg.AutoSize = true;
            labelrg.BackColor = Color.White;
            labelrg.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelrg.ForeColor = Color.Gray;
            labelrg.Location = new Point(379, 525);
            labelrg.Name = "labelrg";
            labelrg.Size = new Size(52, 32);
            labelrg.TabIndex = 9;
            labelrg.Text = "RG:";
            // 
            // textBoxrg
            // 
            textBoxrg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxrg.Location = new Point(377, 560);
            textBoxrg.Name = "textBoxrg";
            textBoxrg.Size = new Size(228, 34);
            textBoxrg.TabIndex = 4;
            // 
            // labelcpf
            // 
            labelcpf.AutoSize = true;
            labelcpf.BackColor = Color.White;
            labelcpf.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelcpf.ForeColor = Color.Gray;
            labelcpf.Location = new Point(377, 433);
            labelcpf.Name = "labelcpf";
            labelcpf.Size = new Size(61, 32);
            labelcpf.TabIndex = 12;
            labelcpf.Text = "CPF:";
            // 
            // labelestado
            // 
            labelestado.AutoSize = true;
            labelestado.BackColor = Color.White;
            labelestado.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelestado.ForeColor = Color.Gray;
            labelestado.Location = new Point(640, 248);
            labelestado.Name = "labelestado";
            labelestado.Size = new Size(92, 32);
            labelestado.TabIndex = 13;
            labelestado.Text = "Estado:";
            // 
            // textBoxestado
            // 
            textBoxestado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxestado.Location = new Point(640, 283);
            textBoxestado.Name = "textBoxestado";
            textBoxestado.Size = new Size(228, 34);
            textBoxestado.TabIndex = 5;
            // 
            // labelcidade
            // 
            labelcidade.AutoSize = true;
            labelcidade.BackColor = Color.White;
            labelcidade.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelcidade.ForeColor = Color.Gray;
            labelcidade.Location = new Point(640, 339);
            labelcidade.Name = "labelcidade";
            labelcidade.Size = new Size(95, 32);
            labelcidade.TabIndex = 15;
            labelcidade.Text = "Cidade:";
            // 
            // textBoxcidade
            // 
            textBoxcidade.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxcidade.Location = new Point(640, 374);
            textBoxcidade.Name = "textBoxcidade";
            textBoxcidade.Size = new Size(233, 34);
            textBoxcidade.TabIndex = 6;
            textBoxcidade.TextChanged += textBoxcidade_TextChanged;
            // 
            // labelbairro
            // 
            labelbairro.AutoSize = true;
            labelbairro.BackColor = Color.White;
            labelbairro.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelbairro.ForeColor = Color.Gray;
            labelbairro.Location = new Point(640, 433);
            labelbairro.Name = "labelbairro";
            labelbairro.Size = new Size(86, 32);
            labelbairro.TabIndex = 17;
            labelbairro.Text = "Bairro:";
            // 
            // textBoxbairro
            // 
            textBoxbairro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxbairro.Location = new Point(640, 469);
            textBoxbairro.Name = "textBoxbairro";
            textBoxbairro.Size = new Size(231, 34);
            textBoxbairro.TabIndex = 7;
            textBoxbairro.TextChanged += textBoxbairro_TextChanged;
            // 
            // labelrua
            // 
            labelrua.AutoSize = true;
            labelrua.BackColor = Color.White;
            labelrua.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelrua.ForeColor = Color.Gray;
            labelrua.Location = new Point(640, 525);
            labelrua.Name = "labelrua";
            labelrua.Size = new Size(62, 32);
            labelrua.TabIndex = 19;
            labelrua.Text = "Rua:";
            // 
            // textBoxrua
            // 
            textBoxrua.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxrua.Location = new Point(640, 560);
            textBoxrua.Name = "textBoxrua";
            textBoxrua.Size = new Size(228, 34);
            textBoxrua.TabIndex = 8;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.BackColor = Color.White;
            labelnumero.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelnumero.ForeColor = Color.Gray;
            labelnumero.Location = new Point(902, 248);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(109, 32);
            labelnumero.TabIndex = 21;
            labelnumero.Text = "Número:";
            // 
            // textBoxnumero
            // 
            textBoxnumero.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxnumero.Location = new Point(902, 283);
            textBoxnumero.Name = "textBoxnumero";
            textBoxnumero.Size = new Size(205, 34);
            textBoxnumero.TabIndex = 9;
            // 
            // buttoncriarconta
            // 
            buttoncriarconta.BackColor = Color.DodgerBlue;
            buttoncriarconta.FlatAppearance.BorderColor = Color.DodgerBlue;
            buttoncriarconta.FlatStyle = FlatStyle.Flat;
            buttoncriarconta.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncriarconta.ForeColor = SystemColors.ControlLightLight;
            buttoncriarconta.Location = new Point(1192, 660);
            buttoncriarconta.Name = "buttoncriarconta";
            buttoncriarconta.Size = new Size(163, 47);
            buttoncriarconta.TabIndex = 23;
            buttoncriarconta.Text = "Criar Conta";
            buttoncriarconta.UseVisualStyleBackColor = false;
            buttoncriarconta.Click += buttoncriarconta_Click;
            // 
            // labelsenha
            // 
            labelsenha.AutoSize = true;
            labelsenha.BackColor = Color.White;
            labelsenha.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelsenha.ForeColor = Color.Gray;
            labelsenha.Location = new Point(1138, 248);
            labelsenha.Name = "labelsenha";
            labelsenha.Size = new Size(87, 32);
            labelsenha.TabIndex = 24;
            labelsenha.Text = "Senha:";
            labelsenha.Click += labelsenha_Click;
            // 
            // textBoxsenha
            // 
            textBoxsenha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxsenha.Location = new Point(1138, 283);
            textBoxsenha.Name = "textBoxsenha";
            textBoxsenha.Size = new Size(217, 34);
            textBoxsenha.TabIndex = 11;
            // 
            // buttoncancelar
            // 
            buttoncancelar.BackColor = Color.Red;
            buttoncancelar.FlatAppearance.BorderColor = Color.Red;
            buttoncancelar.FlatStyle = FlatStyle.Flat;
            buttoncancelar.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncancelar.ForeColor = SystemColors.ControlLightLight;
            buttoncancelar.Location = new Point(379, 660);
            buttoncancelar.Name = "buttoncancelar";
            buttoncancelar.Size = new Size(163, 47);
            buttoncancelar.TabIndex = 26;
            buttoncancelar.Text = "Cancelar";
            buttoncancelar.UseVisualStyleBackColor = false;
            buttoncancelar.Click += buttoncancelar_Click_1;
            // 
            // labelconfirmarsenha
            // 
            labelconfirmarsenha.AutoSize = true;
            labelconfirmarsenha.BackColor = Color.White;
            labelconfirmarsenha.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelconfirmarsenha.ForeColor = Color.Gray;
            labelconfirmarsenha.Location = new Point(1138, 335);
            labelconfirmarsenha.Name = "labelconfirmarsenha";
            labelconfirmarsenha.Size = new Size(200, 32);
            labelconfirmarsenha.TabIndex = 27;
            labelconfirmarsenha.Text = "Confirmar senha:";
            // 
            // textBoxconfirmarconta
            // 
            textBoxconfirmarconta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxconfirmarconta.Location = new Point(1138, 372);
            textBoxconfirmarconta.Name = "textBoxconfirmarconta";
            textBoxconfirmarconta.Size = new Size(217, 34);
            textBoxconfirmarconta.TabIndex = 12;
            // 
            // comboBoxgenero
            // 
            comboBoxgenero.AutoCompleteCustomSource.AddRange(new string[] { "Feminino", "Masculino", "Outros" });
            comboBoxgenero.AutoCompleteMode = AutoCompleteMode.Append;
            comboBoxgenero.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxgenero.BackColor = Color.White;
            comboBoxgenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxgenero.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxgenero.FormattingEnabled = true;
            comboBoxgenero.Items.AddRange(new object[] { "Feminino", "Masculino", "Outros" });
            comboBoxgenero.Location = new Point(902, 373);
            comboBoxgenero.MaxDropDownItems = 3;
            comboBoxgenero.Name = "comboBoxgenero";
            comboBoxgenero.Size = new Size(205, 36);
            comboBoxgenero.TabIndex = 10;
            // 
            // textBoxcpf
            // 
            textBoxcpf.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxcpf.Location = new Point(379, 469);
            textBoxcpf.Margin = new Padding(3, 4, 3, 4);
            textBoxcpf.Mask = "000.000.000-00";
            textBoxcpf.Name = "textBoxcpf";
            textBoxcpf.Size = new Size(226, 34);
            textBoxcpf.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(902, 320);
            label2.Name = "label2";
            label2.Size = new Size(155, 15);
            label2.TabIndex = 32;
            label2.Text = "(Exemplo: \"Apto 14\", \"204\") ";
            label2.Click += label2_Click;
            // 
            // sada
            // 
            sada.AutoSize = true;
            sada.BackColor = Color.White;
            sada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sada.ForeColor = SystemColors.ControlDarkDark;
            sada.Location = new Point(1138, 320);
            sada.Name = "sada";
            sada.Size = new Size(160, 15);
            sada.TabIndex = 33;
            sada.Text = "(Deve conter de 4 a 6 dígitos)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(1138, 412);
            label3.Name = "label3";
            label3.Size = new Size(224, 19);
            label3.TabIndex = 12;
            label3.Text = "(Deve ser identica a senha anterior)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(377, 507);
            label4.Name = "label4";
            label4.Size = new Size(157, 15);
            label4.TabIndex = 35;
            label4.Text = "(Exemplo: \"088.488.985-91\") ";
            // 
            // textdatanascimento
            // 
            textdatanascimento.CalendarFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textdatanascimento.CustomFormat = "dd/MMMM/yyyy";
            textdatanascimento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textdatanascimento.Format = DateTimePickerFormat.Custom;
            textdatanascimento.Location = new Point(379, 374);
            textdatanascimento.Margin = new Padding(3, 4, 3, 4);
            textdatanascimento.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            textdatanascimento.MinDate = new DateTime(1850, 1, 1, 0, 0, 0, 0);
            textdatanascimento.Name = "textdatanascimento";
            textdatanascimento.Size = new Size(226, 34);
            textdatanascimento.TabIndex = 2;
            textdatanascimento.Value = new DateTime(2024, 7, 6, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(377, 414);
            label5.Name = "label5";
            label5.Size = new Size(174, 15);
            label5.TabIndex = 37;
            label5.Text = "(Exemplo: \"22/Fevereiro/1992\") ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.telacadastro;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1765, 927);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(379, 597);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 39;
            label1.Text = "(Deve conter 9 dígitos)";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 921);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(textdatanascimento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(sada);
            Controls.Add(label2);
            Controls.Add(textBoxcpf);
            Controls.Add(comboBoxgenero);
            Controls.Add(textBoxconfirmarconta);
            Controls.Add(labelconfirmarsenha);
            Controls.Add(buttoncancelar);
            Controls.Add(textBoxsenha);
            Controls.Add(labelsenha);
            Controls.Add(buttoncriarconta);
            Controls.Add(textBoxnumero);
            Controls.Add(labelnumero);
            Controls.Add(textBoxrua);
            Controls.Add(labelrua);
            Controls.Add(textBoxbairro);
            Controls.Add(labelbairro);
            Controls.Add(textBoxcidade);
            Controls.Add(labelcidade);
            Controls.Add(textBoxestado);
            Controls.Add(labelestado);
            Controls.Add(labelcpf);
            Controls.Add(textBoxrg);
            Controls.Add(labelrg);
            Controls.Add(labelgenero);
            Controls.Add(labeldatanasc);
            Controls.Add(labelnome);
            Controls.Add(textBoxnomecliente);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaCadastro";
            Text = "Cadastro";
            Load += TelaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxnomecliente;
        private Label labelnome;
        private Label labeldatanasc;
        private Label labelgenero;
        private Label labelrg;
        private TextBox textBoxrg;
        private Label labelcpf;
        private Label labelestado;
        private TextBox textBoxestado;
        private Label labelcidade;
        private TextBox textBoxcidade;
        private Label labelbairro;
        private TextBox textBoxbairro;
        private Label labelrua;
        private TextBox textBoxrua;
        private Label labelnumero;
        private TextBox textBoxnumero;
        private Button buttoncriarconta;
        private Label labelsenha;
        private TextBox textBoxsenha;
        private Button buttoncancelar;
        private Label labelconfirmarsenha;
        private TextBox textBoxconfirmarconta;
        private ComboBox comboBoxgenero;
        private MaskedTextBox textBoxcpf;
        private Label label2;
        private Label sada;
        private Label label3;
        private Label label4;
        private DateTimePicker textdatanascimento;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
    }
}