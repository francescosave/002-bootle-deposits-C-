namespace _002_bootle_deposits_desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bootle 1 Liter",
            "0.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bootle Over 1 liter",
            "0.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "TOTAL", System.Drawing.Color.Blue, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "0.00", System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_head_number_container = new System.Windows.Forms.Label();
            this.label_number_conatiner1L = new System.Windows.Forms.Label();
            this.label_number_conatinerOL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_head_price_container = new System.Windows.Forms.Label();
            this.txtNumber1L = new System.Windows.Forms.TextBox();
            this.txtNumberOL = new System.Windows.Forms.TextBox();
            this.txtPrice1L = new System.Windows.Forms.TextBox();
            this.txtPriceOL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bootle_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bootle_ref_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.italianToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.spanishToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // italianToolStripMenuItem
            // 
            this.italianToolStripMenuItem.Name = "italianToolStripMenuItem";
            this.italianToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.italianToolStripMenuItem.Text = "Italian";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.spanishToolStripMenuItem.Text = "Spanish";
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.germanToolStripMenuItem.Text = "German";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label_head_number_container
            // 
            this.label_head_number_container.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head_number_container.Location = new System.Drawing.Point(26, 54);
            this.label_head_number_container.Name = "label_head_number_container";
            this.label_head_number_container.Size = new System.Drawing.Size(222, 38);
            this.label_head_number_container.TabIndex = 1;
            this.label_head_number_container.Text = "CONTAINER NUMBER";
            // 
            // label_number_conatiner1L
            // 
            this.label_number_conatiner1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number_conatiner1L.Location = new System.Drawing.Point(26, 101);
            this.label_number_conatiner1L.Name = "label_number_conatiner1L";
            this.label_number_conatiner1L.Size = new System.Drawing.Size(222, 38);
            this.label_number_conatiner1L.TabIndex = 2;
            this.label_number_conatiner1L.Text = "Container number a liter";
            // 
            // label_number_conatinerOL
            // 
            this.label_number_conatinerOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number_conatinerOL.Location = new System.Drawing.Point(26, 154);
            this.label_number_conatinerOL.Name = "label_number_conatinerOL";
            this.label_number_conatinerOL.Size = new System.Drawing.Size(222, 38);
            this.label_number_conatinerOL.TabIndex = 3;
            this.label_number_conatinerOL.Text = "Container number over a liter";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Container price over a liter";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Container price a liter";
            // 
            // label_head_price_container
            // 
            this.label_head_price_container.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head_price_container.Location = new System.Drawing.Point(26, 207);
            this.label_head_price_container.Name = "label_head_price_container";
            this.label_head_price_container.Size = new System.Drawing.Size(222, 38);
            this.label_head_price_container.TabIndex = 4;
            this.label_head_price_container.Text = "CONTAINER PRICE\r\n";
            // 
            // txtNumber1L
            // 
            this.txtNumber1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1L.Location = new System.Drawing.Point(254, 98);
            this.txtNumber1L.Name = "txtNumber1L";
            this.txtNumber1L.Size = new System.Drawing.Size(104, 26);
            this.txtNumber1L.TabIndex = 8;
            this.txtNumber1L.Text = "0";
            this.txtNumber1L.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumber1L.TextChanged += new System.EventHandler(this.txtNumber1L_TextChanged);
            // 
            // txtNumberOL
            // 
            this.txtNumberOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOL.Location = new System.Drawing.Point(254, 151);
            this.txtNumberOL.Name = "txtNumberOL";
            this.txtNumberOL.Size = new System.Drawing.Size(104, 26);
            this.txtNumberOL.TabIndex = 9;
            this.txtNumberOL.Text = "0";
            this.txtNumberOL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumberOL.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPrice1L
            // 
            this.txtPrice1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice1L.Location = new System.Drawing.Point(254, 251);
            this.txtPrice1L.Name = "txtPrice1L";
            this.txtPrice1L.Size = new System.Drawing.Size(104, 26);
            this.txtPrice1L.TabIndex = 11;
            this.txtPrice1L.Text = "0.00";
            this.txtPrice1L.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice1L.TextChanged += new System.EventHandler(this.txtPrice1L_TextChanged);
            // 
            // txtPriceOL
            // 
            this.txtPriceOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceOL.Location = new System.Drawing.Point(254, 304);
            this.txtPriceOL.Name = "txtPriceOL";
            this.txtPriceOL.Size = new System.Drawing.Size(104, 26);
            this.txtPriceOL.TabIndex = 12;
            this.txtPriceOL.Text = "0.00";
            this.txtPriceOL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPriceOL.TextChanged += new System.EventHandler(this.txtPriceOL_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "PZ\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "PZ\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "€\r\n\r\n";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "€\r\n\r\n";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bootle_type,
            this.bootle_ref_price});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(12, 358);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(464, 150);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // bootle_type
            // 
            this.bootle_type.Text = "bootle_type";
            this.bootle_type.Width = 296;
            // 
            // bootle_ref_price
            // 
            this.bootle_ref_price.Text = "bootle_ref_price";
            this.bootle_ref_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bootle_ref_price.Width = 145;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 542);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriceOL);
            this.Controls.Add(this.txtPrice1L);
            this.Controls.Add(this.txtNumberOL);
            this.Controls.Add(this.txtNumber1L);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_head_price_container);
            this.Controls.Add(this.label_number_conatinerOL);
            this.Controls.Add(this.label_number_conatiner1L);
            this.Controls.Add(this.label_head_number_container);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bootle Deposits";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label_head_number_container;
        private System.Windows.Forms.Label label_number_conatiner1L;
        private System.Windows.Forms.Label label_number_conatinerOL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_head_price_container;
        private System.Windows.Forms.TextBox txtNumber1L;
        private System.Windows.Forms.TextBox txtNumberOL;
        private System.Windows.Forms.TextBox txtPrice1L;
        private System.Windows.Forms.TextBox txtPriceOL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader bootle_type;
        private System.Windows.Forms.ColumnHeader bootle_ref_price;
    }
}

