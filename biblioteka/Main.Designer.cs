
namespace biblioteka
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.left_menu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.bakiye_but = new System.Windows.Forms.Button();
            this.return_but = new System.Windows.Forms.Button();
            this.borrow_but = new System.Windows.Forms.Button();
            this.homepage_but = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.balance_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.borrow_panel = new System.Windows.Forms.Panel();
            this.borrow_item_but = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.borrow_item_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.return_panel = new System.Windows.Forms.Panel();
            this.return_book_but = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.return_item_barcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balance_panel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.balance_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deposit_but = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.left_menu.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.borrow_panel.SuspendLayout();
            this.return_panel.SuspendLayout();
            this.balance_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // left_menu
            // 
            this.left_menu.Controls.Add(this.button4);
            this.left_menu.Controls.Add(this.bakiye_but);
            this.left_menu.Controls.Add(this.return_but);
            this.left_menu.Controls.Add(this.borrow_but);
            this.left_menu.Controls.Add(this.pictureBox1);
            this.left_menu.Controls.Add(this.homepage_but);
            this.left_menu.Location = new System.Drawing.Point(1, 1);
            this.left_menu.Name = "left_menu";
            this.left_menu.Size = new System.Drawing.Size(183, 652);
            this.left_menu.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(11, 555);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 78);
            this.button4.TabIndex = 5;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bakiye_but
            // 
            this.bakiye_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bakiye_but.Location = new System.Drawing.Point(11, 462);
            this.bakiye_but.Name = "bakiye_but";
            this.bakiye_but.Size = new System.Drawing.Size(160, 78);
            this.bakiye_but.TabIndex = 4;
            this.bakiye_but.Text = "Bakiye İşlemleri";
            this.bakiye_but.UseVisualStyleBackColor = true;
            this.bakiye_but.Click += new System.EventHandler(this.bakiye_but_Click);
            // 
            // return_but
            // 
            this.return_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.return_but.Location = new System.Drawing.Point(11, 368);
            this.return_but.Name = "return_but";
            this.return_but.Size = new System.Drawing.Size(160, 78);
            this.return_but.TabIndex = 3;
            this.return_but.Text = "İade";
            this.return_but.UseVisualStyleBackColor = true;
            this.return_but.Click += new System.EventHandler(this.return_panel_Click);
            // 
            // borrow_but
            // 
            this.borrow_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrow_but.Location = new System.Drawing.Point(11, 272);
            this.borrow_but.Name = "borrow_but";
            this.borrow_but.Size = new System.Drawing.Size(160, 78);
            this.borrow_but.TabIndex = 2;
            this.borrow_but.Text = "Ödünç / Rezerve";
            this.borrow_but.UseVisualStyleBackColor = true;
            this.borrow_but.Click += new System.EventHandler(this.borrow_but_Click);
            // 
            // homepage_but
            // 
            this.homepage_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homepage_but.Location = new System.Drawing.Point(11, 178);
            this.homepage_but.Name = "homepage_but";
            this.homepage_but.Size = new System.Drawing.Size(160, 78);
            this.homepage_but.TabIndex = 1;
            this.homepage_but.Text = "Ana Sayfa";
            this.homepage_but.UseVisualStyleBackColor = true;
            this.homepage_but.Click += new System.EventHandler(this.homepage_but_Click);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.label4);
            this.main_panel.Controls.Add(this.balance_label);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Location = new System.Drawing.Point(190, 1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(837, 637);
            this.main_panel.TabIndex = 2;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(29, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kalan Ödünç Hakkın: 10";
            // 
            // balance_label
            // 
            this.balance_label.AutoSize = true;
            this.balance_label.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balance_label.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.balance_label.Location = new System.Drawing.Point(29, 143);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(183, 34);
            this.balance_label.TabIndex = 10;
            this.balance_label.Text = "Bakiye : 10 ₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hoşgeldin, Admin";
            // 
            // borrow_panel
            // 
            this.borrow_panel.Controls.Add(this.borrow_item_but);
            this.borrow_panel.Controls.Add(this.label6);
            this.borrow_panel.Controls.Add(this.borrow_item_tb);
            this.borrow_panel.Controls.Add(this.label2);
            this.borrow_panel.Location = new System.Drawing.Point(190, 1);
            this.borrow_panel.Name = "borrow_panel";
            this.borrow_panel.Size = new System.Drawing.Size(827, 633);
            this.borrow_panel.TabIndex = 13;
            // 
            // borrow_item_but
            // 
            this.borrow_item_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrow_item_but.Location = new System.Drawing.Point(258, 318);
            this.borrow_item_but.Name = "borrow_item_but";
            this.borrow_item_but.Size = new System.Drawing.Size(340, 50);
            this.borrow_item_but.TabIndex = 17;
            this.borrow_item_but.Text = "Ödünç Al";
            this.borrow_item_but.UseVisualStyleBackColor = true;
            this.borrow_item_but.Click += new System.EventHandler(this.borrow_item_but_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(103, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(604, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ödünç almak istediğiniz parçaları okutunuz";
            // 
            // borrow_item_tb
            // 
            this.borrow_item_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrow_item_tb.Location = new System.Drawing.Point(343, 251);
            this.borrow_item_tb.Name = "borrow_item_tb";
            this.borrow_item_tb.Size = new System.Drawing.Size(364, 36);
            this.borrow_item_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(103, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Parça Barkodu: ";
            // 
            // return_panel
            // 
            this.return_panel.Controls.Add(this.return_book_but);
            this.return_panel.Controls.Add(this.label7);
            this.return_panel.Controls.Add(this.return_item_barcode);
            this.return_panel.Controls.Add(this.label8);
            this.return_panel.Location = new System.Drawing.Point(190, 1);
            this.return_panel.Name = "return_panel";
            this.return_panel.Size = new System.Drawing.Size(827, 633);
            this.return_panel.TabIndex = 13;
            // 
            // return_book_but
            // 
            this.return_book_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.return_book_but.Location = new System.Drawing.Point(249, 320);
            this.return_book_but.Name = "return_book_but";
            this.return_book_but.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.return_book_but.Size = new System.Drawing.Size(340, 50);
            this.return_book_but.TabIndex = 16;
            this.return_book_but.Text = "İade Et";
            this.return_book_but.UseVisualStyleBackColor = true;
            this.return_book_but.Click += new System.EventHandler(this.return_book_but_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(134, 197);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(573, 34);
            this.label7.TabIndex = 15;
            this.label7.Text = "İade etmek istediğiniz parçaları okutunuz";
            // 
            // return_item_barcode
            // 
            this.return_item_barcode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.return_item_barcode.Location = new System.Drawing.Point(346, 249);
            this.return_item_barcode.Name = "return_item_barcode";
            this.return_item_barcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.return_item_barcode.Size = new System.Drawing.Size(361, 36);
            this.return_item_barcode.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(110, 249);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(230, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Parça Barkodu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(273, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hoşgeldin, Admin";
            // 
            // balance_panel
            // 
            this.balance_panel.Controls.Add(this.label16);
            this.balance_panel.Controls.Add(this.balance_combobox);
            this.balance_panel.Controls.Add(this.label5);
            this.balance_panel.Controls.Add(this.label9);
            this.balance_panel.Controls.Add(this.deposit_but);
            this.balance_panel.Controls.Add(this.textBox3);
            this.balance_panel.Controls.Add(this.label10);
            this.balance_panel.Controls.Add(this.textBox2);
            this.balance_panel.Controls.Add(this.textBox1);
            this.balance_panel.Controls.Add(this.label11);
            this.balance_panel.Controls.Add(this.label12);
            this.balance_panel.Controls.Add(this.label13);
            this.balance_panel.Controls.Add(this.label14);
            this.balance_panel.Controls.Add(this.label15);
            this.balance_panel.Controls.Add(this.textBox4);
            this.balance_panel.Location = new System.Drawing.Point(190, 1);
            this.balance_panel.Name = "balance_panel";
            this.balance_panel.Size = new System.Drawing.Size(804, 626);
            this.balance_panel.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label16.Location = new System.Drawing.Point(385, 520);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(31, 34);
            this.label16.TabIndex = 28;
            this.label16.Text = "₺";
            // 
            // balance_combobox
            // 
            this.balance_combobox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balance_combobox.FormattingEnabled = true;
            this.balance_combobox.Items.AddRange(new object[] {
            "5",
            "10",
            "25"});
            this.balance_combobox.Location = new System.Drawing.Point(284, 519);
            this.balance_combobox.Name = "balance_combobox";
            this.balance_combobox.Size = new System.Drawing.Size(95, 35);
            this.balance_combobox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(284, 47);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(95, 34);
            this.label5.TabIndex = 26;
            this.label5.Text = "100 TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(14, 516);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(264, 34);
            this.label9.TabIndex = 24;
            this.label9.Text = "Yüklenecek Miktar";
            // 
            // deposit_but
            // 
            this.deposit_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deposit_but.Location = new System.Drawing.Point(493, 519);
            this.deposit_but.Name = "deposit_but";
            this.deposit_but.Size = new System.Drawing.Size(250, 55);
            this.deposit_but.TabIndex = 6;
            this.deposit_but.Text = "Bakiye Yükle";
            this.deposit_but.UseVisualStyleBackColor = true;
            this.deposit_but.Click += new System.EventHandler(this.deposit_but_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(396, 434);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(73, 36);
            this.textBox3.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label10.Location = new System.Drawing.Point(363, 432);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(27, 34);
            this.label10.TabIndex = 22;
            this.label10.Text = "/";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(597, 434);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(146, 36);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(284, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(73, 36);
            this.textBox1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.Location = new System.Drawing.Point(493, 436);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(98, 34);
            this.label11.TabIndex = 19;
            this.label11.Text = "CVC2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label12.Location = new System.Drawing.Point(141, 436);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(137, 34);
            this.label12.TabIndex = 18;
            this.label12.Text = "S.K. Tarihi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label13.Location = new System.Drawing.Point(74, 387);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(204, 34);
            this.label13.TabIndex = 17;
            this.label13.Text = "Kart Numarası";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label14.Location = new System.Drawing.Point(0, 291);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(807, 34);
            this.label14.TabIndex = 16;
            this.label14.Text = "____________________  Bakiye Yükleme  ___________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label15.Location = new System.Drawing.Point(46, 47);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(232, 34);
            this.label15.TabIndex = 15;
            this.label15.Text = "Mevcut Bakiye :";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(284, 389);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(459, 36);
            this.textBox4.TabIndex = 14;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1029, 650);
            this.Controls.Add(this.balance_panel);
            this.Controls.Add(this.return_panel);
            this.Controls.Add(this.borrow_panel);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.left_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.left_menu.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.borrow_panel.ResumeLayout(false);
            this.borrow_panel.PerformLayout();
            this.return_panel.ResumeLayout(false);
            this.return_panel.PerformLayout();
            this.balance_panel.ResumeLayout(false);
            this.balance_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel left_menu;
        private System.Windows.Forms.Button homepage_but;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bakiye_but;
        private System.Windows.Forms.Button return_but;
        private System.Windows.Forms.Button borrow_but;
        private System.Windows.Forms.Button k;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel borrow_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox borrow_item_tb;
        private System.Windows.Forms.Panel return_panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox return_item_barcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button return_book_but;
        private System.Windows.Forms.Button borrow_item_but;
        private System.Windows.Forms.Panel balance_panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deposit_but;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox balance_combobox;
        private System.Windows.Forms.Label label16;
    }
}