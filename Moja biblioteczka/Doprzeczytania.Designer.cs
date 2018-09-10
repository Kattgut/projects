namespace Moja_biblioteczka
{
    partial class Doprzeczytania
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DoPrzeczytaniaGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDKsiązki = new System.Windows.Forms.Label();
            this.txtIDKsiazki = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOcena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DoPrzeczytaniaGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(81, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Przenieś do przeczytanych";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(198, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Usuń z listy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoPrzeczytaniaGridView1
            // 
            this.DoPrzeczytaniaGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DoPrzeczytaniaGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoPrzeczytaniaGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.DoPrzeczytaniaGridView1.Location = new System.Drawing.Point(334, 7);
            this.DoPrzeczytaniaGridView1.Name = "DoPrzeczytaniaGridView1";
            this.DoPrzeczytaniaGridView1.Size = new System.Drawing.Size(411, 343);
            this.DoPrzeczytaniaGridView1.TabIndex = 2;
            this.DoPrzeczytaniaGridView1.DoubleClick += new System.EventHandler(this.DoPrzeczytaniaGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazwisko.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNazwisko.Location = new System.Drawing.Point(81, 35);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(227, 23);
            this.txtNazwisko.TabIndex = 4;
            // 
            // txtTytul
            // 
            this.txtTytul.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTytul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTytul.Location = new System.Drawing.Point(81, 87);
            this.txtTytul.Multiline = true;
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(227, 44);
            this.txtTytul.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tytuł";
            // 
            // txtImie
            // 
            this.txtImie.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtImie.Location = new System.Drawing.Point(81, 61);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(227, 23);
            this.txtImie.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imie";
            // 
            // IDKsiązki
            // 
            this.IDKsiązki.AutoSize = true;
            this.IDKsiązki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDKsiązki.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IDKsiązki.Location = new System.Drawing.Point(3, 15);
            this.IDKsiązki.Name = "IDKsiązki";
            this.IDKsiązki.Size = new System.Drawing.Size(60, 13);
            this.IDKsiązki.TabIndex = 9;
            this.IDKsiązki.Text = "IDKsiązki";
            // 
            // txtIDKsiazki
            // 
            this.txtIDKsiazki.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDKsiazki.Location = new System.Drawing.Point(81, 12);
            this.txtIDKsiazki.Name = "txtIDKsiazki";
            this.txtIDKsiazki.Size = new System.Drawing.Size(227, 20);
            this.txtIDKsiazki.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ocena";
            // 
            // txtOcena
            // 
            this.txtOcena.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOcena.Location = new System.Drawing.Point(81, 137);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(227, 23);
            this.txtOcena.TabIndex = 12;
            // 
            // Doprzeczytania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(757, 362);
            this.Controls.Add(this.txtOcena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDKsiazki);
            this.Controls.Add(this.IDKsiązki);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoPrzeczytaniaGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Doprzeczytania";
            this.Text = "Doprzeczytania";
            this.Load += new System.EventHandler(this.Doprzeczytania_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoPrzeczytaniaGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DoPrzeczytaniaGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDKsiązki;
        private System.Windows.Forms.TextBox txtIDKsiazki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOcena;
    }
}