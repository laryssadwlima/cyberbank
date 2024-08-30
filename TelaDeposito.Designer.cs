namespace cyberbank
{
    partial class TelaDeposito
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
            digitarSaldo = new NumericUpDown();
            btnDepositoCancelar = new Button();
            btnDepositoConfirmar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)digitarSaldo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(717, 122);
            label1.Name = "label1";
            label1.Size = new Size(161, 47);
            label1.TabIndex = 0;
            label1.Text = "Depósito";
            // 
            // digitarSaldo
            // 
            digitarSaldo.BackColor = Color.White;
            digitarSaldo.DecimalPlaces = 2;
            digitarSaldo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            digitarSaldo.Location = new Point(753, 390);
            digitarSaldo.Margin = new Padding(3, 4, 3, 4);
            digitarSaldo.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            digitarSaldo.Name = "digitarSaldo";
            digitarSaldo.Size = new Size(137, 54);
            digitarSaldo.TabIndex = 3;
            digitarSaldo.ThousandsSeparator = true;
            digitarSaldo.ValueChanged += digitarSaldo_ValueChanged;
            // 
            // btnDepositoCancelar
            // 
            btnDepositoCancelar.BackColor = SystemColors.MenuHighlight;
            btnDepositoCancelar.BackgroundImageLayout = ImageLayout.Center;
            btnDepositoCancelar.FlatAppearance.BorderColor = Color.LightSkyBlue;
            btnDepositoCancelar.FlatStyle = FlatStyle.Flat;
            btnDepositoCancelar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepositoCancelar.ForeColor = Color.White;
            btnDepositoCancelar.Location = new Point(565, 542);
            btnDepositoCancelar.Margin = new Padding(3, 4, 3, 4);
            btnDepositoCancelar.Name = "btnDepositoCancelar";
            btnDepositoCancelar.Size = new Size(160, 48);
            btnDepositoCancelar.TabIndex = 4;
            btnDepositoCancelar.Text = "Voltar";
            btnDepositoCancelar.UseVisualStyleBackColor = false;
            btnDepositoCancelar.Click += btnCancelar_Click;
            // 
            // btnDepositoConfirmar
            // 
            btnDepositoConfirmar.BackColor = SystemColors.MenuHighlight;
            btnDepositoConfirmar.BackgroundImageLayout = ImageLayout.Center;
            btnDepositoConfirmar.FlatAppearance.BorderColor = Color.LightSkyBlue;
            btnDepositoConfirmar.FlatStyle = FlatStyle.Flat;
            btnDepositoConfirmar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepositoConfirmar.ForeColor = Color.White;
            btnDepositoConfirmar.Location = new Point(926, 542);
            btnDepositoConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnDepositoConfirmar.Name = "btnDepositoConfirmar";
            btnDepositoConfirmar.Size = new Size(160, 48);
            btnDepositoConfirmar.TabIndex = 5;
            btnDepositoConfirmar.Text = "Confirmar";
            btnDepositoConfirmar.UseVisualStyleBackColor = false;
            btnDepositoConfirmar.Click += btnConfirmar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.teladeposito;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1765, 927);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // TelaDeposito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 921);
            Controls.Add(btnDepositoConfirmar);
            Controls.Add(btnDepositoCancelar);
            Controls.Add(digitarSaldo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaDeposito";
            Text = "Depósito";
            Load += TelaDeposito_Load;
            ((System.ComponentModel.ISupportInitialize)digitarSaldo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDepositoCancelar;
        private Button btnDepositoConfirmar;
        private PictureBox pictureBox1;
        public NumericUpDown digitarSaldo;
    }
}