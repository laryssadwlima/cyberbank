namespace cyberbank
{
    partial class TelaLogin
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
            button_entrar = new Button();
            buttoncriarconta = new Button();
            labelccpf = new Label();
            labelsenha = new Label();
            textBoxsenha = new TextBox();
            textBoxcpf = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_entrar
            // 
            button_entrar.BackColor = Color.DodgerBlue;
            button_entrar.FlatStyle = FlatStyle.Flat;
            button_entrar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_entrar.ForeColor = SystemColors.ButtonHighlight;
            button_entrar.Location = new Point(1401, 584);
            button_entrar.Name = "button_entrar";
            button_entrar.Size = new Size(131, 50);
            button_entrar.TabIndex = 0;
            button_entrar.Text = "Entrar";
            button_entrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_entrar.UseVisualStyleBackColor = false;
            button_entrar.Click += button_entrar_Click;
            // 
            // buttoncriarconta
            // 
            buttoncriarconta.AccessibleRole = AccessibleRole.OutlineButton;
            buttoncriarconta.AutoSize = true;
            buttoncriarconta.BackColor = Color.DodgerBlue;
            buttoncriarconta.Cursor = Cursors.AppStarting;
            buttoncriarconta.FlatAppearance.BorderColor = Color.DodgerBlue;
            buttoncriarconta.FlatStyle = FlatStyle.Flat;
            buttoncriarconta.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncriarconta.ForeColor = SystemColors.ButtonHighlight;
            buttoncriarconta.Location = new Point(931, 850);
            buttoncriarconta.Name = "buttoncriarconta";
            buttoncriarconta.RightToLeft = RightToLeft.No;
            buttoncriarconta.Size = new Size(217, 50);
            buttoncriarconta.TabIndex = 1;
            buttoncriarconta.Text = "Abra sua conta";
            buttoncriarconta.UseVisualStyleBackColor = false;
            buttoncriarconta.Click += buttoncriarconta_Click;
            // 
            // labelccpf
            // 
            labelccpf.AutoSize = true;
            labelccpf.BackColor = Color.White;
            labelccpf.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelccpf.ForeColor = Color.Gray;
            labelccpf.Location = new Point(1113, 395);
            labelccpf.Name = "labelccpf";
            labelccpf.Size = new Size(55, 32);
            labelccpf.TabIndex = 2;
            labelccpf.Text = "CPF";
            // 
            // labelsenha
            // 
            labelsenha.AutoSize = true;
            labelsenha.BackColor = Color.White;
            labelsenha.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelsenha.ForeColor = Color.Gray;
            labelsenha.Location = new Point(1113, 484);
            labelsenha.Name = "labelsenha";
            labelsenha.Size = new Size(91, 32);
            labelsenha.TabIndex = 3;
            labelsenha.Text = "SENHA";
            // 
            // textBoxsenha
            // 
            textBoxsenha.BackColor = SystemColors.ButtonHighlight;
            textBoxsenha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxsenha.Location = new Point(1113, 519);
            textBoxsenha.Name = "textBoxsenha";
            textBoxsenha.Size = new Size(419, 39);
            textBoxsenha.TabIndex = 5;
            // 
            // textBoxcpf
            // 
            textBoxcpf.AllowDrop = true;
            textBoxcpf.BackColor = SystemColors.ButtonHighlight;
            textBoxcpf.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxcpf.Location = new Point(1113, 431);
            textBoxcpf.Margin = new Padding(3, 4, 3, 4);
            textBoxcpf.Mask = "000.000.000-00";
            textBoxcpf.Name = "textBoxcpf";
            textBoxcpf.RightToLeft = RightToLeft.No;
            textBoxcpf.Size = new Size(419, 39);
            textBoxcpf.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tela1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1765, 927);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 924);
            Controls.Add(textBoxcpf);
            Controls.Add(buttoncriarconta);
            Controls.Add(textBoxsenha);
            Controls.Add(labelsenha);
            Controls.Add(labelccpf);
            Controls.Add(button_entrar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaLogin";
            Text = "Form1";
            Load += TelaLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_entrar;
        private Label labelccpf;
        private Label labelsenha;
        private TextBox textBoxsenha;
        public Button buttoncriarconta;
        private MaskedTextBox textBoxcpf;
        private PictureBox pictureBox1;
    }
}
