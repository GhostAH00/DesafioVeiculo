namespace VeiculoDesk
{
    partial class FrmHistorico
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            btnFiltrarPorData = new Button();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            lblBuscar = new ReaLTaiizor.Controls.FoxLabel();
            btnBusca = new Button();
            btnLimpar = new Button();
            txtBusca = new ReaLTaiizor.Controls.SmallTextBox();
            dgvHistorico = new DataGridView();
            ClnId = new DataGridViewTextBoxColumn();
            ClnPlaca = new DataGridViewTextBoxColumn();
            ClnModelo = new DataGridViewTextBoxColumn();
            clnHoradeEntrada = new DataGridViewTextBoxColumn();
            clnHoradeSaida = new DataGridViewTextBoxColumn();
            ClnValorPago = new DataGridViewTextBoxColumn();
            hopeDatePicker1 = new ReaLTaiizor.Controls.HopeDatePicker();
            airForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.White;
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(btnFiltrarPorData);
            airForm1.Controls.Add(bigLabel1);
            airForm1.Controls.Add(lblBuscar);
            airForm1.Controls.Add(btnBusca);
            airForm1.Controls.Add(btnLimpar);
            airForm1.Controls.Add(txtBusca);
            airForm1.Controls.Add(dgvHistorico);
            airForm1.Controls.Add(hopeDatePicker1);
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
            airForm1.Size = new Size(987, 450);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            airForm1.TabIndex = 1;
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            // 
            // btnFiltrarPorData
            // 
            btnFiltrarPorData.Location = new Point(779, 406);
            btnFiltrarPorData.Name = "btnFiltrarPorData";
            btnFiltrarPorData.Size = new Size(127, 23);
            btnFiltrarPorData.TabIndex = 13;
            btnFiltrarPorData.Text = "Filtrar";
            btnFiltrarPorData.UseVisualStyleBackColor = true;
            btnFiltrarPorData.Click += btnFiltrarPorData_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.Purple;
            bigLabel1.Location = new Point(266, 9);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(318, 46);
            bigLabel1.TabIndex = 12;
            bigLabel1.Text = "Historico de Veiculo";
            // 
            // lblBuscar
            // 
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.Plum;
            lblBuscar.Location = new Point(29, 71);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(256, 19);
            lblBuscar.TabIndex = 11;
            lblBuscar.Text = "Digite uma placa ou modelo para buscar:";
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(749, 96);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(101, 28);
            btnBusca.TabIndex = 5;
            btnBusca.Text = "Buscar";
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(856, 96);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(104, 28);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.Transparent;
            txtBusca.BorderColor = Color.FromArgb(180, 180, 180);
            txtBusca.CustomBGColor = Color.White;
            txtBusca.Font = new Font("Tahoma", 11F);
            txtBusca.ForeColor = Color.DimGray;
            txtBusca.Location = new Point(29, 96);
            txtBusca.MaxLength = 32767;
            txtBusca.Multiline = false;
            txtBusca.Name = "txtBusca";
            txtBusca.ReadOnly = false;
            txtBusca.Size = new Size(712, 28);
            txtBusca.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtBusca.TabIndex = 3;
            txtBusca.TextAlignment = HorizontalAlignment.Left;
            txtBusca.UseSystemPasswordChar = false;
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Columns.AddRange(new DataGridViewColumn[] { ClnId, ClnPlaca, ClnModelo, clnHoradeEntrada, clnHoradeSaida, ClnValorPago });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvHistorico.DefaultCellStyle = dataGridViewCellStyle5;
            dgvHistorico.Location = new Point(29, 130);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvHistorico.RowHeadersVisible = false;
            dgvHistorico.Size = new Size(672, 270);
            dgvHistorico.TabIndex = 2;
            // 
            // ClnId
            // 
            ClnId.Frozen = true;
            ClnId.HeaderText = "ID";
            ClnId.Name = "ClnId";
            ClnId.ReadOnly = true;
            ClnId.Width = 80;
            // 
            // ClnPlaca
            // 
            ClnPlaca.HeaderText = "Placa";
            ClnPlaca.Name = "ClnPlaca";
            ClnPlaca.ReadOnly = true;
            // 
            // ClnModelo
            // 
            ClnModelo.HeaderText = "Modelo";
            ClnModelo.Name = "ClnModelo";
            ClnModelo.ReadOnly = true;
            // 
            // clnHoradeEntrada
            // 
            clnHoradeEntrada.HeaderText = "Hora de Entrada";
            clnHoradeEntrada.Name = "clnHoradeEntrada";
            clnHoradeEntrada.ReadOnly = true;
            clnHoradeEntrada.Width = 130;
            // 
            // clnHoradeSaida
            // 
            clnHoradeSaida.HeaderText = "Hora de Saída";
            clnHoradeSaida.Name = "clnHoradeSaida";
            clnHoradeSaida.ReadOnly = true;
            clnHoradeSaida.Width = 130;
            // 
            // ClnValorPago
            // 
            ClnValorPago.HeaderText = "Valor Pago";
            ClnValorPago.Name = "ClnValorPago";
            ClnValorPago.ReadOnly = true;
            // 
            // hopeDatePicker1
            // 
            hopeDatePicker1.BackColor = Color.White;
            hopeDatePicker1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeDatePicker1.Date = new DateTime(2025, 5, 8, 0, 0, 0, 0);
            hopeDatePicker1.DayNames = "MTWTFSS";
            hopeDatePicker1.DaysTextColor = Color.FromArgb(96, 98, 102);
            hopeDatePicker1.DayTextColorA = Color.FromArgb(48, 49, 51);
            hopeDatePicker1.DayTextColorB = Color.FromArgb(144, 147, 153);
            hopeDatePicker1.HeaderFormat = "{0} Y - {1} M";
            hopeDatePicker1.HeaderTextColor = Color.FromArgb(48, 49, 51);
            hopeDatePicker1.HeadLineColor = Color.FromArgb(228, 231, 237);
            hopeDatePicker1.HoverColor = Color.FromArgb(235, 238, 245);
            hopeDatePicker1.Location = new Point(710, 130);
            hopeDatePicker1.Name = "hopeDatePicker1";
            hopeDatePicker1.NMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.NMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.NYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.NYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.PMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.PMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.PYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.PYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.SelectedBackColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.SelectedTextColor = Color.White;
            hopeDatePicker1.Size = new Size(250, 270);
            hopeDatePicker1.TabIndex = 1;
            hopeDatePicker1.Text = "hopeDatePicker1";
            hopeDatePicker1.ValueTextColor = Color.FromArgb(43, 133, 228);
            // 
            // FrmHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 450);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorico";
            Text = "FrmHistorico";
            TransparencyKey = Color.Fuchsia;
            Load += FrmHistorico_Load;
            airForm1.ResumeLayout(false);
            airForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.FoxLabel lblBuscar;
        private Button btnBusca;
        private Button btnLimpar;
        private ReaLTaiizor.Controls.SmallTextBox txtBusca;
        private DataGridView dgvHistorico;
        private DataGridViewTextBoxColumn ClnId;
        private DataGridViewTextBoxColumn ClnPlaca;
        private DataGridViewTextBoxColumn ClnModelo;
        private DataGridViewTextBoxColumn clnHoradeEntrada;
        private DataGridViewTextBoxColumn clnHoradeSaida;
        private DataGridViewTextBoxColumn ClnValorPago;
        private ReaLTaiizor.Controls.HopeDatePicker hopeDatePicker1;
        private Button btnFiltrarPorData;
    }
}