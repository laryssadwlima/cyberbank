namespace cyberbank
{
    partial class TelaNavegacao
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
            btnDepositar = new Button();
            btnSaque = new Button();
            btnExtrato = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2robogif = new PictureBox();
            setasair = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2robogif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)setasair).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(172, 249);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "ClienteAtivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(175, 325);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 1;
            label2.Text = "SaldoAtivo";
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.White;
            btnDepositar.FlatAppearance.BorderColor = Color.White;
            btnDepositar.FlatAppearance.MouseDownBackColor = Color.White;
            btnDepositar.FlatAppearance.MouseOverBackColor = Color.White;
            btnDepositar.FlatStyle = FlatStyle.Flat;
            btnDepositar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepositar.ForeColor = Color.DimGray;
            btnDepositar.ImageAlign = ContentAlignment.MiddleRight;
            btnDepositar.Location = new Point(1125, 426);
            btnDepositar.Margin = new Padding(3, 4, 3, 4);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(426, 52);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "Depositar";
            btnDepositar.TextAlign = ContentAlignment.MiddleLeft;
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSaque
            // 
            btnSaque.BackColor = Color.White;
            btnSaque.BackgroundImageLayout = ImageLayout.None;
            btnSaque.FlatAppearance.BorderColor = Color.White;
            btnSaque.FlatAppearance.MouseDownBackColor = Color.White;
            btnSaque.FlatAppearance.MouseOverBackColor = Color.White;
            btnSaque.FlatStyle = FlatStyle.Flat;
            btnSaque.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaque.ForeColor = Color.DimGray;
            btnSaque.Location = new Point(1125, 330);
            btnSaque.Margin = new Padding(3, 4, 3, 4);
            btnSaque.Name = "btnSaque";
            btnSaque.Size = new Size(323, 51);
            btnSaque.TabIndex = 3;
            btnSaque.Text = "Sacar";
            btnSaque.TextAlign = ContentAlignment.MiddleLeft;
            btnSaque.UseVisualStyleBackColor = false;
            btnSaque.Click += btnSaque_Click;
            // 
            // btnExtrato
            // 
            btnExtrato.BackColor = Color.White;
            btnExtrato.FlatAppearance.BorderColor = Color.White;
            btnExtrato.FlatAppearance.MouseDownBackColor = Color.White;
            btnExtrato.FlatAppearance.MouseOverBackColor = Color.White;
            btnExtrato.FlatStyle = FlatStyle.Flat;
            btnExtrato.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExtrato.ForeColor = Color.DimGray;
            btnExtrato.Location = new Point(1125, 534);
            btnExtrato.Margin = new Padding(3, 4, 3, 4);
            btnExtrato.Name = "btnExtrato";
            btnExtrato.Size = new Size(426, 56);
            btnExtrato.TabIndex = 4;
            btnExtrato.Text = "Ver Extrato";
            btnExtrato.TextAlign = ContentAlignment.MiddleLeft;
            btnExtrato.UseVisualStyleBackColor = false;
            btnExtrato.Click += btnExtrato_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.telanavegacao;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1765, 927);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2robogif
            // 
            pictureBox2robogif.BackColor = Color.White;
            pictureBox2robogif.Image = Properties.Resources.telanavegacaogif;
            pictureBox2robogif.Location = new Point(84, 406);
            pictureBox2robogif.Name = "pictureBox2robogif";
            pictureBox2robogif.Size = new Size(611, 401);
            pictureBox2robogif.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2robogif.TabIndex = 6;
            pictureBox2robogif.TabStop = false;
            // 
            // setasair
            // 
            setasair.BackColor = Color.White;
            setasair.Image = Properties.Resources.sair;
            setasair.Location = new Point(1678, 40);
            setasair.Name = "setasair";
            setasair.Size = new Size(48, 66);
            setasair.SizeMode = PictureBoxSizeMode.Zoom;
            setasair.TabIndex = 7;
            setasair.TabStop = false;
            setasair.Click += setasair_Click;
            // 
            // TelaNavegacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 921);
            Controls.Add(setasair);
            Controls.Add(pictureBox2robogif);
            Controls.Add(btnExtrato);
            Controls.Add(btnSaque);
            Controls.Add(btnDepositar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaNavegacao";
            Text = "Menu Cliente";
            Load += TelaNavegacao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2robogif).EndInit();
            ((System.ComponentModel.ISupportInitialize)setasair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnDepositar;
        private Button btnSaque;
        private Button btnExtrato;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2robogif;
        private PictureBox setasair;
    }
}