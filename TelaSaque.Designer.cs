namespace cyberbank
{
    partial class TelaSaque
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
            lblSaque = new Label();
            btnSaqueConfirmar = new Button();
            txtSaque = new NumericUpDown();
            pictureBox1 = new PictureBox();
            btnSaqueCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtSaque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSaque
            // 
            lblSaque.AutoSize = true;
            lblSaque.BackColor = Color.White;
            lblSaque.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaque.ForeColor = Color.FromArgb(64, 64, 64);
            lblSaque.Location = new Point(738, 124);
            lblSaque.Name = "lblSaque";
            lblSaque.Size = new Size(116, 47);
            lblSaque.TabIndex = 0;
            lblSaque.Text = "Saque";
            // 
            // btnSaqueConfirmar
            // 
            btnSaqueConfirmar.BackColor = SystemColors.MenuHighlight;
            btnSaqueConfirmar.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaqueConfirmar.FlatAppearance.BorderColor = Color.LightSkyBlue;
            btnSaqueConfirmar.FlatStyle = FlatStyle.Flat;
            btnSaqueConfirmar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaqueConfirmar.ForeColor = Color.White;
            btnSaqueConfirmar.Location = new Point(926, 542);
            btnSaqueConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnSaqueConfirmar.Name = "btnSaqueConfirmar";
            btnSaqueConfirmar.Size = new Size(160, 61);
            btnSaqueConfirmar.TabIndex = 3;
            btnSaqueConfirmar.Text = "Confirmar";
            btnSaqueConfirmar.UseVisualStyleBackColor = false;
            btnSaqueConfirmar.Click += btnConfirmarSaque_Click;
            // 
            // txtSaque
            // 
            txtSaque.BackColor = Color.White;
            txtSaque.DecimalPlaces = 2;
            txtSaque.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaque.Location = new Point(753, 390);
            txtSaque.Margin = new Padding(3, 4, 3, 4);
            txtSaque.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtSaque.Name = "txtSaque";
            txtSaque.Size = new Size(137, 54);
            txtSaque.TabIndex = 4;
            txtSaque.ThousandsSeparator = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.telasaque;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1765, 933);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSaqueCancelar
            // 
            btnSaqueCancelar.BackColor = SystemColors.MenuHighlight;
            btnSaqueCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaqueCancelar.FlatAppearance.BorderColor = Color.LightBlue;
            btnSaqueCancelar.FlatStyle = FlatStyle.Flat;
            btnSaqueCancelar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaqueCancelar.ForeColor = Color.White;
            btnSaqueCancelar.Location = new Point(565, 542);
            btnSaqueCancelar.Margin = new Padding(3, 4, 3, 4);
            btnSaqueCancelar.Name = "btnSaqueCancelar";
            btnSaqueCancelar.Size = new Size(160, 61);
            btnSaqueCancelar.TabIndex = 2;
            btnSaqueCancelar.Text = "Voltar";
            btnSaqueCancelar.UseVisualStyleBackColor = false;
            btnSaqueCancelar.Click += btnCancelarSaque_Click;
            // 
            // TelaSaque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 921);
            Controls.Add(txtSaque);
            Controls.Add(btnSaqueConfirmar);
            Controls.Add(btnSaqueCancelar);
            Controls.Add(lblSaque);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaSaque";
            Text = "TelaSaque";
            Load += TelaSaque_Load;
            ((System.ComponentModel.ISupportInitialize)txtSaque).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaque;
        private Button btnSaqueConfirmar;
        private NumericUpDown txtSaque;
        private PictureBox pictureBox1;
        private Button btnSaqueCancelar;
    }
}