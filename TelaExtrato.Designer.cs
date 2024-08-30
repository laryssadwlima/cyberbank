namespace cyberbank
{
    partial class TelaExtrato
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnExtratoVoltar = new Button();
            lblExtrato = new Label();
            dataGridView1 = new DataGridView();
            depositogrid = new DataGridViewTextBoxColumn();
            datagrid = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            saquegrid2 = new DataGridViewTextBoxColumn();
            datagrid2 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExtratoVoltar
            // 
            btnExtratoVoltar.BackColor = SystemColors.MenuHighlight;
            btnExtratoVoltar.FlatAppearance.BorderColor = Color.LightBlue;
            btnExtratoVoltar.FlatStyle = FlatStyle.Flat;
            btnExtratoVoltar.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            btnExtratoVoltar.ForeColor = Color.White;
            btnExtratoVoltar.Location = new Point(204, 728);
            btnExtratoVoltar.Margin = new Padding(3, 4, 3, 4);
            btnExtratoVoltar.Name = "btnExtratoVoltar";
            btnExtratoVoltar.Size = new Size(160, 51);
            btnExtratoVoltar.TabIndex = 1;
            btnExtratoVoltar.Text = "Voltar";
            btnExtratoVoltar.UseVisualStyleBackColor = false;
            btnExtratoVoltar.Click += btnVoltar_Click;
            // 
            // lblExtrato
            // 
            lblExtrato.AutoSize = true;
            lblExtrato.BackColor = Color.White;
            lblExtrato.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblExtrato.ForeColor = Color.FromArgb(64, 64, 64);
            lblExtrato.Location = new Point(823, 87);
            lblExtrato.Name = "lblExtrato";
            lblExtrato.Size = new Size(129, 47);
            lblExtrato.TabIndex = 2;
            lblExtrato.Text = "Extrato";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { depositogrid, datagrid });
            dataGridView1.GridColor = SystemColors.MenuBar;
            dataGridView1.Location = new Point(470, 151);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(411, 403);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // depositogrid
            // 
            depositogrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.BackColor = Color.Lime;
            depositogrid.DefaultCellStyle = dataGridViewCellStyle7;
            depositogrid.Frozen = true;
            depositogrid.HeaderText = "Depósito";
            depositogrid.MinimumWidth = 10;
            depositogrid.Name = "depositogrid";
            depositogrid.ReadOnly = true;
            depositogrid.Resizable = DataGridViewTriState.False;
            depositogrid.SortMode = DataGridViewColumnSortMode.Programmatic;
            depositogrid.Width = 150;
            // 
            // datagrid
            // 
            datagrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datagrid.Frozen = true;
            datagrid.HeaderText = "Data/Hora";
            datagrid.MinimumWidth = 10;
            datagrid.Name = "datagrid";
            datagrid.ReadOnly = true;
            datagrid.Resizable = DataGridViewTriState.False;
            datagrid.Width = 200;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { saquegrid2, datagrid2 });
            dataGridView2.Location = new Point(878, 151);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(443, 403);
            dataGridView2.TabIndex = 4;
            // 
            // saquegrid2
            // 
            dataGridViewCellStyle8.BackColor = Color.Red;
            saquegrid2.DefaultCellStyle = dataGridViewCellStyle8;
            saquegrid2.Frozen = true;
            saquegrid2.HeaderText = "Saque";
            saquegrid2.MinimumWidth = 10;
            saquegrid2.Name = "saquegrid2";
            saquegrid2.ReadOnly = true;
            saquegrid2.SortMode = DataGridViewColumnSortMode.Programmatic;
            saquegrid2.Width = 150;
            // 
            // datagrid2
            // 
            datagrid2.Frozen = true;
            datagrid2.HeaderText = "Data/Hora";
            datagrid2.MinimumWidth = 10;
            datagrid2.Name = "datagrid2";
            datagrid2.ReadOnly = true;
            datagrid2.Resizable = DataGridViewTriState.False;
            datagrid2.Width = 200;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.telaextrato;
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1765, 927);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // TelaExtrato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1747, 921);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(lblExtrato);
            Controls.Add(btnExtratoVoltar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaExtrato";
            Text = "Extrato";
            Load += TelaExtrato_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExtratoVoltar;
        private Label lblExtrato;
        private ListView listView1;
        private ColumnHeader Saldo;
        private ColumnHeader Data;
        private ColumnHeader Hora;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn depositogrid;
        private DataGridViewTextBoxColumn datagrid;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn saquegrid2;
        private DataGridViewTextBoxColumn datagrid2;
    }
}