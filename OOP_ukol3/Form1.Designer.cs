namespace OOP_ukol3
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_jmeno = new System.Windows.Forms.TextBox();
            this.textBox_prijmeni = new System.Windows.Forms.TextBox();
            this.textBox_hmotnost = new System.Windows.Forms.TextBox();
            this.textBox_vyska = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vytvorit = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.info2 = new System.Windows.Forms.Button();
            this.vytvorit2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_vyska2 = new System.Windows.Forms.TextBox();
            this.textBox_hmotnost2 = new System.Windows.Forms.TextBox();
            this.textBox_prijmeni2 = new System.Windows.Forms.TextBox();
            this.textBox_jmeno2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_obvodpasu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osoba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jméno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Příjmení:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Výška:";
            // 
            // textBox_jmeno
            // 
            this.textBox_jmeno.Location = new System.Drawing.Point(86, 40);
            this.textBox_jmeno.Name = "textBox_jmeno";
            this.textBox_jmeno.Size = new System.Drawing.Size(100, 20);
            this.textBox_jmeno.TabIndex = 4;
            // 
            // textBox_prijmeni
            // 
            this.textBox_prijmeni.Location = new System.Drawing.Point(86, 66);
            this.textBox_prijmeni.Name = "textBox_prijmeni";
            this.textBox_prijmeni.Size = new System.Drawing.Size(100, 20);
            this.textBox_prijmeni.TabIndex = 5;
            // 
            // textBox_hmotnost
            // 
            this.textBox_hmotnost.Location = new System.Drawing.Point(86, 92);
            this.textBox_hmotnost.Name = "textBox_hmotnost";
            this.textBox_hmotnost.Size = new System.Drawing.Size(100, 20);
            this.textBox_hmotnost.TabIndex = 6;
            // 
            // textBox_vyska
            // 
            this.textBox_vyska.Location = new System.Drawing.Point(86, 118);
            this.textBox_vyska.Name = "textBox_vyska";
            this.textBox_vyska.Size = new System.Drawing.Size(100, 20);
            this.textBox_vyska.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hmotnost:";
            // 
            // vytvorit
            // 
            this.vytvorit.Location = new System.Drawing.Point(220, 43);
            this.vytvorit.Name = "vytvorit";
            this.vytvorit.Size = new System.Drawing.Size(75, 23);
            this.vytvorit.TabIndex = 9;
            this.vytvorit.Text = "Vytvořit";
            this.vytvorit.UseVisualStyleBackColor = true;
            this.vytvorit.Click += new System.EventHandler(this.button1_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(220, 111);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(75, 23);
            this.info.TabIndex = 10;
            this.info.Text = "Zobrazit info";
            this.info.UseVisualStyleBackColor = true;
            this.info.Visible = false;
            this.info.Click += new System.EventHandler(this.button2_Click);
            // 
            // info2
            // 
            this.info2.Location = new System.Drawing.Point(220, 257);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(75, 23);
            this.info2.TabIndex = 21;
            this.info2.Text = "Zobrazit info";
            this.info2.UseVisualStyleBackColor = true;
            this.info2.Visible = false;
            this.info2.Click += new System.EventHandler(this.button3_Click);
            // 
            // vytvorit2
            // 
            this.vytvorit2.Location = new System.Drawing.Point(220, 189);
            this.vytvorit2.Name = "vytvorit2";
            this.vytvorit2.Size = new System.Drawing.Size(75, 23);
            this.vytvorit2.TabIndex = 20;
            this.vytvorit2.Text = "Vytvořit";
            this.vytvorit2.UseVisualStyleBackColor = true;
            this.vytvorit2.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Hmotnost:";
            // 
            // textBox_vyska2
            // 
            this.textBox_vyska2.Location = new System.Drawing.Point(86, 264);
            this.textBox_vyska2.Name = "textBox_vyska2";
            this.textBox_vyska2.Size = new System.Drawing.Size(100, 20);
            this.textBox_vyska2.TabIndex = 18;
            // 
            // textBox_hmotnost2
            // 
            this.textBox_hmotnost2.Location = new System.Drawing.Point(86, 238);
            this.textBox_hmotnost2.Name = "textBox_hmotnost2";
            this.textBox_hmotnost2.Size = new System.Drawing.Size(100, 20);
            this.textBox_hmotnost2.TabIndex = 17;
            // 
            // textBox_prijmeni2
            // 
            this.textBox_prijmeni2.Location = new System.Drawing.Point(86, 212);
            this.textBox_prijmeni2.Name = "textBox_prijmeni2";
            this.textBox_prijmeni2.Size = new System.Drawing.Size(100, 20);
            this.textBox_prijmeni2.TabIndex = 16;
            // 
            // textBox_jmeno2
            // 
            this.textBox_jmeno2.Location = new System.Drawing.Point(86, 186);
            this.textBox_jmeno2.Name = "textBox_jmeno2";
            this.textBox_jmeno2.Size = new System.Drawing.Size(100, 20);
            this.textBox_jmeno2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Výška:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Příjmení:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Jméno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(15, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pacient";
            // 
            // textBox_obvodpasu
            // 
            this.textBox_obvodpasu.Location = new System.Drawing.Point(86, 290);
            this.textBox_obvodpasu.Name = "textBox_obvodpasu";
            this.textBox_obvodpasu.Size = new System.Drawing.Size(100, 20);
            this.textBox_obvodpasu.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Obvod pasu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 324);
            this.Controls.Add(this.textBox_obvodpasu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.vytvorit2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_vyska2);
            this.Controls.Add(this.textBox_hmotnost2);
            this.Controls.Add(this.textBox_prijmeni2);
            this.Controls.Add(this.textBox_jmeno2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.info);
            this.Controls.Add(this.vytvorit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_vyska);
            this.Controls.Add(this.textBox_hmotnost);
            this.Controls.Add(this.textBox_prijmeni);
            this.Controls.Add(this.textBox_jmeno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OOP Úkol 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_jmeno;
        private System.Windows.Forms.TextBox textBox_prijmeni;
        private System.Windows.Forms.TextBox textBox_hmotnost;
        private System.Windows.Forms.TextBox textBox_vyska;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button vytvorit;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button info2;
        private System.Windows.Forms.Button vytvorit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_vyska2;
        private System.Windows.Forms.TextBox textBox_hmotnost2;
        private System.Windows.Forms.TextBox textBox_prijmeni2;
        private System.Windows.Forms.TextBox textBox_jmeno2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_obvodpasu;
        private System.Windows.Forms.Label label11;
    }
}

