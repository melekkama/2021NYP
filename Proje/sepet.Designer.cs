namespace Proje
{
    partial class sepet
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
            this.txtadres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtisim = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.Label();
            this.lblToplamIcerik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(588, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres :";
            // 
            // txtadres
            // 
            this.txtadres.BackColor = System.Drawing.Color.MistyRose;
            this.txtadres.Location = new System.Drawing.Point(720, 85);
            this.txtadres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(235, 89);
            this.txtadres.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(816, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "öde";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtisim
            // 
            this.txtisim.AutoSize = true;
            this.txtisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisim.Location = new System.Drawing.Point(128, 82);
            this.txtisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(60, 29);
            this.txtisim.TabIndex = 8;
            this.txtisim.Text = "İsim";
            // 
            // txttel
            // 
            this.txttel.AutoSize = true;
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(264, 82);
            this.txttel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(97, 29);
            this.txttel.TabIndex = 10;
            this.txttel.Text = "Telefon";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 266);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(599, 141);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sipariş";
            this.columnHeader2.Width = 309;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(656, 377);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ödenecek toplam tutar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(943, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "=";
            // 
            // txttutar
            // 
            this.txttutar.AutoSize = true;
            this.txttutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttutar.Location = new System.Drawing.Point(979, 377);
            this.txttutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(62, 29);
            this.txttutar.TabIndex = 15;
            this.txttutar.Text = "00.0";
            // 
            // lblToplamIcerik
            // 
            this.lblToplamIcerik.AutoSize = true;
            this.lblToplamIcerik.Location = new System.Drawing.Point(-1, 527);
            this.lblToplamIcerik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamIcerik.Name = "lblToplamIcerik";
            this.lblToplamIcerik.Size = new System.Drawing.Size(46, 17);
            this.lblToplamIcerik.TabIndex = 16;
            this.lblToplamIcerik.Text = "label2";
            this.lblToplamIcerik.Visible = false;
            // 
            // sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblToplamIcerik);
            this.Controls.Add(this.txttutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "sepet";
            this.Text = "sepet";
            this.Load += new System.EventHandler(this.sepet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txttel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txttutar;
        private System.Windows.Forms.Label lblToplamIcerik;
        public System.Windows.Forms.Label txtisim;
    }
}