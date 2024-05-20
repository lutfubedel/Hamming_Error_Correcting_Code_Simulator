
namespace Hamming_Error_Correcting_Code_Simülatörü
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.label_bit_sayisi = new System.Windows.Forms.Label();
            this.textBox_bit_sayisi = new System.Windows.Forms.TextBox();
            this.button_bit_sayisi = new System.Windows.Forms.Button();
            this.label_veri = new System.Windows.Forms.Label();
            this.textBox_veri = new System.Windows.Forms.TextBox();
            this.button_hamming_hesapla = new System.Windows.Forms.Button();
            this.label_info1 = new System.Windows.Forms.Label();
            this.panel_veri = new System.Windows.Forms.Panel();
            this.label_error1 = new System.Windows.Forms.Label();
            this.label_hammingCode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_result1 = new System.Windows.Forms.Panel();
            this.label_gonderilen_veri = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.panel_result2 = new System.Windows.Forms.Panel();
            this.label_mistake = new System.Windows.Forms.Label();
            this.label_sendrom = new System.Windows.Forms.Label();
            this.label_veri_new = new System.Windows.Forms.Label();
            this.label_info2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_veri_bit7 = new System.Windows.Forms.TextBox();
            this.label_error2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_veri_bit17 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit1 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit18 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit16 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit19 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit15 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit20 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit14 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit21 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit13 = new System.Windows.Forms.TextBox();
            this.button_onayla = new System.Windows.Forms.Button();
            this.textBox_veri_bit12 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit2 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit11 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit3 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit10 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit4 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit9 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit5 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit8 = new System.Windows.Forms.TextBox();
            this.textBox_veri_bit6 = new System.Windows.Forms.TextBox();
            this.button_Github = new System.Windows.Forms.Button();
            this.button_Youtube = new System.Windows.Forms.Button();
            this.panel_veri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_result1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_result2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_title.Location = new System.Drawing.Point(642, 40);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(526, 40);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Hamming Error-Correcting Code Simülatörü";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_bit_sayisi
            // 
            this.label_bit_sayisi.AutoSize = true;
            this.label_bit_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bit_sayisi.Location = new System.Drawing.Point(33, 39);
            this.label_bit_sayisi.Name = "label_bit_sayisi";
            this.label_bit_sayisi.Size = new System.Drawing.Size(125, 29);
            this.label_bit_sayisi.TabIndex = 1;
            this.label_bit_sayisi.Text = "Bit sayısı : ";
            this.label_bit_sayisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_bit_sayisi
            // 
            this.textBox_bit_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_bit_sayisi.Location = new System.Drawing.Point(164, 36);
            this.textBox_bit_sayisi.MaxLength = 2;
            this.textBox_bit_sayisi.Name = "textBox_bit_sayisi";
            this.textBox_bit_sayisi.ShortcutsEnabled = false;
            this.textBox_bit_sayisi.Size = new System.Drawing.Size(111, 34);
            this.textBox_bit_sayisi.TabIndex = 2;
            this.textBox_bit_sayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_bit_sayisi
            // 
            this.button_bit_sayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_bit_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bit_sayisi.Location = new System.Drawing.Point(294, 36);
            this.button_bit_sayisi.Name = "button_bit_sayisi";
            this.button_bit_sayisi.Size = new System.Drawing.Size(36, 33);
            this.button_bit_sayisi.TabIndex = 3;
            this.button_bit_sayisi.Text = "✔";
            this.button_bit_sayisi.UseVisualStyleBackColor = false;
            this.button_bit_sayisi.Click += new System.EventHandler(this.button_bit_sayisi_Click);
            // 
            // label_veri
            // 
            this.label_veri.AutoSize = true;
            this.label_veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_veri.Location = new System.Drawing.Point(61, 16);
            this.label_veri.Name = "label_veri";
            this.label_veri.Size = new System.Drawing.Size(74, 29);
            this.label_veri.TabIndex = 4;
            this.label_veri.Text = "Veri : ";
            this.label_veri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_veri
            // 
            this.textBox_veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_veri.Location = new System.Drawing.Point(141, 13);
            this.textBox_veri.MaxLength = 16;
            this.textBox_veri.Name = "textBox_veri";
            this.textBox_veri.ShortcutsEnabled = false;
            this.textBox_veri.Size = new System.Drawing.Size(263, 34);
            this.textBox_veri.TabIndex = 5;
            this.textBox_veri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_hamming_hesapla
            // 
            this.button_hamming_hesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_hamming_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_hamming_hesapla.Location = new System.Drawing.Point(141, 62);
            this.button_hamming_hesapla.Name = "button_hamming_hesapla";
            this.button_hamming_hesapla.Size = new System.Drawing.Size(263, 38);
            this.button_hamming_hesapla.TabIndex = 6;
            this.button_hamming_hesapla.Text = "Hamming Code Hesapla";
            this.button_hamming_hesapla.UseVisualStyleBackColor = false;
            this.button_hamming_hesapla.Click += new System.EventHandler(this.button_hamming_hesapla_Click);
            // 
            // label_info1
            // 
            this.label_info1.AutoSize = true;
            this.label_info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_info1.Location = new System.Drawing.Point(146, 204);
            this.label_info1.Name = "label_info1";
            this.label_info1.Size = new System.Drawing.Size(0, 20);
            this.label_info1.TabIndex = 12;
            // 
            // panel_veri
            // 
            this.panel_veri.Controls.Add(this.textBox_veri);
            this.panel_veri.Controls.Add(this.button_hamming_hesapla);
            this.panel_veri.Controls.Add(this.label_veri);
            this.panel_veri.Location = new System.Drawing.Point(20, 76);
            this.panel_veri.Name = "panel_veri";
            this.panel_veri.Size = new System.Drawing.Size(446, 125);
            this.panel_veri.TabIndex = 13;
            this.panel_veri.Visible = false;
            // 
            // label_error1
            // 
            this.label_error1.AutoSize = true;
            this.label_error1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_error1.ForeColor = System.Drawing.Color.Red;
            this.label_error1.Location = new System.Drawing.Point(16, 768);
            this.label_error1.Name = "label_error1";
            this.label_error1.Size = new System.Drawing.Size(47, 20);
            this.label_error1.TabIndex = 14;
            this.label_error1.Text = "Error";
            this.label_error1.Visible = false;
            // 
            // label_hammingCode
            // 
            this.label_hammingCode.AutoSize = true;
            this.label_hammingCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hammingCode.Location = new System.Drawing.Point(23, 29);
            this.label_hammingCode.Name = "label_hammingCode";
            this.label_hammingCode.Size = new System.Drawing.Size(159, 25);
            this.label_hammingCode.TabIndex = 15;
            this.label_hammingCode.Text = "Hamming Code :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.panel_result1);
            this.groupBox1.Controls.Add(this.label_bit_sayisi);
            this.groupBox1.Controls.Add(this.button_bit_sayisi);
            this.groupBox1.Controls.Add(this.label_error1);
            this.groupBox1.Controls.Add(this.textBox_bit_sayisi);
            this.groupBox1.Controls.Add(this.panel_veri);
            this.groupBox1.Controls.Add(this.label_info1);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 827);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // panel_result1
            // 
            this.panel_result1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_result1.Controls.Add(this.label_hammingCode);
            this.panel_result1.Controls.Add(this.label_gonderilen_veri);
            this.panel_result1.Location = new System.Drawing.Point(20, 614);
            this.panel_result1.Name = "panel_result1";
            this.panel_result1.Size = new System.Drawing.Size(473, 135);
            this.panel_result1.TabIndex = 44;
            // 
            // label_gonderilen_veri
            // 
            this.label_gonderilen_veri.AutoSize = true;
            this.label_gonderilen_veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_gonderilen_veri.Location = new System.Drawing.Point(23, 86);
            this.label_gonderilen_veri.Name = "label_gonderilen_veri";
            this.label_gonderilen_veri.Size = new System.Drawing.Size(158, 25);
            this.label_gonderilen_veri.TabIndex = 16;
            this.label_gonderilen_veri.Text = "Gönderilen Veri :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.button_reset);
            this.groupBox2.Controls.Add(this.panel_result2);
            this.groupBox2.Controls.Add(this.label_info2);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(580, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1334, 827);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_reset.Location = new System.Drawing.Point(1150, 604);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(165, 44);
            this.button_reset.TabIndex = 39;
            this.button_reset.Text = "SIFIRLA";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // panel_result2
            // 
            this.panel_result2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_result2.Controls.Add(this.label_mistake);
            this.panel_result2.Controls.Add(this.label_sendrom);
            this.panel_result2.Controls.Add(this.label_veri_new);
            this.panel_result2.Location = new System.Drawing.Point(842, 403);
            this.panel_result2.Name = "panel_result2";
            this.panel_result2.Size = new System.Drawing.Size(473, 195);
            this.panel_result2.TabIndex = 43;
            // 
            // label_mistake
            // 
            this.label_mistake.AutoSize = true;
            this.label_mistake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_mistake.Location = new System.Drawing.Point(20, 143);
            this.label_mistake.Name = "label_mistake";
            this.label_mistake.Size = new System.Drawing.Size(131, 25);
            this.label_mistake.TabIndex = 43;
            this.label_mistake.Text = "label_mistake";
            // 
            // label_sendrom
            // 
            this.label_sendrom.AutoSize = true;
            this.label_sendrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sendrom.Location = new System.Drawing.Point(20, 29);
            this.label_sendrom.Name = "label_sendrom";
            this.label_sendrom.Size = new System.Drawing.Size(140, 25);
            this.label_sendrom.TabIndex = 40;
            this.label_sendrom.Text = "label_sendrom";
            // 
            // label_veri_new
            // 
            this.label_veri_new.AutoSize = true;
            this.label_veri_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_veri_new.Location = new System.Drawing.Point(20, 86);
            this.label_veri_new.Name = "label_veri_new";
            this.label_veri_new.Size = new System.Drawing.Size(64, 25);
            this.label_veri_new.TabIndex = 42;
            this.label_veri_new.Text = "label4";
            // 
            // label_info2
            // 
            this.label_info2.AutoSize = true;
            this.label_info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_info2.Location = new System.Drawing.Point(96, 287);
            this.label_info2.Name = "label_info2";
            this.label_info2.Size = new System.Drawing.Size(0, 20);
            this.label_info2.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_veri_bit7);
            this.panel2.Controls.Add(this.label_error2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_veri_bit17);
            this.panel2.Controls.Add(this.textBox_veri_bit1);
            this.panel2.Controls.Add(this.textBox_veri_bit18);
            this.panel2.Controls.Add(this.textBox_veri_bit16);
            this.panel2.Controls.Add(this.textBox_veri_bit19);
            this.panel2.Controls.Add(this.textBox_veri_bit15);
            this.panel2.Controls.Add(this.textBox_veri_bit20);
            this.panel2.Controls.Add(this.textBox_veri_bit14);
            this.panel2.Controls.Add(this.textBox_veri_bit21);
            this.panel2.Controls.Add(this.textBox_veri_bit13);
            this.panel2.Controls.Add(this.button_onayla);
            this.panel2.Controls.Add(this.textBox_veri_bit12);
            this.panel2.Controls.Add(this.textBox_veri_bit2);
            this.panel2.Controls.Add(this.textBox_veri_bit11);
            this.panel2.Controls.Add(this.textBox_veri_bit3);
            this.panel2.Controls.Add(this.textBox_veri_bit10);
            this.panel2.Controls.Add(this.textBox_veri_bit4);
            this.panel2.Controls.Add(this.textBox_veri_bit9);
            this.panel2.Controls.Add(this.textBox_veri_bit5);
            this.panel2.Controls.Add(this.textBox_veri_bit8);
            this.panel2.Controls.Add(this.textBox_veri_bit6);
            this.panel2.Location = new System.Drawing.Point(20, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1295, 231);
            this.panel2.TabIndex = 39;
            // 
            // textBox_veri_bit7
            // 
            this.textBox_veri_bit7.Location = new System.Drawing.Point(380, 71);
            this.textBox_veri_bit7.MaxLength = 1;
            this.textBox_veri_bit7.Multiline = true;
            this.textBox_veri_bit7.Name = "textBox_veri_bit7";
            this.textBox_veri_bit7.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit7.TabIndex = 27;
            this.textBox_veri_bit7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit7.Visible = false;
            // 
            // label_error2
            // 
            this.label_error2.AutoSize = true;
            this.label_error2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_error2.ForeColor = System.Drawing.Color.Red;
            this.label_error2.Location = new System.Drawing.Point(18, 146);
            this.label_error2.Name = "label_error2";
            this.label_error2.Size = new System.Drawing.Size(47, 20);
            this.label_error2.TabIndex = 17;
            this.label_error2.Text = "Error";
            this.label_error2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen gönderilen veri üzerinden istediğiniz biti değiştiriniz.";
            // 
            // textBox_veri_bit17
            // 
            this.textBox_veri_bit17.Location = new System.Drawing.Point(980, 71);
            this.textBox_veri_bit17.MaxLength = 1;
            this.textBox_veri_bit17.Multiline = true;
            this.textBox_veri_bit17.Name = "textBox_veri_bit17";
            this.textBox_veri_bit17.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit17.TabIndex = 38;
            this.textBox_veri_bit17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit17.Visible = false;
            // 
            // textBox_veri_bit1
            // 
            this.textBox_veri_bit1.Location = new System.Drawing.Point(20, 71);
            this.textBox_veri_bit1.MaxLength = 1;
            this.textBox_veri_bit1.Multiline = true;
            this.textBox_veri_bit1.Name = "textBox_veri_bit1";
            this.textBox_veri_bit1.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit1.TabIndex = 17;
            this.textBox_veri_bit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit1.Visible = false;
            // 
            // textBox_veri_bit18
            // 
            this.textBox_veri_bit18.Location = new System.Drawing.Point(1040, 71);
            this.textBox_veri_bit18.MaxLength = 1;
            this.textBox_veri_bit18.Multiline = true;
            this.textBox_veri_bit18.Name = "textBox_veri_bit18";
            this.textBox_veri_bit18.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit18.TabIndex = 37;
            this.textBox_veri_bit18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit18.Visible = false;
            // 
            // textBox_veri_bit16
            // 
            this.textBox_veri_bit16.Location = new System.Drawing.Point(920, 71);
            this.textBox_veri_bit16.MaxLength = 1;
            this.textBox_veri_bit16.Multiline = true;
            this.textBox_veri_bit16.Name = "textBox_veri_bit16";
            this.textBox_veri_bit16.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit16.TabIndex = 18;
            this.textBox_veri_bit16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit16.Visible = false;
            // 
            // textBox_veri_bit19
            // 
            this.textBox_veri_bit19.Location = new System.Drawing.Point(1100, 71);
            this.textBox_veri_bit19.MaxLength = 1;
            this.textBox_veri_bit19.Multiline = true;
            this.textBox_veri_bit19.Name = "textBox_veri_bit19";
            this.textBox_veri_bit19.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit19.TabIndex = 36;
            this.textBox_veri_bit19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit19.Visible = false;
            // 
            // textBox_veri_bit15
            // 
            this.textBox_veri_bit15.Location = new System.Drawing.Point(860, 71);
            this.textBox_veri_bit15.MaxLength = 1;
            this.textBox_veri_bit15.Multiline = true;
            this.textBox_veri_bit15.Name = "textBox_veri_bit15";
            this.textBox_veri_bit15.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit15.TabIndex = 19;
            this.textBox_veri_bit15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit15.Visible = false;
            // 
            // textBox_veri_bit20
            // 
            this.textBox_veri_bit20.Location = new System.Drawing.Point(1160, 71);
            this.textBox_veri_bit20.MaxLength = 1;
            this.textBox_veri_bit20.Multiline = true;
            this.textBox_veri_bit20.Name = "textBox_veri_bit20";
            this.textBox_veri_bit20.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit20.TabIndex = 35;
            this.textBox_veri_bit20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit20.Visible = false;
            // 
            // textBox_veri_bit14
            // 
            this.textBox_veri_bit14.Location = new System.Drawing.Point(800, 71);
            this.textBox_veri_bit14.MaxLength = 1;
            this.textBox_veri_bit14.Multiline = true;
            this.textBox_veri_bit14.Name = "textBox_veri_bit14";
            this.textBox_veri_bit14.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit14.TabIndex = 20;
            this.textBox_veri_bit14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit14.Visible = false;
            // 
            // textBox_veri_bit21
            // 
            this.textBox_veri_bit21.Location = new System.Drawing.Point(1220, 71);
            this.textBox_veri_bit21.MaxLength = 1;
            this.textBox_veri_bit21.Multiline = true;
            this.textBox_veri_bit21.Name = "textBox_veri_bit21";
            this.textBox_veri_bit21.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit21.TabIndex = 34;
            this.textBox_veri_bit21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit21.Visible = false;
            // 
            // textBox_veri_bit13
            // 
            this.textBox_veri_bit13.Location = new System.Drawing.Point(740, 71);
            this.textBox_veri_bit13.MaxLength = 1;
            this.textBox_veri_bit13.Multiline = true;
            this.textBox_veri_bit13.Name = "textBox_veri_bit13";
            this.textBox_veri_bit13.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit13.TabIndex = 21;
            this.textBox_veri_bit13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit13.Visible = false;
            // 
            // button_onayla
            // 
            this.button_onayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_onayla.Location = new System.Drawing.Point(1100, 146);
            this.button_onayla.Name = "button_onayla";
            this.button_onayla.Size = new System.Drawing.Size(165, 44);
            this.button_onayla.TabIndex = 33;
            this.button_onayla.Text = "ONAYLA";
            this.button_onayla.UseVisualStyleBackColor = false;
            this.button_onayla.Click += new System.EventHandler(this.button_onayla_Click);
            // 
            // textBox_veri_bit12
            // 
            this.textBox_veri_bit12.Location = new System.Drawing.Point(680, 71);
            this.textBox_veri_bit12.MaxLength = 1;
            this.textBox_veri_bit12.Multiline = true;
            this.textBox_veri_bit12.Name = "textBox_veri_bit12";
            this.textBox_veri_bit12.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit12.TabIndex = 22;
            this.textBox_veri_bit12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit12.Visible = false;
            // 
            // textBox_veri_bit2
            // 
            this.textBox_veri_bit2.Location = new System.Drawing.Point(80, 71);
            this.textBox_veri_bit2.MaxLength = 1;
            this.textBox_veri_bit2.Multiline = true;
            this.textBox_veri_bit2.Name = "textBox_veri_bit2";
            this.textBox_veri_bit2.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit2.TabIndex = 32;
            this.textBox_veri_bit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit2.Visible = false;
            // 
            // textBox_veri_bit11
            // 
            this.textBox_veri_bit11.Location = new System.Drawing.Point(620, 71);
            this.textBox_veri_bit11.MaxLength = 1;
            this.textBox_veri_bit11.Multiline = true;
            this.textBox_veri_bit11.Name = "textBox_veri_bit11";
            this.textBox_veri_bit11.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit11.TabIndex = 23;
            this.textBox_veri_bit11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit11.Visible = false;
            // 
            // textBox_veri_bit3
            // 
            this.textBox_veri_bit3.Location = new System.Drawing.Point(140, 71);
            this.textBox_veri_bit3.MaxLength = 1;
            this.textBox_veri_bit3.Multiline = true;
            this.textBox_veri_bit3.Name = "textBox_veri_bit3";
            this.textBox_veri_bit3.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit3.TabIndex = 31;
            this.textBox_veri_bit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit3.Visible = false;
            // 
            // textBox_veri_bit10
            // 
            this.textBox_veri_bit10.Location = new System.Drawing.Point(560, 71);
            this.textBox_veri_bit10.MaxLength = 1;
            this.textBox_veri_bit10.Multiline = true;
            this.textBox_veri_bit10.Name = "textBox_veri_bit10";
            this.textBox_veri_bit10.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit10.TabIndex = 24;
            this.textBox_veri_bit10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit10.Visible = false;
            // 
            // textBox_veri_bit4
            // 
            this.textBox_veri_bit4.Location = new System.Drawing.Point(200, 71);
            this.textBox_veri_bit4.MaxLength = 1;
            this.textBox_veri_bit4.Multiline = true;
            this.textBox_veri_bit4.Name = "textBox_veri_bit4";
            this.textBox_veri_bit4.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit4.TabIndex = 30;
            this.textBox_veri_bit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit4.Visible = false;
            // 
            // textBox_veri_bit9
            // 
            this.textBox_veri_bit9.Location = new System.Drawing.Point(500, 71);
            this.textBox_veri_bit9.MaxLength = 1;
            this.textBox_veri_bit9.Multiline = true;
            this.textBox_veri_bit9.Name = "textBox_veri_bit9";
            this.textBox_veri_bit9.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit9.TabIndex = 25;
            this.textBox_veri_bit9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit9.Visible = false;
            // 
            // textBox_veri_bit5
            // 
            this.textBox_veri_bit5.Location = new System.Drawing.Point(260, 71);
            this.textBox_veri_bit5.MaxLength = 1;
            this.textBox_veri_bit5.Multiline = true;
            this.textBox_veri_bit5.Name = "textBox_veri_bit5";
            this.textBox_veri_bit5.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit5.TabIndex = 29;
            this.textBox_veri_bit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit5.Visible = false;
            // 
            // textBox_veri_bit8
            // 
            this.textBox_veri_bit8.Location = new System.Drawing.Point(440, 71);
            this.textBox_veri_bit8.MaxLength = 1;
            this.textBox_veri_bit8.Multiline = true;
            this.textBox_veri_bit8.Name = "textBox_veri_bit8";
            this.textBox_veri_bit8.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit8.TabIndex = 26;
            this.textBox_veri_bit8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit8.Visible = false;
            // 
            // textBox_veri_bit6
            // 
            this.textBox_veri_bit6.Location = new System.Drawing.Point(320, 71);
            this.textBox_veri_bit6.MaxLength = 1;
            this.textBox_veri_bit6.Multiline = true;
            this.textBox_veri_bit6.Name = "textBox_veri_bit6";
            this.textBox_veri_bit6.Size = new System.Drawing.Size(45, 45);
            this.textBox_veri_bit6.TabIndex = 28;
            this.textBox_veri_bit6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_veri_bit6.Visible = false;
            // 
            // button_Github
            // 
            this.button_Github.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Github.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Github.Location = new System.Drawing.Point(1749, 40);
            this.button_Github.Name = "button_Github";
            this.button_Github.Size = new System.Drawing.Size(165, 44);
            this.button_Github.TabIndex = 44;
            this.button_Github.Text = "GITHUB";
            this.button_Github.UseVisualStyleBackColor = false;
            this.button_Github.Click += new System.EventHandler(this.button_Github_Click);
            // 
            // button_Youtube
            // 
            this.button_Youtube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Youtube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Youtube.Location = new System.Drawing.Point(1536, 40);
            this.button_Youtube.Name = "button_Youtube";
            this.button_Youtube.Size = new System.Drawing.Size(165, 44);
            this.button_Youtube.TabIndex = 45;
            this.button_Youtube.Text = "YOUTUBE";
            this.button_Youtube.UseVisualStyleBackColor = false;
            this.button_Youtube.Click += new System.EventHandler(this.button_Youtube_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1939, 1055);
            this.Controls.Add(this.button_Youtube);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Github);
            this.Controls.Add(this.label_title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hamming Error-Correcting Code Simülatörü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_veri.ResumeLayout(false);
            this.panel_veri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_result1.ResumeLayout(false);
            this.panel_result1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_result2.ResumeLayout(false);
            this.panel_result2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_bit_sayisi;
        private System.Windows.Forms.TextBox textBox_bit_sayisi;
        private System.Windows.Forms.Button button_bit_sayisi;
        private System.Windows.Forms.Label label_veri;
        private System.Windows.Forms.TextBox textBox_veri;
        private System.Windows.Forms.Button button_hamming_hesapla;
        private System.Windows.Forms.Label label_info1;
        private System.Windows.Forms.Panel panel_veri;
        private System.Windows.Forms.Label label_error1;
        private System.Windows.Forms.Label label_hammingCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_gonderilen_veri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_veri_bit1;
        private System.Windows.Forms.TextBox textBox_veri_bit2;
        private System.Windows.Forms.TextBox textBox_veri_bit3;
        private System.Windows.Forms.TextBox textBox_veri_bit4;
        private System.Windows.Forms.TextBox textBox_veri_bit5;
        private System.Windows.Forms.TextBox textBox_veri_bit6;
        private System.Windows.Forms.TextBox textBox_veri_bit7;
        private System.Windows.Forms.TextBox textBox_veri_bit8;
        private System.Windows.Forms.TextBox textBox_veri_bit9;
        private System.Windows.Forms.TextBox textBox_veri_bit10;
        private System.Windows.Forms.TextBox textBox_veri_bit11;
        private System.Windows.Forms.TextBox textBox_veri_bit12;
        private System.Windows.Forms.TextBox textBox_veri_bit13;
        private System.Windows.Forms.TextBox textBox_veri_bit14;
        private System.Windows.Forms.TextBox textBox_veri_bit15;
        private System.Windows.Forms.TextBox textBox_veri_bit16;
        private System.Windows.Forms.Button button_onayla;
        private System.Windows.Forms.TextBox textBox_veri_bit17;
        private System.Windows.Forms.TextBox textBox_veri_bit18;
        private System.Windows.Forms.TextBox textBox_veri_bit19;
        private System.Windows.Forms.TextBox textBox_veri_bit20;
        private System.Windows.Forms.TextBox textBox_veri_bit21;
        private System.Windows.Forms.Label label_error2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_info2;
        private System.Windows.Forms.Label label_veri_new;
        private System.Windows.Forms.Label label_sendrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel_result2;
        private System.Windows.Forms.Panel panel_result1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_mistake;
        private System.Windows.Forms.Button button_Github;
        private System.Windows.Forms.Button button_Youtube;
    }
}

