namespace Proje
{
    partial class yoneticibilgi
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.İsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sipariş = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtkasa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAsabi = new System.Windows.Forms.Label();
            this.lblPastırma = new System.Windows.Forms.Label();
            this.lblKarısık = new System.Windows.Forms.Label();
            this.lblitalyan = new System.Windows.Forms.Label();
            this.lblspesiyal = new System.Windows.Forms.Label();
            this.lblsucuk = new System.Windows.Forms.Label();
            this.btnstokGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürünler :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İsim,
            this.Sipariş,
            this.Telefon,
            this.Adres,
            this.Tutar});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 278);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1123, 276);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // İsim
            // 
            this.İsim.Text = "İsim";
            this.İsim.Width = 132;
            // 
            // Sipariş
            // 
            this.Sipariş.Text = "Sipariş";
            this.Sipariş.Width = 341;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 117;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 159;
            // 
            // Tutar
            // 
            this.Tutar.Text = "Tutar";
            this.Tutar.Width = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(948, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kasa ";
            // 
            // txtkasa
            // 
            this.txtkasa.AutoSize = true;
            this.txtkasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkasa.Location = new System.Drawing.Point(1093, 123);
            this.txtkasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtkasa.Name = "txtkasa";
            this.txtkasa.Size = new System.Drawing.Size(62, 29);
            this.txtkasa.TabIndex = 13;
            this.txtkasa.Text = "00.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1040, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "=";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(933, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAsabi
            // 
            this.lblAsabi.AutoSize = true;
            this.lblAsabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAsabi.Location = new System.Drawing.Point(104, 76);
            this.lblAsabi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsabi.Name = "lblAsabi";
            this.lblAsabi.Size = new System.Drawing.Size(217, 26);
            this.lblAsabi.TabIndex = 23;
            this.lblAsabi.Text = "Asabi Pizza              :";
            // 
            // lblPastırma
            // 
            this.lblPastırma.AutoSize = true;
            this.lblPastırma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPastırma.Location = new System.Drawing.Point(104, 103);
            this.lblPastırma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPastırma.Name = "lblPastırma";
            this.lblPastırma.Size = new System.Drawing.Size(217, 26);
            this.lblPastırma.TabIndex = 24;
            this.lblPastırma.Text = "Pastırmalı Pizza       :";
            // 
            // lblKarısık
            // 
            this.lblKarısık.AutoSize = true;
            this.lblKarısık.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarısık.Location = new System.Drawing.Point(104, 130);
            this.lblKarısık.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKarısık.Name = "lblKarısık";
            this.lblKarısık.Size = new System.Drawing.Size(213, 26);
            this.lblKarısık.TabIndex = 25;
            this.lblKarısık.Text = "Karışık pizza            :";
            // 
            // lblitalyan
            // 
            this.lblitalyan.AutoSize = true;
            this.lblitalyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblitalyan.Location = new System.Drawing.Point(104, 220);
            this.lblitalyan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblitalyan.Name = "lblitalyan";
            this.lblitalyan.Size = new System.Drawing.Size(216, 26);
            this.lblitalyan.TabIndex = 26;
            this.lblitalyan.Text = "İtalyan Usülü Pizza  :";
            // 
            // lblspesiyal
            // 
            this.lblspesiyal.AutoSize = true;
            this.lblspesiyal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblspesiyal.Location = new System.Drawing.Point(104, 164);
            this.lblspesiyal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblspesiyal.Name = "lblspesiyal";
            this.lblspesiyal.Size = new System.Drawing.Size(215, 26);
            this.lblspesiyal.TabIndex = 27;
            this.lblspesiyal.Text = "Şefin spesiyali pizza:";
            // 
            // lblsucuk
            // 
            this.lblsucuk.AutoSize = true;
            this.lblsucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsucuk.Location = new System.Drawing.Point(104, 191);
            this.lblsucuk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsucuk.Name = "lblsucuk";
            this.lblsucuk.Size = new System.Drawing.Size(216, 26);
            this.lblsucuk.TabIndex = 28;
            this.lblsucuk.Text = "Sucuklu Pizza          :";
            // 
            // btnstokGuncelle
            // 
            this.btnstokGuncelle.BackColor = System.Drawing.Color.MistyRose;
            this.btnstokGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstokGuncelle.Location = new System.Drawing.Point(858, 204);
            this.btnstokGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnstokGuncelle.Name = "btnstokGuncelle";
            this.btnstokGuncelle.Size = new System.Drawing.Size(243, 42);
            this.btnstokGuncelle.TabIndex = 29;
            this.btnstokGuncelle.Text = "Stok Güncelle";
            this.btnstokGuncelle.UseVisualStyleBackColor = false;
            this.btnstokGuncelle.Click += new System.EventHandler(this.btnstokGuncelle_Click);
            // 
            // yoneticibilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1172, 570);
            this.Controls.Add(this.btnstokGuncelle);
            this.Controls.Add(this.lblsucuk);
            this.Controls.Add(this.lblspesiyal);
            this.Controls.Add(this.lblitalyan);
            this.Controls.Add(this.lblKarısık);
            this.Controls.Add(this.lblPastırma);
            this.Controls.Add(this.lblAsabi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "yoneticibilgi";
            this.Text = "yoneticibilgi";
            this.Load += new System.EventHandler(this.yoneticibilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader İsim;
        private System.Windows.Forms.ColumnHeader Sipariş;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label txtkasa;
        private System.Windows.Forms.Label lblAsabi;
        private System.Windows.Forms.Label lblPastırma;
        private System.Windows.Forms.Label lblKarısık;
        private System.Windows.Forms.Label lblitalyan;
        private System.Windows.Forms.Label lblspesiyal;
        private System.Windows.Forms.Label lblsucuk;
        private System.Windows.Forms.Button btnstokGuncelle;
        private System.Windows.Forms.ColumnHeader Tutar;
    }
}