namespace Moja_biblioteczka
{
    partial class Dokupienia
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
            this.dgvDoKupienia = new System.Windows.Forms.DataGridView();
            this.txtNazwisko1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImie1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.IDKsiazki = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoKupienia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoKupienia
            // 
            this.dgvDoKupienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoKupienia.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoKupienia.Location = new System.Drawing.Point(12, 12);
            this.dgvDoKupienia.Name = "dgvDoKupienia";
            this.dgvDoKupienia.Size = new System.Drawing.Size(413, 329);
            this.dgvDoKupienia.TabIndex = 2;
            this.dgvDoKupienia.DoubleClick += new System.EventHandler(this.dgvDoKupienia_DoubleClick);
            // 
            // txtNazwisko1
            // 
            this.txtNazwisko1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazwisko1.ForeColor = System.Drawing.Color.Black;
            this.txtNazwisko1.Location = new System.Drawing.Point(519, 95);
            this.txtNazwisko1.Name = "txtNazwisko1";
            this.txtNazwisko1.Size = new System.Drawing.Size(227, 23);
            this.txtNazwisko1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(442, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Imie";
            // 
            // txtTytul
            // 
            this.txtTytul.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTytul.ForeColor = System.Drawing.Color.Black;
            this.txtTytul.Location = new System.Drawing.Point(519, 121);
            this.txtTytul.Multiline = true;
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(227, 81);
            this.txtTytul.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(442, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tytuł";
            // 
            // txtImie1
            // 
            this.txtImie1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImie1.ForeColor = System.Drawing.Color.Black;
            this.txtImie1.Location = new System.Drawing.Point(519, 69);
            this.txtImie1.Name = "txtImie1";
            this.txtImie1.Size = new System.Drawing.Size(227, 23);
            this.txtImie1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nazwisko";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(636, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Usuń z listy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(519, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "Kup";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.DimGray;
            this.btnDodaj.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(519, 272);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(227, 48);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // IDKsiazki
            // 
            this.IDKsiazki.AutoSize = true;
            this.IDKsiazki.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDKsiazki.ForeColor = System.Drawing.Color.White;
            this.IDKsiazki.Location = new System.Drawing.Point(439, 40);
            this.IDKsiazki.Name = "IDKsiazki";
            this.IDKsiazki.Size = new System.Drawing.Size(74, 16);
            this.IDKsiazki.TabIndex = 18;
            this.IDKsiazki.Text = "IDKsiązki";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(519, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 23);
            this.txtID.TabIndex = 19;
            // 
            // Dokupienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(758, 354);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.IDKsiazki);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtNazwisko1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImie1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvDoKupienia);
            this.Name = "Dokupienia";
            this.Text = "Dokupienia";
            this.Load += new System.EventHandler(this.Dokupienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoKupienia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDoKupienia;
        private System.Windows.Forms.TextBox txtNazwisko1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImie1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label IDKsiazki;
        private System.Windows.Forms.TextBox txtID;
    }
}