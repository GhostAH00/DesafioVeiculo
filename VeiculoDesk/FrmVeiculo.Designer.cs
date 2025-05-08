namespace VeiculoDesk
{
    partial class FrmVeiculo
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgvVeiculo = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnPlaca = new DataGridViewTextBoxColumn();
            clnModelo = new DataGridViewTextBoxColumn();
            clnHoraEntrada = new DataGridViewTextBoxColumn();
            ClnHoraSaida = new DataGridViewTextBoxColumn();
            ClnValor = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            txtBusca = new ReaLTaiizor.Controls.SmallTextBox();
            btnLimpar = new Button();
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            btnHistórico = new Button();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            btnES = new Button();
            lblBuscar = new ReaLTaiizor.Controls.FoxLabel();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculo).BeginInit();
            airForm1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVeiculo
            // 
            dgvVeiculo.AllowUserToAddRows = false;
            dgvVeiculo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvVeiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvVeiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculo.Columns.AddRange(new DataGridViewColumn[] { clnID, clnPlaca, clnModelo, clnHoraEntrada, ClnHoraSaida, ClnValor });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvVeiculo.DefaultCellStyle = dataGridViewCellStyle8;
            dgvVeiculo.Location = new Point(12, 159);
            dgvVeiculo.Name = "dgvVeiculo";
            dgvVeiculo.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvVeiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvVeiculo.RowHeadersVisible = false;
            dgvVeiculo.Size = new Size(770, 240);
            dgvVeiculo.TabIndex = 4;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 80;
            // 
            // clnPlaca
            // 
            clnPlaca.HeaderText = "Placa";
            clnPlaca.Name = "clnPlaca";
            clnPlaca.ReadOnly = true;
            clnPlaca.Width = 80;
            // 
            // clnModelo
            // 
            clnModelo.HeaderText = "Modelo";
            clnModelo.Name = "clnModelo";
            clnModelo.ReadOnly = true;
            // 
            // clnHoraEntrada
            // 
            clnHoraEntrada.FillWeight = 150F;
            clnHoraEntrada.HeaderText = "Hora Entrada";
            clnHoraEntrada.Name = "clnHoraEntrada";
            clnHoraEntrada.ReadOnly = true;
            clnHoraEntrada.Width = 150;
            // 
            // ClnHoraSaida
            // 
            ClnHoraSaida.HeaderText = "Hora Saida";
            ClnHoraSaida.Name = "ClnHoraSaida";
            ClnHoraSaida.ReadOnly = true;
            ClnHoraSaida.Width = 150;
            // 
            // ClnValor
            // 
            ClnValor.HeaderText = "Valor";
            ClnValor.Name = "ClnValor";
            ClnValor.ReadOnly = true;
            ClnValor.Width = 150;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(594, 105);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 31);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.Transparent;
            txtBusca.BorderColor = Color.FromArgb(180, 180, 180);
            txtBusca.CustomBGColor = Color.White;
            txtBusca.Font = new Font("Tahoma", 11F);
            txtBusca.ForeColor = Color.DimGray;
            txtBusca.Location = new Point(12, 108);
            txtBusca.MaxLength = 32767;
            txtBusca.Multiline = false;
            txtBusca.Name = "txtBusca";
            txtBusca.ReadOnly = false;
            txtBusca.Size = new Size(576, 28);
            txtBusca.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtBusca.TabIndex = 8;
            txtBusca.TextAlignment = HorizontalAlignment.Left;
            txtBusca.UseSystemPasswordChar = false;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(691, 105);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(91, 31);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.White;
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(btnHistórico);
            airForm1.Controls.Add(bigLabel1);
            airForm1.Controls.Add(btnES);
            airForm1.Controls.Add(lblBuscar);
            airForm1.Controls.Add(btnLimpar);
            airForm1.Controls.Add(txtBusca);
            airForm1.Controls.Add(btnBuscar);
            airForm1.Customization = "AAAA/1paWv9ycnL/";
            airForm1.Dock = DockStyle.Fill;
            airForm1.Font = new Font("Segoe UI", 9F);
            airForm1.Image = null;
            airForm1.Location = new Point(0, 0);
            airForm1.MinimumSize = new Size(112, 35);
            airForm1.Movable = true;
            airForm1.Name = "airForm1";
            airForm1.NoRounding = false;
            airForm1.Sizable = true;
            airForm1.Size = new Size(800, 417);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            airForm1.TabIndex = 10;
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            // 
            // btnHistórico
            // 
            btnHistórico.Location = new Point(26, 27);
            btnHistórico.Name = "btnHistórico";
            btnHistórico.Size = new Size(76, 36);
            btnHistórico.TabIndex = 12;
            btnHistórico.Text = "Histórico";
            btnHistórico.UseVisualStyleBackColor = true;
            btnHistórico.Click += btnHistórico_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.Purple;
            bigLabel1.Location = new Point(120, 21);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(468, 46);
            bigLabel1.TabIndex = 5;
            bigLabel1.Text = "Lista de Veículos Estacionados";
            // 
            // btnES
            // 
            btnES.Font = new Font("Segoe UI", 10F);
            btnES.Location = new Point(626, 21);
            btnES.Name = "btnES";
            btnES.Size = new Size(143, 46);
            btnES.TabIndex = 11;
            btnES.Text = "Entrada Saida";
            btnES.UseVisualStyleBackColor = true;
            btnES.Click += btnES_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.Plum;
            lblBuscar.Location = new Point(12, 83);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(256, 19);
            lblBuscar.TabIndex = 10;
            lblBuscar.Text = "Digite uma placa ou modelo para buscar:";
            // 
            // FrmVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 417);
            Controls.Add(dgvVeiculo);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVeiculo";
            Text = "Form1";
            TransparencyKey = Color.Fuchsia;
            Load += FrmVeiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVeiculo).EndInit();
            airForm1.ResumeLayout(false);
            airForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVeiculo;
        private Button btnBuscar;
        private ReaLTaiizor.Controls.SmallTextBox txtBusca;
        private Button btnLimpar;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnPlaca;
        private DataGridViewTextBoxColumn clnModelo;
        private DataGridViewTextBoxColumn clnHoraEntrada;
        private DataGridViewTextBoxColumn ClnHoraSaida;
        private DataGridViewTextBoxColumn ClnValor;
        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.FoxLabel lblBuscar;
        private Button btnES;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Button btnHistórico;
    }
}
