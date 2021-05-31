
namespace biblioteka
{
    partial class Main_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_admin));
            this.left_menu = new System.Windows.Forms.Panel();
            this.exit_but = new System.Windows.Forms.Button();
            this.users_but = new System.Windows.Forms.Button();
            this.group_but = new System.Windows.Forms.Button();
            this.inventory_but = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homepage_but = new System.Windows.Forms.Button();
            this.inventory_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.item_id_tb = new System.Windows.Forms.TextBox();
            this.item_add_but = new System.Windows.Forms.Button();
            this.item_update_but = new System.Windows.Forms.Button();
            this.item_type_cb = new System.Windows.Forms.ComboBox();
            this.item_remove_but = new System.Windows.Forms.Button();
            this.item_year_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.item_name_tb = new System.Windows.Forms.TextBox();
            this.group_panel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lecturer_days_tb = new System.Windows.Forms.TextBox();
            this.officer_days_tb = new System.Windows.Forms.TextBox();
            this.student_days_tb = new System.Windows.Forms.TextBox();
            this.group_update_but = new System.Windows.Forms.Button();
            this.lecturer_limit_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.officer_limit_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.student_limit_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.users_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.user_id_tb = new System.Windows.Forms.TextBox();
            this.user_balance_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.user_email_tb = new System.Windows.Forms.TextBox();
            this.user_add_but = new System.Windows.Forms.Button();
            this.user_update_but = new System.Windows.Forms.Button();
            this.user_group_cb = new System.Windows.Forms.ComboBox();
            this.user_delete_but = new System.Windows.Forms.Button();
            this.user_lname_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user_fname_tb = new System.Windows.Forms.TextBox();
            this.left_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.inventory_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.group_panel.SuspendLayout();
            this.users_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // left_menu
            // 
            this.left_menu.Controls.Add(this.exit_but);
            this.left_menu.Controls.Add(this.users_but);
            this.left_menu.Controls.Add(this.group_but);
            this.left_menu.Controls.Add(this.inventory_but);
            this.left_menu.Controls.Add(this.pictureBox1);
            this.left_menu.Controls.Add(this.homepage_but);
            this.left_menu.Location = new System.Drawing.Point(12, 12);
            this.left_menu.Name = "left_menu";
            this.left_menu.Size = new System.Drawing.Size(183, 652);
            this.left_menu.TabIndex = 2;
            // 
            // exit_but
            // 
            this.exit_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_but.Location = new System.Drawing.Point(11, 555);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(160, 78);
            this.exit_but.TabIndex = 5;
            this.exit_but.Text = "Çıkış";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // users_but
            // 
            this.users_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.users_but.Location = new System.Drawing.Point(11, 462);
            this.users_but.Name = "users_but";
            this.users_but.Size = new System.Drawing.Size(160, 78);
            this.users_but.TabIndex = 4;
            this.users_but.Text = "Kullanıcı Ayarları";
            this.users_but.UseVisualStyleBackColor = true;
            this.users_but.Click += new System.EventHandler(this.users_but_Click);
            // 
            // group_but
            // 
            this.group_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_but.Location = new System.Drawing.Point(11, 368);
            this.group_but.Name = "group_but";
            this.group_but.Size = new System.Drawing.Size(160, 78);
            this.group_but.TabIndex = 3;
            this.group_but.Text = "Grup Ayarları";
            this.group_but.UseVisualStyleBackColor = true;
            this.group_but.Click += new System.EventHandler(this.group_but_Click);
            // 
            // inventory_but
            // 
            this.inventory_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventory_but.Location = new System.Drawing.Point(11, 272);
            this.inventory_but.Name = "inventory_but";
            this.inventory_but.Size = new System.Drawing.Size(160, 78);
            this.inventory_but.TabIndex = 2;
            this.inventory_but.Text = "Parça  İşlemleri";
            this.inventory_but.UseVisualStyleBackColor = true;
            this.inventory_but.Click += new System.EventHandler(this.inventory_but_Click);
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
            // homepage_but
            // 
            this.homepage_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homepage_but.Location = new System.Drawing.Point(11, 178);
            this.homepage_but.Name = "homepage_but";
            this.homepage_but.Size = new System.Drawing.Size(160, 78);
            this.homepage_but.TabIndex = 1;
            this.homepage_but.Text = "Envanter İşlemleri";
            this.homepage_but.UseVisualStyleBackColor = true;
            // 
            // inventory_panel
            // 
            this.inventory_panel.Controls.Add(this.dataGridView1);
            this.inventory_panel.Controls.Add(this.label1);
            this.inventory_panel.Controls.Add(this.item_id_tb);
            this.inventory_panel.Controls.Add(this.item_add_but);
            this.inventory_panel.Controls.Add(this.item_update_but);
            this.inventory_panel.Controls.Add(this.item_type_cb);
            this.inventory_panel.Controls.Add(this.item_remove_but);
            this.inventory_panel.Controls.Add(this.item_year_tb);
            this.inventory_panel.Controls.Add(this.label11);
            this.inventory_panel.Controls.Add(this.label12);
            this.inventory_panel.Controls.Add(this.label13);
            this.inventory_panel.Controls.Add(this.item_name_tb);
            this.inventory_panel.Location = new System.Drawing.Point(213, 12);
            this.inventory_panel.Name = "inventory_panel";
            this.inventory_panel.Size = new System.Drawing.Size(804, 626);
            this.inventory_panel.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 11);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 356);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(25, 389);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(267, 34);
            this.label1.TabIndex = 43;
            this.label1.Text = "Barkod Numarası : ";
            // 
            // item_id_tb
            // 
            this.item_id_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_id_tb.Location = new System.Drawing.Point(298, 389);
            this.item_id_tb.Name = "item_id_tb";
            this.item_id_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_id_tb.Size = new System.Drawing.Size(459, 36);
            this.item_id_tb.TabIndex = 42;
            // 
            // item_add_but
            // 
            this.item_add_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_add_but.Location = new System.Drawing.Point(67, 544);
            this.item_add_but.Name = "item_add_but";
            this.item_add_but.Size = new System.Drawing.Size(203, 55);
            this.item_add_but.TabIndex = 41;
            this.item_add_but.Text = "Ekle";
            this.item_add_but.UseVisualStyleBackColor = true;
            this.item_add_but.Click += new System.EventHandler(this.item_add_but_Click);
            // 
            // item_update_but
            // 
            this.item_update_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_update_but.Location = new System.Drawing.Point(292, 544);
            this.item_update_but.Name = "item_update_but";
            this.item_update_but.Size = new System.Drawing.Size(203, 55);
            this.item_update_but.TabIndex = 40;
            this.item_update_but.Text = "Değiştir";
            this.item_update_but.UseVisualStyleBackColor = true;
            this.item_update_but.Click += new System.EventHandler(this.item_update_but_Click);
            // 
            // item_type_cb
            // 
            this.item_type_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.item_type_cb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_type_cb.FormattingEnabled = true;
            this.item_type_cb.Items.AddRange(new object[] {
            "book",
            "textbook",
            "journal",
            "dvd"});
            this.item_type_cb.Location = new System.Drawing.Point(611, 480);
            this.item_type_cb.Name = "item_type_cb";
            this.item_type_cb.Size = new System.Drawing.Size(146, 35);
            this.item_type_cb.TabIndex = 39;
            // 
            // item_remove_but
            // 
            this.item_remove_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_remove_but.Location = new System.Drawing.Point(514, 544);
            this.item_remove_but.Name = "item_remove_but";
            this.item_remove_but.Size = new System.Drawing.Size(203, 55);
            this.item_remove_but.TabIndex = 29;
            this.item_remove_but.Text = "Sil";
            this.item_remove_but.UseVisualStyleBackColor = true;
            this.item_remove_but.Click += new System.EventHandler(this.item_remove_but_Click);
            // 
            // item_year_tb
            // 
            this.item_year_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_year_tb.Location = new System.Drawing.Point(298, 480);
            this.item_year_tb.Name = "item_year_tb";
            this.item_year_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_year_tb.Size = new System.Drawing.Size(167, 36);
            this.item_year_tb.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.Location = new System.Drawing.Point(514, 480);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(91, 34);
            this.label11.TabIndex = 33;
            this.label11.Text = "Türü : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label12.Location = new System.Drawing.Point(218, 478);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(74, 34);
            this.label12.TabIndex = 32;
            this.label12.Text = "Yılı : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label13.Location = new System.Drawing.Point(119, 433);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(173, 34);
            this.label13.TabIndex = 31;
            this.label13.Text = "Parça Adı : ";
            // 
            // item_name_tb
            // 
            this.item_name_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_name_tb.Location = new System.Drawing.Point(298, 435);
            this.item_name_tb.Name = "item_name_tb";
            this.item_name_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_name_tb.Size = new System.Drawing.Size(459, 36);
            this.item_name_tb.TabIndex = 30;
            // 
            // group_panel
            // 
            this.group_panel.Controls.Add(this.label15);
            this.group_panel.Controls.Add(this.label14);
            this.group_panel.Controls.Add(this.lecturer_days_tb);
            this.group_panel.Controls.Add(this.officer_days_tb);
            this.group_panel.Controls.Add(this.student_days_tb);
            this.group_panel.Controls.Add(this.group_update_but);
            this.group_panel.Controls.Add(this.lecturer_limit_tb);
            this.group_panel.Controls.Add(this.label10);
            this.group_panel.Controls.Add(this.officer_limit_tb);
            this.group_panel.Controls.Add(this.label9);
            this.group_panel.Controls.Add(this.student_limit_tb);
            this.group_panel.Controls.Add(this.label8);
            this.group_panel.Location = new System.Drawing.Point(208, 12);
            this.group_panel.Name = "group_panel";
            this.group_panel.Size = new System.Drawing.Size(809, 626);
            this.group_panel.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label15.Location = new System.Drawing.Point(463, 153);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(159, 54);
            this.label15.TabIndex = 25;
            this.label15.Text = "Ödünç Süresi\r\n(Gün)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label14.Location = new System.Drawing.Point(297, 153);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(158, 54);
            this.label14.TabIndex = 24;
            this.label14.Text = "Ödünç Alma\r\n(Adet)\r\n";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecturer_days_tb
            // 
            this.lecturer_days_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lecturer_days_tb.Location = new System.Drawing.Point(472, 272);
            this.lecturer_days_tb.Name = "lecturer_days_tb";
            this.lecturer_days_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lecturer_days_tb.Size = new System.Drawing.Size(141, 36);
            this.lecturer_days_tb.TabIndex = 23;
            // 
            // officer_days_tb
            // 
            this.officer_days_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.officer_days_tb.Location = new System.Drawing.Point(472, 331);
            this.officer_days_tb.Name = "officer_days_tb";
            this.officer_days_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.officer_days_tb.Size = new System.Drawing.Size(141, 36);
            this.officer_days_tb.TabIndex = 22;
            // 
            // student_days_tb
            // 
            this.student_days_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.student_days_tb.Location = new System.Drawing.Point(472, 210);
            this.student_days_tb.Name = "student_days_tb";
            this.student_days_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.student_days_tb.Size = new System.Drawing.Size(141, 36);
            this.student_days_tb.TabIndex = 21;
            // 
            // group_update_but
            // 
            this.group_update_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_update_but.Location = new System.Drawing.Point(266, 391);
            this.group_update_but.Name = "group_update_but";
            this.group_update_but.Size = new System.Drawing.Size(245, 50);
            this.group_update_but.TabIndex = 6;
            this.group_update_but.Text = "Değiştir";
            this.group_update_but.UseVisualStyleBackColor = true;
            this.group_update_but.Click += new System.EventHandler(this.group_update_but_Click);
            // 
            // lecturer_limit_tb
            // 
            this.lecturer_limit_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lecturer_limit_tb.Location = new System.Drawing.Point(297, 272);
            this.lecturer_limit_tb.Name = "lecturer_limit_tb";
            this.lecturer_limit_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lecturer_limit_tb.Size = new System.Drawing.Size(141, 36);
            this.lecturer_limit_tb.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label10.Location = new System.Drawing.Point(98, 270);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(193, 34);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ö. Görevlisi : ";
            // 
            // officer_limit_tb
            // 
            this.officer_limit_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.officer_limit_tb.Location = new System.Drawing.Point(297, 331);
            this.officer_limit_tb.Name = "officer_limit_tb";
            this.officer_limit_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.officer_limit_tb.Size = new System.Drawing.Size(141, 36);
            this.officer_limit_tb.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(156, 333);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(132, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "Memur : ";
            // 
            // student_limit_tb
            // 
            this.student_limit_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.student_limit_tb.Location = new System.Drawing.Point(297, 210);
            this.student_limit_tb.Name = "student_limit_tb";
            this.student_limit_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.student_limit_tb.Size = new System.Drawing.Size(141, 36);
            this.student_limit_tb.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(142, 212);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(149, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "Öğrenci : ";
            // 
            // users_panel
            // 
            this.users_panel.Controls.Add(this.label7);
            this.users_panel.Controls.Add(this.user_id_tb);
            this.users_panel.Controls.Add(this.user_balance_tb);
            this.users_panel.Controls.Add(this.label6);
            this.users_panel.Controls.Add(this.dataGridView2);
            this.users_panel.Controls.Add(this.label2);
            this.users_panel.Controls.Add(this.user_email_tb);
            this.users_panel.Controls.Add(this.user_add_but);
            this.users_panel.Controls.Add(this.user_update_but);
            this.users_panel.Controls.Add(this.user_group_cb);
            this.users_panel.Controls.Add(this.user_delete_but);
            this.users_panel.Controls.Add(this.user_lname_tb);
            this.users_panel.Controls.Add(this.label3);
            this.users_panel.Controls.Add(this.label4);
            this.users_panel.Controls.Add(this.label5);
            this.users_panel.Controls.Add(this.user_fname_tb);
            this.users_panel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.users_panel.Location = new System.Drawing.Point(208, 12);
            this.users_panel.Name = "users_panel";
            this.users_panel.Size = new System.Drawing.Size(809, 626);
            this.users_panel.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(96, 391);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(201, 34);
            this.label7.TabIndex = 60;
            this.label7.Text = "Email adresi : ";
            // 
            // user_id_tb
            // 
            this.user_id_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_id_tb.Location = new System.Drawing.Point(303, 347);
            this.user_id_tb.Name = "user_id_tb";
            this.user_id_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user_id_tb.Size = new System.Drawing.Size(459, 36);
            this.user_id_tb.TabIndex = 59;
            // 
            // user_balance_tb
            // 
            this.user_balance_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_balance_tb.Location = new System.Drawing.Point(616, 479);
            this.user_balance_tb.Name = "user_balance_tb";
            this.user_balance_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user_balance_tb.Size = new System.Drawing.Size(146, 36);
            this.user_balance_tb.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(494, 481);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(127, 34);
            this.label6.TabIndex = 57;
            this.label6.Text = "Bakiye : ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 19);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(773, 313);
            this.dataGridView2.TabIndex = 56;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(70, 345);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(227, 34);
            this.label2.TabIndex = 55;
            this.label2.Text = "Kart Numarası : ";
            // 
            // user_email_tb
            // 
            this.user_email_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_email_tb.Location = new System.Drawing.Point(303, 391);
            this.user_email_tb.Name = "user_email_tb";
            this.user_email_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user_email_tb.Size = new System.Drawing.Size(459, 36);
            this.user_email_tb.TabIndex = 54;
            // 
            // user_add_but
            // 
            this.user_add_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_add_but.Location = new System.Drawing.Point(72, 552);
            this.user_add_but.Name = "user_add_but";
            this.user_add_but.Size = new System.Drawing.Size(203, 55);
            this.user_add_but.TabIndex = 53;
            this.user_add_but.Text = "Ekle";
            this.user_add_but.UseVisualStyleBackColor = true;
            this.user_add_but.Click += new System.EventHandler(this.user_add_but_Click);
            // 
            // user_update_but
            // 
            this.user_update_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_update_but.Location = new System.Drawing.Point(297, 552);
            this.user_update_but.Name = "user_update_but";
            this.user_update_but.Size = new System.Drawing.Size(203, 55);
            this.user_update_but.TabIndex = 52;
            this.user_update_but.Text = "Değiştir";
            this.user_update_but.UseVisualStyleBackColor = true;
            this.user_update_but.Click += new System.EventHandler(this.user_update_but_Click);
            // 
            // user_group_cb
            // 
            this.user_group_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_group_cb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_group_cb.FormattingEnabled = true;
            this.user_group_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.user_group_cb.Location = new System.Drawing.Point(303, 480);
            this.user_group_cb.Name = "user_group_cb";
            this.user_group_cb.Size = new System.Drawing.Size(185, 35);
            this.user_group_cb.TabIndex = 51;
            // 
            // user_delete_but
            // 
            this.user_delete_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_delete_but.Location = new System.Drawing.Point(519, 552);
            this.user_delete_but.Name = "user_delete_but";
            this.user_delete_but.Size = new System.Drawing.Size(203, 55);
            this.user_delete_but.TabIndex = 45;
            this.user_delete_but.Text = "Sil";
            this.user_delete_but.UseVisualStyleBackColor = true;
            this.user_delete_but.Click += new System.EventHandler(this.user_delete_but_Click);
            // 
            // user_lname_tb
            // 
            this.user_lname_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_lname_tb.Location = new System.Drawing.Point(616, 435);
            this.user_lname_tb.Name = "user_lname_tb";
            this.user_lname_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user_lname_tb.Size = new System.Drawing.Size(146, 36);
            this.user_lname_tb.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(191, 489);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(106, 34);
            this.label3.TabIndex = 49;
            this.label3.Text = "Grup : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(494, 437);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(129, 34);
            this.label4.TabIndex = 48;
            this.label4.Text = "Soyadı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(213, 444);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(84, 34);
            this.label5.TabIndex = 47;
            this.label5.Text = "Adı : ";
            // 
            // user_fname_tb
            // 
            this.user_fname_tb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_fname_tb.Location = new System.Drawing.Point(303, 435);
            this.user_fname_tb.Name = "user_fname_tb";
            this.user_fname_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user_fname_tb.Size = new System.Drawing.Size(185, 36);
            this.user_fname_tb.TabIndex = 46;
            // 
            // Main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1029, 650);
            this.Controls.Add(this.inventory_panel);
            this.Controls.Add(this.group_panel);
            this.Controls.Add(this.users_panel);
            this.Controls.Add(this.left_menu);
            this.Name = "Main_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_admin";
            this.left_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.inventory_panel.ResumeLayout(false);
            this.inventory_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.group_panel.ResumeLayout(false);
            this.group_panel.PerformLayout();
            this.users_panel.ResumeLayout(false);
            this.users_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel left_menu;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button users_but;
        private System.Windows.Forms.Button group_but;
        private System.Windows.Forms.Button inventory_but;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homepage_but;
        private System.Windows.Forms.Panel inventory_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_id_tb;
        private System.Windows.Forms.Button item_add_but;
        private System.Windows.Forms.Button item_update_but;
        private System.Windows.Forms.ComboBox item_type_cb;
        private System.Windows.Forms.Button item_remove_but;
        private System.Windows.Forms.TextBox item_year_tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox item_name_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel group_panel;
        private System.Windows.Forms.Panel users_panel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_email_tb;
        private System.Windows.Forms.Button user_add_but;
        private System.Windows.Forms.Button user_update_but;
        private System.Windows.Forms.ComboBox user_group_cb;
        private System.Windows.Forms.Button user_delete_but;
        private System.Windows.Forms.TextBox user_lname_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox user_fname_tb;
        private System.Windows.Forms.TextBox user_balance_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox user_id_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lecturer_limit_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox officer_limit_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox student_limit_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox lecturer_days_tb;
        private System.Windows.Forms.TextBox officer_days_tb;
        private System.Windows.Forms.TextBox student_days_tb;
        private System.Windows.Forms.Button group_update_but;
        private System.Windows.Forms.TextBox officer_;
        private System.Windows.Forms.TextBox dent;
        private System.Windows.Forms.TextBox officer_limit;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.TextBox lecturer_days_;
    }
}