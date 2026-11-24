namespace PraktekDesktop
{
    partial class KalkulatorPengembalian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KalkulatorPengembalian));
            lblJudul = new Label();
            lblBelanja = new Label();
            lblBayar = new Label();
            lblKembalian = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button18 = new Button();
            groupBox1 = new GroupBox();
            lblKembalianHasil = new Label();
            lblDibayarHasil = new Label();
            lblTotalHasil = new Label();
            lblHasil = new Label();
            lblDibayar = new Label();
            lblTotal = new Label();
            lblStatusHasil = new Label();
            lblStatus = new Label();
            groupBox2 = new GroupBox();
            lblTotalLembar = new Label();
            lvRincian = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.Teal;
            lblJudul.Location = new Point(411, 18);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(451, 41);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "KALKULATOR PENGEMBALIAN";
            lblJudul.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblBelanja
            // 
            lblBelanja.AutoSize = true;
            lblBelanja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBelanja.Location = new Point(12, 83);
            lblBelanja.Name = "lblBelanja";
            lblBelanja.Size = new Size(180, 28);
            lblBelanja.TabIndex = 1;
            lblBelanja.Text = "Total Belanja (Rp)";
            // 
            // lblBayar
            // 
            lblBayar.AutoSize = true;
            lblBayar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBayar.Location = new Point(12, 166);
            lblBayar.Name = "lblBayar";
            lblBayar.Size = new Size(220, 28);
            lblBayar.TabIndex = 2;
            lblBayar.Text = "Uang Dibayarkan (Rp)";
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKembalian.Location = new Point(12, 253);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(167, 28);
            lblKembalian.TabIndex = 3;
            lblKembalian.Text = "Uang Kembalian";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(12, 114);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(416, 43);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(12, 197);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(416, 43);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Honeydew;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.ForeColor = SystemColors.ControlText;
            textBox3.Location = new Point(12, 284);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(416, 43);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button13
            // 
            button13.BackColor = Color.DarkTurquoise;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.ControlLightLight;
            button13.Location = new Point(736, 80);
            button13.Name = "button13";
            button13.Size = new Size(84, 160);
            button13.TabIndex = 19;
            button13.Text = "C";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click_1;
            // 
            // button14
            // 
            button14.BackColor = Color.DarkTurquoise;
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = SystemColors.ControlLightLight;
            button14.Location = new Point(736, 250);
            button14.Name = "button14";
            button14.Size = new Size(84, 161);
            button14.TabIndex = 20;
            button14.Text = "X";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click_1;
            // 
            // button15
            // 
            button15.BackColor = Color.Goldenrod;
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.ForeColor = SystemColors.ButtonHighlight;
            button15.Location = new Point(462, 431);
            button15.Name = "button15";
            button15.Size = new Size(176, 61);
            button15.TabIndex = 21;
            button15.Text = "Belanja";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Gold;
            button16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.ForeColor = SystemColors.ButtonHighlight;
            button16.Location = new Point(644, 431);
            button16.Name = "button16";
            button16.Size = new Size(176, 61);
            button16.TabIndex = 22;
            button16.Text = "Bayar";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.DarkCyan;
            button17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.ForeColor = SystemColors.ButtonHighlight;
            button17.Location = new Point(462, 499);
            button17.Name = "button17";
            button17.Size = new Size(241, 77);
            button17.TabIndex = 23;
            button17.Text = "Hitung";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(462, 80);
            button1.Name = "button1";
            button1.Size = new Size(84, 77);
            button1.TabIndex = 7;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(553, 80);
            button2.Name = "button2";
            button2.Size = new Size(84, 77);
            button2.TabIndex = 8;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(644, 80);
            button3.Name = "button3";
            button3.Size = new Size(84, 77);
            button3.TabIndex = 9;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(462, 163);
            button4.Name = "button4";
            button4.Size = new Size(84, 77);
            button4.TabIndex = 10;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(553, 163);
            button5.Name = "button5";
            button5.Size = new Size(84, 77);
            button5.TabIndex = 11;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(644, 163);
            button6.Name = "button6";
            button6.Size = new Size(84, 77);
            button6.TabIndex = 12;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(462, 250);
            button7.Name = "button7";
            button7.Size = new Size(84, 77);
            button7.TabIndex = 13;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(553, 250);
            button8.Name = "button8";
            button8.Size = new Size(84, 77);
            button8.TabIndex = 14;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(644, 250);
            button9.Name = "button9";
            button9.Size = new Size(84, 77);
            button9.TabIndex = 15;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(462, 334);
            button10.Name = "button10";
            button10.Size = new Size(84, 77);
            button10.TabIndex = 16;
            button10.Text = "00";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(553, 334);
            button11.Name = "button11";
            button11.Size = new Size(84, 77);
            button11.TabIndex = 17;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(644, 334);
            button12.Name = "button12";
            button12.Size = new Size(84, 77);
            button12.TabIndex = 18;
            button12.Text = "000";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Red;
            button18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.ForeColor = SystemColors.ControlLightLight;
            button18.Location = new Point(709, 499);
            button18.Name = "button18";
            button18.Size = new Size(111, 77);
            button18.TabIndex = 24;
            button18.Text = "RESET";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(lblKembalianHasil);
            groupBox1.Controls.Add(lblDibayarHasil);
            groupBox1.Controls.Add(lblTotalHasil);
            groupBox1.Controls.Add(lblHasil);
            groupBox1.Controls.Add(lblDibayar);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(lblStatusHasil);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 223);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMASI TRANSAKSI";
            // 
            // lblKembalianHasil
            // 
            lblKembalianHasil.AutoSize = true;
            lblKembalianHasil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKembalianHasil.Location = new Point(244, 175);
            lblKembalianHasil.Name = "lblKembalianHasil";
            lblKembalianHasil.Size = new Size(39, 23);
            lblKembalianHasil.TabIndex = 7;
            lblKembalianHasil.Text = "Rp0";
            // 
            // lblDibayarHasil
            // 
            lblDibayarHasil.AutoSize = true;
            lblDibayarHasil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDibayarHasil.Location = new Point(244, 131);
            lblDibayarHasil.Name = "lblDibayarHasil";
            lblDibayarHasil.Size = new Size(39, 23);
            lblDibayarHasil.TabIndex = 6;
            lblDibayarHasil.Text = "Rp0";
            // 
            // lblTotalHasil
            // 
            lblTotalHasil.AutoSize = true;
            lblTotalHasil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalHasil.Location = new Point(244, 90);
            lblTotalHasil.Name = "lblTotalHasil";
            lblTotalHasil.Size = new Size(39, 23);
            lblTotalHasil.TabIndex = 5;
            lblTotalHasil.Text = "Rp0";
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHasil.Location = new Point(6, 175);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(94, 23);
            lblHasil.TabIndex = 4;
            lblHasil.Text = "Kembalian:";
            // 
            // lblDibayar
            // 
            lblDibayar.AutoSize = true;
            lblDibayar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDibayar.Location = new Point(6, 131);
            lblDibayar.Name = "lblDibayar";
            lblDibayar.Size = new Size(145, 23);
            lblDibayar.TabIndex = 3;
            lblDibayar.Text = "Uang Dibayarkan:";
            lblDibayar.Click += label4_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(6, 90);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 23);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total Belanja:";
            // 
            // lblStatusHasil
            // 
            lblStatusHasil.AutoSize = true;
            lblStatusHasil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusHasil.Location = new Point(244, 50);
            lblStatusHasil.Name = "lblStatusHasil";
            lblStatusHasil.Size = new Size(166, 23);
            lblStatusHasil.TabIndex = 1;
            lblStatusHasil.Text = "Belum Ada Transaksi";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(6, 50);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(159, 23);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status Pembayaran:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotalLembar);
            groupBox2.Controls.Add(lvRincian);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(843, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 491);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rincian Pecahan Kembalian";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblTotalLembar
            // 
            lblTotalLembar.AutoSize = true;
            lblTotalLembar.Location = new Point(19, 455);
            lblTotalLembar.Name = "lblTotalLembar";
            lblTotalLembar.Size = new Size(0, 25);
            lblTotalLembar.TabIndex = 1;
            // 
            // lvRincian
            // 
            lvRincian.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvRincian.BackColor = Color.Honeydew;
            lvRincian.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvRincian.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lvRincian.ForeColor = SystemColors.ControlText;
            lvRincian.FullRowSelect = true;
            lvRincian.GridLines = true;
            lvRincian.Location = new Point(19, 40);
            lvRincian.MultiSelect = false;
            lvRincian.Name = "lvRincian";
            lvRincian.Size = new Size(355, 408);
            lvRincian.TabIndex = 0;
            lvRincian.UseCompatibleStateImageBehavior = false;
            lvRincian.View = View.Details;
            lvRincian.SelectedIndexChanged += lvRincian_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Pecahan";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Jumlah";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Subtotal";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 91;
            // 
            // KalkulatorPengembalian
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 585);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblKembalian);
            Controls.Add(lblBayar);
            Controls.Add(lblBelanja);
            Controls.Add(lblJudul);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "KalkulatorPengembalian";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelompok 1 (Nia, Desi, Lovrel) - Kalkulator Pengembalian";
            Load += KalkulatorPengembalian_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblBelanja;
        private Label lblBayar;
        private Label lblKembalian;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button18;
        private GroupBox groupBox1;
        private Label lblStatusHasil;
        private Label lblStatus;
        private Label lblDibayar;
        private Label lblTotal;
        private Label lblHasil;
        private Label lblKembalianHasil;
        private Label lblDibayarHasil;
        private Label lblTotalHasil;
        private GroupBox groupBox2;
        private ListView lvRincian;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label lblTotalLembar;
    }
}