namespace Moja_biblioteczka
{
    partial class przeczytane
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.przeczytaneGridView1 = new System.Windows.Forms.DataGridView();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOcena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKomentarz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.przeczytaneGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsun.ForeColor = System.Drawing.Color.Black;
            this.btnUsun.Location = new System.Drawing.Point(634, 220);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(112, 45);
            this.btnUsun.TabIndex = 1;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdytuj.ForeColor = System.Drawing.Color.Black;
            this.btnEdytuj.Location = new System.Drawing.Point(519, 220);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(109, 46);
            this.btnEdytuj.TabIndex = 2;
            this.btnEdytuj.Text = "Zapisz zmiany";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // przeczytaneGridView1
            // 
            this.przeczytaneGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.przeczytaneGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.przeczytaneGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.przeczytaneGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.przeczytaneGridView1.Location = new System.Drawing.Point(12, 12);
            this.przeczytaneGridView1.Name = "przeczytaneGridView1";
            this.przeczytaneGridView1.Size = new System.Drawing.Size(423, 335);
            this.przeczytaneGridView1.TabIndex = 3;
            this.przeczytaneGridView1.DoubleClick += new System.EventHandler(this.przeczytaneGridView1_DoubleClick);
            // 
            // txtImie
            // 
            this.txtImie.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImie.ForeColor = System.Drawing.Color.Black;
            this.txtImie.Location = new System.Drawing.Point(519, 38);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(227, 23);
            this.txtImie.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(441, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Imie";
            // 
            // txtTytul
            // 
            this.txtTytul.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTytul.ForeColor = System.Drawing.Color.Black;
            this.txtTytul.Location = new System.Drawing.Point(519, 64);
            this.txtTytul.Multiline = true;
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(227, 44);
            this.txtTytul.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(441, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tytuł";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazwisko.ForeColor = System.Drawing.Color.Black;
            this.txtNazwisko.Location = new System.Drawing.Point(519, 12);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(227, 23);
            this.txtNazwisko.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(441, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nazwisko";
            // 
            // txtOcena
            // 
            this.txtOcena.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcena.ForeColor = System.Drawing.Color.Black;
            this.txtOcena.Location = new System.Drawing.Point(519, 114);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(227, 23);
            this.txtOcena.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(441, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ocena";
            // 
            // txtKomentarz
            // 
            this.txtKomentarz.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKomentarz.ForeColor = System.Drawing.Color.Black;
            this.txtKomentarz.Location = new System.Drawing.Point(519, 143);
            this.txtKomentarz.Multiline = true;
            this.txtKomentarz.Name = "txtKomentarz";
            this.txtKomentarz.Size = new System.Drawing.Size(227, 73);
            this.txtKomentarz.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(441, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Komentarz";
            // 
            // przeczytane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 359);
            this.Controls.Add(this.txtKomentarz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOcena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.przeczytaneGridView1);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnUsun);
            this.Name = "przeczytane";
            this.Text = "przeczytane";
            this.Load += new System.EventHandler(this.przeczytane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.przeczytaneGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.DataGridView przeczytaneGridView1;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOcena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKomentarz;
        private System.Windows.Forms.Label label5;
    }
}