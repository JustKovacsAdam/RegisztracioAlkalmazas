using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feladatok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileOk += (sender, e) =>
            {

                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        lista.Items.Clear();

                        txtNev.Text = sr.ReadLine();
                        txtSzulDatum.Text = sr.ReadLine();
                        string nem = sr.ReadLine();
                        if (nem.Equals("F"))
                        {
                            radF.Checked = true;
                        }
                        else if (nem.Equals("N"))
                        {
                            radN.Checked = true;
                        }
                        else
                        {
                            radE.Checked = true;
                        }

                        while (!sr.EndOfStream)
                        {
                            lista.Items.Add(sr.ReadLine());
                        }
                    }
                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba! Nem sikerült a betöltés!");

                }

            };
        }

        private void txtHobbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !txtHobbi.Text.Trim().Equals(""))
            {
                lista.Items.Add(txtHobbi.Text);
                txtHobbi.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtHobbi.Text.Trim().Equals(""))
            {
                lista.Items.Add(txtHobbi.Text);
                txtHobbi.Text = "";
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {

            if ((radF.Checked || radN.Checked || radE.Checked) && !txtNev.Text.Trim().Equals("") && !txtSzulDatum.Text.Trim().Equals("") && lista.Items.Count != 0)
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                string hibaUzenet = "";

                if (txtNev.Text.Trim().Equals(""))
                {
                    hibaUzenet += "\n-Nevét";
                }
                if (txtSzulDatum.Text.Trim().Equals(""))
                {
                    hibaUzenet += "\n-Születési Dátumát";
                }
                if (!(radF.Checked || radN.Checked || radE.Checked))
                {
                    hibaUzenet += "\n-Nemét";
                }
                if (lista.Items.Count == 0)
                {
                    hibaUzenet += "\n-Legalább egy kedvenc hobbiját";
                }

                MessageBox.Show("Kérem adja meg az alábbiakat:" + hibaUzenet);
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                
                using (var sw = new StreamWriter(saveFileDialog1.FileName))
                {

                    sw.WriteLine(txtNev.Text + "\n" + txtSzulDatum.Text);
                    if (radF.Checked)
                    {
                        sw.WriteLine("F");
                    }
                    else if(radN.Checked)
                    {
                        sw.WriteLine("N");
                    }
                    else
                    {

                    }


                    foreach (var item in lista.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba. Sikertelen mentés!");
               
            }

        }



        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }


    }
}
