namespace Proje
{
    partial class malzemeekleme
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
            this.lblkullanıcıadı = new System.Windows.Forms.Label();
            this.cmbpizzaboyut = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpizza = new System.Windows.Forms.Label();
            this.lblmusteri = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkullanıcıadı
            // 
            this.lblkullanıcıadı.AutoSize = true;
            this.lblkullanıcıadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanıcıadı.Location = new System.Drawing.Point(121, 92);
            this.lblkullanıcıadı.Name = "lblkullanıcıadı";
            this.lblkullanıcıadı.Size = new System.Drawing.Size(121, 22);
            this.lblkullanıcıadı.TabIndex = 1;
            this.lblkullanıcıadı.Text = "Pizza boyutu :";
            // 
            // cmbpizzaboyut
            // 
            this.cmbpizzaboyut.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbpizzaboyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbpizzaboyut.FormattingEnabled = true;
            this.cmbpizzaboyut.Items.AddRange(new object[] {
            "kucuk",
            "orta",
            "buyuk"});
            this.cmbpizzaboyut.Location = new System.Drawing.Point(266, 88);
            this.cmbpizzaboyut.Name = "cmbpizzaboyut";
            this.cmbpizzaboyut.Size = new System.Drawing.Size(121, 26);
            this.cmbpizzaboyut.TabIndex = 2;
            this.cmbpizzaboyut.Text = "kucuk";
            this.cmbpizzaboyut.SelectedIndexChanged += new System.EventHandler(this.cmbpizzaboyut_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(125, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(286, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Menu olsun (patates + icecek +6 tl)   ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(143, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sepete ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Güncel tutar :";
            // 
            // txttutar
            // 
            this.txttutar.AutoSize = true;
            this.txttutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttutar.Location = new System.Drawing.Point(274, 199);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(30, 22);
            this.txttutar.TabIndex = 7;
            this.txttutar.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(121, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pizza Türü :";
            // 
            // lblpizza
            // 
            this.lblpizza.AutoSize = true;
            this.lblpizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpizza.Location = new System.Drawing.Point(262, 50);
            this.lblpizza.Name = "lblpizza";
            this.lblpizza.Size = new System.Drawing.Size(30, 22);
            this.lblpizza.TabIndex = 9;
            this.lblpizza.Text = "00";
            // 
            // lblmusteri
            // 
            this.lblmusteri.AutoSize = true;
            this.lblmusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmusteri.Location = new System.Drawing.Point(262, 9);
            this.lblmusteri.Name = "lblmusteri";
            this.lblmusteri.Size = new System.Drawing.Size(95, 22);
            this.lblmusteri.TabIndex = 10;
            this.lblmusteri.Text = "Cengizhan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(121, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Müşteri :";
            // 
            // malzemeekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmusteri);
            this.Controls.Add(this.lblpizza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbpizzaboyut);
            this.Controls.Add(this.lblkullanıcıadı);
            this.Name = "malzemeekleme";
            this.Text = "malzemeekleme";
            this.Load += new System.EventHandler(this.malzemeekleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkullanıcıadı;
        private System.Windows.Forms.ComboBox cmbpizzaboyut;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label txttutar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblpizza;
        public System.Windows.Forms.Label lblmusteri;
        private System.Windows.Forms.Label label4;
    }
}