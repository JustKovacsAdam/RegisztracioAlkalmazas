namespace Feladatok
{
    partial class Form1
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.txtHobbi = new System.Windows.Forms.TextBox();
            this.txtSzulDatum = new System.Windows.Forms.TextBox();
            this.radF = new System.Windows.Forms.RadioButton();
            this.radN = new System.Windows.Forms.RadioButton();
            this.nev = new System.Windows.Forms.Label();
            this.szulDatum = new System.Windows.Forms.Label();
            this.hobbi = new System.Windows.Forms.Label();
            this.nem = new System.Windows.Forms.Label();
            this.kedvencHobbi = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radE = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Szöveges Fájl(.txt)|*.txt|Minden Fájl|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Szöveges Fájl(.txt)|*.txt|Minden Fájl|*.*";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(217, 28);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(120, 160);
            this.lista.TabIndex = 0;
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Location = new System.Drawing.Point(261, 279);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(75, 23);
            this.btnBetoltes.TabIndex = 1;
            this.btnBetoltes.Text = "Betöltés";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(180, 279);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 2;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // txtHobbi
            // 
            this.txtHobbi.Location = new System.Drawing.Point(217, 194);
            this.txtHobbi.Name = "txtHobbi";
            this.txtHobbi.Size = new System.Drawing.Size(120, 20);
            this.txtHobbi.TabIndex = 3;
            this.txtHobbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHobbi_KeyDown);
            // 
            // txtSzulDatum
            // 
            this.txtSzulDatum.Location = new System.Drawing.Point(103, 28);
            this.txtSzulDatum.Name = "txtSzulDatum";
            this.txtSzulDatum.Size = new System.Drawing.Size(108, 20);
            this.txtSzulDatum.TabIndex = 4;
            // 
            // radF
            // 
            this.radF.AutoSize = true;
            this.radF.Location = new System.Drawing.Point(103, 50);
            this.radF.Name = "radF";
            this.radF.Size = new System.Drawing.Size(31, 17);
            this.radF.TabIndex = 5;
            this.radF.TabStop = true;
            this.radF.Text = "F";
            this.radF.UseVisualStyleBackColor = true;
            // 
            // radN
            // 
            this.radN.AutoSize = true;
            this.radN.Location = new System.Drawing.Point(140, 50);
            this.radN.Name = "radN";
            this.radN.Size = new System.Drawing.Size(33, 17);
            this.radN.TabIndex = 6;
            this.radN.TabStop = true;
            this.radN.Text = "N";
            this.radN.UseVisualStyleBackColor = true;
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(12, 9);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(33, 13);
            this.nev.TabIndex = 7;
            this.nev.Text = "Név: ";
            // 
            // szulDatum
            // 
            this.szulDatum.AutoSize = true;
            this.szulDatum.Location = new System.Drawing.Point(12, 31);
            this.szulDatum.Name = "szulDatum";
            this.szulDatum.Size = new System.Drawing.Size(68, 13);
            this.szulDatum.TabIndex = 8;
            this.szulDatum.Text = "Szül. dátum: ";
            // 
            // hobbi
            // 
            this.hobbi.AutoSize = true;
            this.hobbi.Location = new System.Drawing.Point(150, 197);
            this.hobbi.Name = "hobbi";
            this.hobbi.Size = new System.Drawing.Size(52, 13);
            this.hobbi.TabIndex = 9;
            this.hobbi.Text = "Új hobbi: ";
            // 
            // nem
            // 
            this.nem.AutoSize = true;
            this.nem.Location = new System.Drawing.Point(12, 54);
            this.nem.Name = "nem";
            this.nem.Size = new System.Drawing.Size(29, 13);
            this.nem.TabIndex = 10;
            this.nem.Text = "Nem";
            // 
            // kedvencHobbi
            // 
            this.kedvencHobbi.AutoSize = true;
            this.kedvencHobbi.Location = new System.Drawing.Point(238, 9);
            this.kedvencHobbi.Name = "kedvencHobbi";
            this.kedvencHobbi.Size = new System.Drawing.Size(85, 13);
            this.kedvencHobbi.TabIndex = 11;
            this.kedvencHobbi.Text = "Kedvenc hobbi: ";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(103, 2);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(108, 20);
            this.txtNev.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radE
            // 
            this.radE.AutoSize = true;
            this.radE.Location = new System.Drawing.Point(180, 50);
            this.radE.Name = "radE";
            this.radE.Size = new System.Drawing.Size(32, 17);
            this.radE.TabIndex = 14;
            this.radE.TabStop = true;
            this.radE.Text = "E";
            this.radE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 314);
            this.Controls.Add(this.radE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.kedvencHobbi);
            this.Controls.Add(this.nem);
            this.Controls.Add(this.hobbi);
            this.Controls.Add(this.szulDatum);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.radN);
            this.Controls.Add(this.radF);
            this.Controls.Add(this.txtSzulDatum);
            this.Controls.Add(this.txtHobbi);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.TextBox txtHobbi;
        private System.Windows.Forms.TextBox txtSzulDatum;
        private System.Windows.Forms.RadioButton radF;
        private System.Windows.Forms.RadioButton radN;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label szulDatum;
        private System.Windows.Forms.Label hobbi;
        private System.Windows.Forms.Label nem;
        private System.Windows.Forms.Label kedvencHobbi;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radE;
    }
}

