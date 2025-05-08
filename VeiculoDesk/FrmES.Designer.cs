namespace VeiculoDesk
{
    partial class FrmES
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
            pnlEntrada = new Panel();
            btnEstacionar = new ReaLTaiizor.Controls.AirButton();
            smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            txtNumVaga = new ReaLTaiizor.Controls.SmallTextBox();
            btnRegistrar = new ReaLTaiizor.Controls.AirButton();
            smallLabel2 = new ReaLTaiizor.Controls.SmallLabel();
            txtModelo = new ReaLTaiizor.Controls.SmallTextBox();
            LblPlaca = new ReaLTaiizor.Controls.SmallLabel();
            txtPlaca = new ReaLTaiizor.Controls.SmallTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pnlMapsVagas = new Panel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            btnVaga10 = new Button();
            btnVaga9 = new Button();
            btnVaga8 = new Button();
            btnVaga7 = new Button();
            btnVaga6 = new Button();
            btnVaga5 = new Button();
            btnVaga4 = new Button();
            btnVaga3 = new Button();
            btnVaga2 = new Button();
            btnVaga1 = new Button();
            pnlSaida = new Panel();
            btnRecibo = new ReaLTaiizor.Controls.AirButton();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            btnPagar = new ReaLTaiizor.Controls.AirButton();
            txtValor = new ReaLTaiizor.Controls.SmallTextBox();
            TxtSaidaPlaca = new ReaLTaiizor.Controls.SmallTextBox();
            smallLabel3 = new ReaLTaiizor.Controls.SmallLabel();
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            pnlEntrada.SuspendLayout();
            pnlMapsVagas.SuspendLayout();
            pnlSaida.SuspendLayout();
            airForm1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEntrada
            // 
            pnlEntrada.Controls.Add(btnEstacionar);
            pnlEntrada.Controls.Add(smallLabel1);
            pnlEntrada.Controls.Add(txtNumVaga);
            pnlEntrada.Controls.Add(btnRegistrar);
            pnlEntrada.Controls.Add(smallLabel2);
            pnlEntrada.Controls.Add(txtModelo);
            pnlEntrada.Controls.Add(LblPlaca);
            pnlEntrada.Controls.Add(txtPlaca);
            pnlEntrada.Controls.Add(bigLabel1);
            pnlEntrada.Location = new Point(12, 27);
            pnlEntrada.Name = "pnlEntrada";
            pnlEntrada.Size = new Size(245, 411);
            pnlEntrada.TabIndex = 0;
            // 
            // btnEstacionar
            // 
            btnEstacionar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnEstacionar.Font = new Font("Segoe UI", 9F);
            btnEstacionar.Image = null;
            btnEstacionar.Location = new Point(42, 358);
            btnEstacionar.Name = "btnEstacionar";
            btnEstacionar.NoRounding = false;
            btnEstacionar.Size = new Size(166, 45);
            btnEstacionar.TabIndex = 8;
            btnEstacionar.Text = "Estacionar";
            btnEstacionar.Transparent = false;
            btnEstacionar.Click += btnEstacionar_Click;
            // 
            // smallLabel1
            // 
            smallLabel1.AutoSize = true;
            smallLabel1.BackColor = Color.Transparent;
            smallLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smallLabel1.ForeColor = Color.Plum;
            smallLabel1.Location = new Point(63, 295);
            smallLabel1.Name = "smallLabel1";
            smallLabel1.Size = new Size(110, 17);
            smallLabel1.TabIndex = 7;
            smallLabel1.Text = "Numero da vaga";
            // 
            // txtNumVaga
            // 
            txtNumVaga.BackColor = Color.Transparent;
            txtNumVaga.BorderColor = Color.FromArgb(180, 180, 180);
            txtNumVaga.CustomBGColor = Color.White;
            txtNumVaga.Font = new Font("Tahoma", 11F);
            txtNumVaga.ForeColor = Color.DimGray;
            txtNumVaga.Location = new Point(63, 315);
            txtNumVaga.MaxLength = 32767;
            txtNumVaga.Multiline = false;
            txtNumVaga.Name = "txtNumVaga";
            txtNumVaga.ReadOnly = false;
            txtNumVaga.Size = new Size(114, 28);
            txtNumVaga.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtNumVaga.TabIndex = 6;
            txtNumVaga.TextAlignment = HorizontalAlignment.Left;
            txtNumVaga.UseSystemPasswordChar = false;
            txtNumVaga.TextChanged += txtNumVaga_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Control;
            btnRegistrar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnRegistrar.Font = new Font("Segoe UI", 9F);
            btnRegistrar.Image = null;
            btnRegistrar.Location = new Point(12, 199);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.NoRounding = false;
            btnRegistrar.Size = new Size(218, 45);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.Transparent = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // smallLabel2
            // 
            smallLabel2.AutoSize = true;
            smallLabel2.BackColor = Color.Transparent;
            smallLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smallLabel2.ForeColor = Color.Plum;
            smallLabel2.Location = new Point(12, 130);
            smallLabel2.Name = "smallLabel2";
            smallLabel2.Size = new Size(55, 17);
            smallLabel2.TabIndex = 4;
            smallLabel2.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.Transparent;
            txtModelo.BorderColor = Color.FromArgb(180, 180, 180);
            txtModelo.CustomBGColor = Color.White;
            txtModelo.Font = new Font("Tahoma", 11F);
            txtModelo.ForeColor = Color.DimGray;
            txtModelo.Location = new Point(12, 150);
            txtModelo.MaxLength = 32767;
            txtModelo.Multiline = false;
            txtModelo.Name = "txtModelo";
            txtModelo.ReadOnly = false;
            txtModelo.Size = new Size(218, 28);
            txtModelo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtModelo.TabIndex = 3;
            txtModelo.TextAlignment = HorizontalAlignment.Left;
            txtModelo.UseSystemPasswordChar = false;
            // 
            // LblPlaca
            // 
            LblPlaca.AutoSize = true;
            LblPlaca.BackColor = Color.Transparent;
            LblPlaca.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPlaca.ForeColor = Color.Plum;
            LblPlaca.Location = new Point(12, 67);
            LblPlaca.Name = "LblPlaca";
            LblPlaca.Size = new Size(40, 17);
            LblPlaca.TabIndex = 2;
            LblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.Transparent;
            txtPlaca.BorderColor = Color.FromArgb(180, 180, 180);
            txtPlaca.CustomBGColor = Color.White;
            txtPlaca.Font = new Font("Tahoma", 11F);
            txtPlaca.ForeColor = Color.DimGray;
            txtPlaca.Location = new Point(12, 89);
            txtPlaca.MaxLength = 32767;
            txtPlaca.Multiline = false;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.ReadOnly = false;
            txtPlaca.Size = new Size(218, 28);
            txtPlaca.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtPlaca.TabIndex = 1;
            txtPlaca.TextAlignment = HorizontalAlignment.Left;
            txtPlaca.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.Purple;
            bigLabel1.Location = new Point(63, 15);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(134, 46);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Entrada";
            // 
            // pnlMapsVagas
            // 
            pnlMapsVagas.Controls.Add(bigLabel3);
            pnlMapsVagas.Controls.Add(btnVaga10);
            pnlMapsVagas.Controls.Add(btnVaga9);
            pnlMapsVagas.Controls.Add(btnVaga8);
            pnlMapsVagas.Controls.Add(btnVaga7);
            pnlMapsVagas.Controls.Add(btnVaga6);
            pnlMapsVagas.Controls.Add(btnVaga5);
            pnlMapsVagas.Controls.Add(btnVaga4);
            pnlMapsVagas.Controls.Add(btnVaga3);
            pnlMapsVagas.Controls.Add(btnVaga2);
            pnlMapsVagas.Controls.Add(btnVaga1);
            pnlMapsVagas.Location = new Point(263, 72);
            pnlMapsVagas.Name = "pnlMapsVagas";
            pnlMapsVagas.Size = new Size(261, 213);
            pnlMapsVagas.TabIndex = 1;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Segoe UI", 15F);
            bigLabel3.ForeColor = Color.Purple;
            bigLabel3.Location = new Point(15, 22);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(226, 28);
            bigLabel3.TabIndex = 33;
            bigLabel3.Text = "Vaga de Estacionamento";
            // 
            // btnVaga10
            // 
            btnVaga10.Location = new Point(211, 139);
            btnVaga10.Name = "btnVaga10";
            btnVaga10.Size = new Size(46, 40);
            btnVaga10.TabIndex = 32;
            btnVaga10.Text = "10";
            btnVaga10.UseVisualStyleBackColor = true;
            btnVaga10.Click += btnVaga10_Click;
            // 
            // btnVaga9
            // 
            btnVaga9.Location = new Point(159, 138);
            btnVaga9.Name = "btnVaga9";
            btnVaga9.Size = new Size(46, 40);
            btnVaga9.TabIndex = 31;
            btnVaga9.Text = "09";
            btnVaga9.UseVisualStyleBackColor = true;
            btnVaga9.Click += btnVaga9_Click;
            // 
            // btnVaga8
            // 
            btnVaga8.Location = new Point(107, 138);
            btnVaga8.Name = "btnVaga8";
            btnVaga8.Size = new Size(46, 40);
            btnVaga8.TabIndex = 30;
            btnVaga8.Text = "08";
            btnVaga8.UseVisualStyleBackColor = true;
            btnVaga8.Click += btnVaga8_Click;
            // 
            // btnVaga7
            // 
            btnVaga7.Location = new Point(55, 138);
            btnVaga7.Name = "btnVaga7";
            btnVaga7.Size = new Size(46, 40);
            btnVaga7.TabIndex = 29;
            btnVaga7.Text = "07";
            btnVaga7.UseVisualStyleBackColor = true;
            btnVaga7.Click += btnVaga7_Click;
            // 
            // btnVaga6
            // 
            btnVaga6.Location = new Point(3, 139);
            btnVaga6.Name = "btnVaga6";
            btnVaga6.Size = new Size(46, 40);
            btnVaga6.TabIndex = 28;
            btnVaga6.Text = "06";
            btnVaga6.UseVisualStyleBackColor = true;
            btnVaga6.Click += btnVaga6_Click;
            // 
            // btnVaga5
            // 
            btnVaga5.Location = new Point(211, 93);
            btnVaga5.Name = "btnVaga5";
            btnVaga5.Size = new Size(46, 40);
            btnVaga5.TabIndex = 27;
            btnVaga5.Text = "05";
            btnVaga5.UseVisualStyleBackColor = true;
            btnVaga5.Click += btnVaga5_Click;
            // 
            // btnVaga4
            // 
            btnVaga4.Location = new Point(159, 92);
            btnVaga4.Name = "btnVaga4";
            btnVaga4.Size = new Size(46, 40);
            btnVaga4.TabIndex = 26;
            btnVaga4.Text = "04";
            btnVaga4.UseVisualStyleBackColor = true;
            btnVaga4.Click += btnVaga4_Click;
            // 
            // btnVaga3
            // 
            btnVaga3.Location = new Point(107, 92);
            btnVaga3.Name = "btnVaga3";
            btnVaga3.Size = new Size(46, 40);
            btnVaga3.TabIndex = 25;
            btnVaga3.Text = "03";
            btnVaga3.UseVisualStyleBackColor = true;
            btnVaga3.Click += btnVaga3_Click;
            // 
            // btnVaga2
            // 
            btnVaga2.Location = new Point(55, 92);
            btnVaga2.Name = "btnVaga2";
            btnVaga2.Size = new Size(46, 40);
            btnVaga2.TabIndex = 24;
            btnVaga2.Text = "02";
            btnVaga2.UseVisualStyleBackColor = true;
            btnVaga2.Click += btnVaga2_Click;
            // 
            // btnVaga1
            // 
            btnVaga1.Location = new Point(3, 93);
            btnVaga1.Name = "btnVaga1";
            btnVaga1.Size = new Size(46, 40);
            btnVaga1.TabIndex = 23;
            btnVaga1.Text = "01";
            btnVaga1.UseVisualStyleBackColor = true;
            btnVaga1.Click += btnVaga1_Click_1;
            // 
            // pnlSaida
            // 
            pnlSaida.Controls.Add(btnRecibo);
            pnlSaida.Controls.Add(bigLabel2);
            pnlSaida.Controls.Add(btnPagar);
            pnlSaida.Controls.Add(txtValor);
            pnlSaida.Controls.Add(TxtSaidaPlaca);
            pnlSaida.Controls.Add(smallLabel3);
            pnlSaida.Location = new Point(543, 27);
            pnlSaida.Name = "pnlSaida";
            pnlSaida.Size = new Size(245, 411);
            pnlSaida.TabIndex = 2;
            // 
            // btnRecibo
            // 
            btnRecibo.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnRecibo.Font = new Font("Segoe UI", 10F);
            btnRecibo.Image = null;
            btnRecibo.Location = new Point(14, 304);
            btnRecibo.Name = "btnRecibo";
            btnRecibo.NoRounding = false;
            btnRecibo.Size = new Size(218, 99);
            btnRecibo.TabIndex = 4;
            btnRecibo.Text = "Recibo";
            btnRecibo.Transparent = false;
            btnRecibo.Click += btnRecibo_Click;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 25F);
            bigLabel2.ForeColor = Color.Purple;
            bigLabel2.Location = new Point(76, 15);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(100, 46);
            bigLabel2.TabIndex = 5;
            bigLabel2.Text = "Saida";
            // 
            // btnPagar
            // 
            btnPagar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnPagar.Font = new Font("Segoe UI", 10F);
            btnPagar.Image = null;
            btnPagar.Location = new Point(14, 162);
            btnPagar.Name = "btnPagar";
            btnPagar.NoRounding = false;
            btnPagar.Size = new Size(218, 48);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Total a Pagar";
            btnPagar.Transparent = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.Transparent;
            txtValor.BorderColor = Color.FromArgb(180, 180, 180);
            txtValor.CustomBGColor = Color.White;
            txtValor.Font = new Font("Tahoma", 11F);
            txtValor.ForeColor = Color.DimGray;
            txtValor.Location = new Point(14, 216);
            txtValor.MaxLength = 32767;
            txtValor.Multiline = false;
            txtValor.Name = "txtValor";
            txtValor.ReadOnly = false;
            txtValor.Size = new Size(218, 28);
            txtValor.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtValor.TabIndex = 2;
            txtValor.TextAlignment = HorizontalAlignment.Left;
            txtValor.UseSystemPasswordChar = false;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // TxtSaidaPlaca
            // 
            TxtSaidaPlaca.BackColor = Color.Transparent;
            TxtSaidaPlaca.BorderColor = Color.FromArgb(180, 180, 180);
            TxtSaidaPlaca.CustomBGColor = Color.White;
            TxtSaidaPlaca.Font = new Font("Tahoma", 11F);
            TxtSaidaPlaca.ForeColor = Color.DimGray;
            TxtSaidaPlaca.Location = new Point(14, 89);
            TxtSaidaPlaca.MaxLength = 32767;
            TxtSaidaPlaca.Multiline = false;
            TxtSaidaPlaca.Name = "TxtSaidaPlaca";
            TxtSaidaPlaca.ReadOnly = false;
            TxtSaidaPlaca.Size = new Size(218, 28);
            TxtSaidaPlaca.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            TxtSaidaPlaca.TabIndex = 1;
            TxtSaidaPlaca.TextAlignment = HorizontalAlignment.Left;
            TxtSaidaPlaca.UseSystemPasswordChar = false;
            // 
            // smallLabel3
            // 
            smallLabel3.AutoSize = true;
            smallLabel3.BackColor = Color.Transparent;
            smallLabel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smallLabel3.ForeColor = Color.Plum;
            smallLabel3.Location = new Point(14, 67);
            smallLabel3.Name = "smallLabel3";
            smallLabel3.Size = new Size(40, 17);
            smallLabel3.TabIndex = 0;
            smallLabel3.Text = "Placa";
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.White;
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(pnlMapsVagas);
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
            airForm1.Size = new Size(800, 450);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            airForm1.TabIndex = 3;
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            // 
            // FrmES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlSaida);
            Controls.Add(pnlEntrada);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmES";
            Text = "FrmES";
            TransparencyKey = Color.Fuchsia;
            Load += FrmES_Load;
            pnlEntrada.ResumeLayout(false);
            pnlEntrada.PerformLayout();
            pnlMapsVagas.ResumeLayout(false);
            pnlMapsVagas.PerformLayout();
            pnlSaida.ResumeLayout(false);
            pnlSaida.PerformLayout();
            airForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEntrada;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.AirButton btnRegistrar;
        private ReaLTaiizor.Controls.SmallLabel smallLabel2;
        private ReaLTaiizor.Controls.SmallTextBox txtModelo;
        private ReaLTaiizor.Controls.SmallLabel LblPlaca;
        private ReaLTaiizor.Controls.SmallTextBox txtPlaca;
        private ReaLTaiizor.Controls.AirButton btnEstacionar;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ReaLTaiizor.Controls.SmallTextBox txtNumVaga;
        private Panel pnlMapsVagas;
        private Panel pnlSaida;
        private ReaLTaiizor.Controls.AirButton btnRecibo;
        private ReaLTaiizor.Controls.AirButton btnPagar;
        private ReaLTaiizor.Controls.SmallTextBox txtValor;
        private ReaLTaiizor.Controls.SmallTextBox TxtSaidaPlaca;
        private ReaLTaiizor.Controls.SmallLabel smallLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Forms.AirForm airForm1;
        private Button btnVaga1;
        private Button btnVaga2;
        private Button btnVaga10;
        private Button btnVaga9;
        private Button btnVaga8;
        private Button btnVaga7;
        private Button btnVaga6;
        private Button btnVaga5;
        private Button btnVaga4;
        private Button btnVaga3;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
    }
}