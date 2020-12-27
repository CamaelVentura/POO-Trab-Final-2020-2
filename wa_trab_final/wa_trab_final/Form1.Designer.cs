namespace wa_trab_final
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_save_client = new System.Windows.Forms.Button();
            this.txt_doc_client = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mail_client = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name_client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete_client = new System.Windows.Forms.Button();
            this.btn_update_client = new System.Windows.Forms.Button();
            this.btn_insert_client = new System.Windows.Forms.Button();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_kids_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save_package = new System.Windows.Forms.Button();
            this.txt_adult_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_duration_package = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name_package = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete_package = new System.Windows.Forms.Button();
            this.btn_update_package = new System.Windows.Forms.Button();
            this.btn_insert_package = new System.Windows.Forms.Button();
            this.dgv_packages = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbox_package = new System.Windows.Forms.ComboBox();
            this.cbox_client = new System.Windows.Forms.ComboBox();
            this.txt_qtd_kids = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_save_purchased = new System.Windows.Forms.Button();
            this.txt_qtd_adults = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_delete_purchased = new System.Windows.Forms.Button();
            this.btn_update_purchased = new System.Windows.Forms.Button();
            this.btn_insert_purchased = new System.Windows.Forms.Button();
            this.dgv_purchased_packages = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packages)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchased_packages)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_save_client);
            this.tabPage1.Controls.Add(this.txt_doc_client);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_mail_client);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_name_client);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_delete_client);
            this.tabPage1.Controls.Add(this.btn_update_client);
            this.tabPage1.Controls.Add(this.btn_insert_client);
            this.tabPage1.Controls.Add(this.dgv_clients);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_save_client
            // 
            this.btn_save_client.AutoSize = true;
            this.btn_save_client.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save_client.Enabled = false;
            this.btn_save_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_client.Location = new System.Drawing.Point(10, 504);
            this.btn_save_client.Name = "btn_save_client";
            this.btn_save_client.Size = new System.Drawing.Size(106, 42);
            this.btn_save_client.TabIndex = 10;
            this.btn_save_client.Text = "Salvar";
            this.btn_save_client.UseVisualStyleBackColor = true;
            this.btn_save_client.Click += new System.EventHandler(this.btn_save_client_Click);
            // 
            // txt_doc_client
            // 
            this.txt_doc_client.Enabled = false;
            this.txt_doc_client.Location = new System.Drawing.Point(10, 458);
            this.txt_doc_client.Name = "txt_doc_client";
            this.txt_doc_client.Size = new System.Drawing.Size(492, 27);
            this.txt_doc_client.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF:";
            // 
            // txt_mail_client
            // 
            this.txt_mail_client.Enabled = false;
            this.txt_mail_client.Location = new System.Drawing.Point(10, 405);
            this.txt_mail_client.Name = "txt_mail_client";
            this.txt_mail_client.Size = new System.Drawing.Size(492, 27);
            this.txt_mail_client.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-mail:";
            // 
            // txt_name_client
            // 
            this.txt_name_client.Enabled = false;
            this.txt_name_client.Location = new System.Drawing.Point(10, 352);
            this.txt_name_client.Name = "txt_name_client";
            this.txt_name_client.Size = new System.Drawing.Size(492, 27);
            this.txt_name_client.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // btn_delete_client
            // 
            this.btn_delete_client.AutoSize = true;
            this.btn_delete_client.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_client.Location = new System.Drawing.Point(459, 248);
            this.btn_delete_client.Name = "btn_delete_client";
            this.btn_delete_client.Size = new System.Drawing.Size(150, 35);
            this.btn_delete_client.TabIndex = 3;
            this.btn_delete_client.Text = "Deletar Cliente";
            this.btn_delete_client.UseVisualStyleBackColor = true;
            this.btn_delete_client.Click += new System.EventHandler(this.btn_delete_client_Click);
            // 
            // btn_update_client
            // 
            this.btn_update_client.AutoSize = true;
            this.btn_update_client.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_client.Location = new System.Drawing.Point(252, 248);
            this.btn_update_client.Name = "btn_update_client";
            this.btn_update_client.Size = new System.Drawing.Size(145, 35);
            this.btn_update_client.TabIndex = 2;
            this.btn_update_client.Text = "Alterar Cliente";
            this.btn_update_client.UseVisualStyleBackColor = true;
            this.btn_update_client.Click += new System.EventHandler(this.btn_update_client_Click);
            // 
            // btn_insert_client
            // 
            this.btn_insert_client.AutoSize = true;
            this.btn_insert_client.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_insert_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_client.Location = new System.Drawing.Point(7, 248);
            this.btn_insert_client.Name = "btn_insert_client";
            this.btn_insert_client.Size = new System.Drawing.Size(189, 35);
            this.btn_insert_client.TabIndex = 1;
            this.btn_insert_client.Text = "Inserir novo Cliente";
            this.btn_insert_client.UseVisualStyleBackColor = true;
            this.btn_insert_client.Click += new System.EventHandler(this.btn_insert_client_Click);
            // 
            // dgv_clients
            // 
            this.dgv_clients.AllowUserToAddRows = false;
            this.dgv_clients.AllowUserToDeleteRows = false;
            this.dgv_clients.AllowUserToOrderColumns = true;
            this.dgv_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clients.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clients.Location = new System.Drawing.Point(7, 7);
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.ReadOnly = true;
            this.dgv_clients.RowTemplate.Height = 24;
            this.dgv_clients.Size = new System.Drawing.Size(1001, 235);
            this.dgv_clients.TabIndex = 0;
            this.dgv_clients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clients_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_kids_price);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btn_save_package);
            this.tabPage2.Controls.Add(this.txt_adult_price);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_duration_package);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_name_package);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_delete_package);
            this.tabPage2.Controls.Add(this.btn_update_package);
            this.tabPage2.Controls.Add(this.btn_insert_package);
            this.tabPage2.Controls.Add(this.dgv_packages);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacotes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_kids_price
            // 
            this.txt_kids_price.Enabled = false;
            this.txt_kids_price.Location = new System.Drawing.Point(11, 473);
            this.txt_kids_price.Name = "txt_kids_price";
            this.txt_kids_price.Size = new System.Drawing.Size(492, 27);
            this.txt_kids_price.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Preço para crianças (infaltil):";
            // 
            // btn_save_package
            // 
            this.btn_save_package.AutoSize = true;
            this.btn_save_package.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save_package.Enabled = false;
            this.btn_save_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_package.Location = new System.Drawing.Point(11, 510);
            this.btn_save_package.Name = "btn_save_package";
            this.btn_save_package.Size = new System.Drawing.Size(106, 42);
            this.btn_save_package.TabIndex = 23;
            this.btn_save_package.Text = "Salvar";
            this.btn_save_package.UseVisualStyleBackColor = true;
            this.btn_save_package.Click += new System.EventHandler(this.btn_save_package_Click);
            // 
            // txt_adult_price
            // 
            this.txt_adult_price.Enabled = false;
            this.txt_adult_price.Location = new System.Drawing.Point(11, 420);
            this.txt_adult_price.Name = "txt_adult_price";
            this.txt_adult_price.Size = new System.Drawing.Size(492, 27);
            this.txt_adult_price.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Preço para adultos:";
            // 
            // txt_duration_package
            // 
            this.txt_duration_package.Enabled = false;
            this.txt_duration_package.Location = new System.Drawing.Point(11, 367);
            this.txt_duration_package.Name = "txt_duration_package";
            this.txt_duration_package.Size = new System.Drawing.Size(492, 27);
            this.txt_duration_package.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dias de duração:";
            // 
            // txt_name_package
            // 
            this.txt_name_package.Enabled = false;
            this.txt_name_package.Location = new System.Drawing.Point(11, 314);
            this.txt_name_package.Name = "txt_name_package";
            this.txt_name_package.Size = new System.Drawing.Size(492, 27);
            this.txt_name_package.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nome:";
            // 
            // btn_delete_package
            // 
            this.btn_delete_package.AutoSize = true;
            this.btn_delete_package.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_package.Location = new System.Drawing.Point(459, 248);
            this.btn_delete_package.Name = "btn_delete_package";
            this.btn_delete_package.Size = new System.Drawing.Size(150, 35);
            this.btn_delete_package.TabIndex = 14;
            this.btn_delete_package.Text = "Deletar Pacote";
            this.btn_delete_package.UseVisualStyleBackColor = true;
            this.btn_delete_package.Click += new System.EventHandler(this.btn_delete_package_Click);
            // 
            // btn_update_package
            // 
            this.btn_update_package.AutoSize = true;
            this.btn_update_package.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_package.Location = new System.Drawing.Point(252, 248);
            this.btn_update_package.Name = "btn_update_package";
            this.btn_update_package.Size = new System.Drawing.Size(145, 35);
            this.btn_update_package.TabIndex = 13;
            this.btn_update_package.Text = "Alterar Pacote";
            this.btn_update_package.UseVisualStyleBackColor = true;
            this.btn_update_package.Click += new System.EventHandler(this.btn_update_package_Click);
            // 
            // btn_insert_package
            // 
            this.btn_insert_package.AutoSize = true;
            this.btn_insert_package.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_insert_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_package.Location = new System.Drawing.Point(7, 248);
            this.btn_insert_package.Name = "btn_insert_package";
            this.btn_insert_package.Size = new System.Drawing.Size(189, 35);
            this.btn_insert_package.TabIndex = 12;
            this.btn_insert_package.Text = "Inserir novo Pacote";
            this.btn_insert_package.UseVisualStyleBackColor = true;
            this.btn_insert_package.Click += new System.EventHandler(this.btn_insert_package_Click);
            // 
            // dgv_packages
            // 
            this.dgv_packages.AllowUserToAddRows = false;
            this.dgv_packages.AllowUserToDeleteRows = false;
            this.dgv_packages.AllowUserToOrderColumns = true;
            this.dgv_packages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_packages.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_packages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_packages.Location = new System.Drawing.Point(7, 7);
            this.dgv_packages.Name = "dgv_packages";
            this.dgv_packages.ReadOnly = true;
            this.dgv_packages.RowTemplate.Height = 24;
            this.dgv_packages.Size = new System.Drawing.Size(1001, 235);
            this.dgv_packages.TabIndex = 11;
            this.dgv_packages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_packages_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbox_package);
            this.tabPage3.Controls.Add(this.cbox_client);
            this.tabPage3.Controls.Add(this.txt_qtd_kids);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btn_save_purchased);
            this.tabPage3.Controls.Add(this.txt_qtd_adults);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.btn_delete_purchased);
            this.tabPage3.Controls.Add(this.btn_update_purchased);
            this.tabPage3.Controls.Add(this.btn_insert_purchased);
            this.tabPage3.Controls.Add(this.dgv_purchased_packages);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1014, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pacotes Fechados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbox_package
            // 
            this.cbox_package.Enabled = false;
            this.cbox_package.FormattingEnabled = true;
            this.cbox_package.Location = new System.Drawing.Point(11, 367);
            this.cbox_package.Name = "cbox_package";
            this.cbox_package.Size = new System.Drawing.Size(492, 28);
            this.cbox_package.TabIndex = 38;
            // 
            // cbox_client
            // 
            this.cbox_client.Enabled = false;
            this.cbox_client.FormattingEnabled = true;
            this.cbox_client.Location = new System.Drawing.Point(11, 314);
            this.cbox_client.Name = "cbox_client";
            this.cbox_client.Size = new System.Drawing.Size(492, 28);
            this.cbox_client.TabIndex = 37;
            // 
            // txt_qtd_kids
            // 
            this.txt_qtd_kids.Enabled = false;
            this.txt_qtd_kids.Location = new System.Drawing.Point(11, 473);
            this.txt_qtd_kids.Name = "txt_qtd_kids";
            this.txt_qtd_kids.Size = new System.Drawing.Size(492, 27);
            this.txt_qtd_kids.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Quantidade de crianças:";
            // 
            // btn_save_purchased
            // 
            this.btn_save_purchased.AutoSize = true;
            this.btn_save_purchased.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save_purchased.Enabled = false;
            this.btn_save_purchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_purchased.Location = new System.Drawing.Point(11, 510);
            this.btn_save_purchased.Name = "btn_save_purchased";
            this.btn_save_purchased.Size = new System.Drawing.Size(106, 42);
            this.btn_save_purchased.TabIndex = 34;
            this.btn_save_purchased.Text = "Salvar";
            this.btn_save_purchased.UseVisualStyleBackColor = true;
            this.btn_save_purchased.Click += new System.EventHandler(this.btn_save_purchased_Click);
            // 
            // txt_qtd_adults
            // 
            this.txt_qtd_adults.Enabled = false;
            this.txt_qtd_adults.Location = new System.Drawing.Point(11, 420);
            this.txt_qtd_adults.Name = "txt_qtd_adults";
            this.txt_qtd_adults.Size = new System.Drawing.Size(492, 27);
            this.txt_qtd_adults.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Quantidade de adultos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Pacote:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Cliente:";
            // 
            // btn_delete_purchased
            // 
            this.btn_delete_purchased.AutoSize = true;
            this.btn_delete_purchased.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete_purchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_purchased.Location = new System.Drawing.Point(459, 248);
            this.btn_delete_purchased.Name = "btn_delete_purchased";
            this.btn_delete_purchased.Size = new System.Drawing.Size(147, 35);
            this.btn_delete_purchased.TabIndex = 27;
            this.btn_delete_purchased.Text = "Deletar Venda";
            this.btn_delete_purchased.UseVisualStyleBackColor = true;
            this.btn_delete_purchased.Click += new System.EventHandler(this.btn_delete_purchased_Click);
            // 
            // btn_update_purchased
            // 
            this.btn_update_purchased.AutoSize = true;
            this.btn_update_purchased.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_purchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_purchased.Location = new System.Drawing.Point(252, 248);
            this.btn_update_purchased.Name = "btn_update_purchased";
            this.btn_update_purchased.Size = new System.Drawing.Size(142, 35);
            this.btn_update_purchased.TabIndex = 26;
            this.btn_update_purchased.Text = "Alterar Venda";
            this.btn_update_purchased.UseVisualStyleBackColor = true;
            this.btn_update_purchased.Click += new System.EventHandler(this.btn_update_purchased_Click);
            // 
            // btn_insert_purchased
            // 
            this.btn_insert_purchased.AutoSize = true;
            this.btn_insert_purchased.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_insert_purchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_purchased.Location = new System.Drawing.Point(7, 248);
            this.btn_insert_purchased.Name = "btn_insert_purchased";
            this.btn_insert_purchased.Size = new System.Drawing.Size(186, 35);
            this.btn_insert_purchased.TabIndex = 25;
            this.btn_insert_purchased.Text = "Inserir nova Venda";
            this.btn_insert_purchased.UseVisualStyleBackColor = true;
            this.btn_insert_purchased.Click += new System.EventHandler(this.btn_insert_purchased_Click);
            // 
            // dgv_purchased_packages
            // 
            this.dgv_purchased_packages.AllowUserToAddRows = false;
            this.dgv_purchased_packages.AllowUserToDeleteRows = false;
            this.dgv_purchased_packages.AllowUserToOrderColumns = true;
            this.dgv_purchased_packages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_purchased_packages.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_purchased_packages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_purchased_packages.Location = new System.Drawing.Point(7, 7);
            this.dgv_purchased_packages.MultiSelect = false;
            this.dgv_purchased_packages.Name = "dgv_purchased_packages";
            this.dgv_purchased_packages.ReadOnly = true;
            this.dgv_purchased_packages.RowTemplate.Height = 24;
            this.dgv_purchased_packages.Size = new System.Drawing.Size(994, 235);
            this.dgv_purchased_packages.TabIndex = 24;
            this.dgv_purchased_packages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_purchased_packages_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1047, 615);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viagem dos sonhos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packages)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchased_packages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_save_client;
        private System.Windows.Forms.TextBox txt_doc_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mail_client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete_client;
        private System.Windows.Forms.Button btn_update_client;
        private System.Windows.Forms.Button btn_insert_client;
        private System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.TextBox txt_kids_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_save_package;
        private System.Windows.Forms.TextBox txt_adult_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_duration_package;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name_package;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_delete_package;
        private System.Windows.Forms.Button btn_update_package;
        private System.Windows.Forms.Button btn_insert_package;
        private System.Windows.Forms.DataGridView dgv_packages;
        private System.Windows.Forms.TextBox txt_qtd_kids;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save_purchased;
        private System.Windows.Forms.TextBox txt_qtd_adults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_delete_purchased;
        private System.Windows.Forms.Button btn_update_purchased;
        private System.Windows.Forms.Button btn_insert_purchased;
        private System.Windows.Forms.DataGridView dgv_purchased_packages;
        private System.Windows.Forms.ComboBox cbox_package;
        private System.Windows.Forms.ComboBox cbox_client;
    }
}

