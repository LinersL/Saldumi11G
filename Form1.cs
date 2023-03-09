using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LL_Saldumi11
{
    public partial class Form1 : Form
    {
        double cena = 0.00;  //define "cena"

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CENAS(); //ar pogas spiedienu izsauc cenu funkciju
            Aprekins(); //ar pogas spiedienu izsauc aprēķinu funkciju
        }
        private void CENAS() //izveidota Cenas funkcija
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                cena = 20.3; //nosaka cenu ja atķeksētas visas kastītes
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                cena = 16.1; //nosaka cenu ja atķeksētas pirmās divas kastītes

            }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                cena = 14.08;  //nosaka cenu ja atķeksētas pirmā un pēdējā kastīte

            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                cena = 10.42;  //nosaka cenu ja atķeksētas pēdējās divas kastītes

            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                cena = 4.20;  //nosaka cenu ja atķeksētas visas kastītes
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                cena = 9.88;  //nosaka cenu ja atķeksēta pirmā kastīte
            }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                cena = 6.22; //nosaka cenu ja atķeksēta otrā kastīte
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Nav neviens saldumu veids atlasits"); // izvada ka nav neviena kastīte atķeksēta
            }

        }
        private void Aprekins() //izveido aprēķinu funkciju
        {

            double sk1 = Convert.ToDouble(Summa.Text); // Textbox tekstu pārvērš par skaitli
            double dati = sk1 / cena; //veic aprēķinus
            double rezultats = Math.Round(dati, 3); //noapaļo rezultātu līdz trīs skaitļiem aiz komata
            Dati_TB.Text = rezultats.ToString();  //pārvērš rezultātu uz string

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Dati_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ceksDirectory = Application.StartupPath + "\\Ceks\\";  // sameklē un atver failu ar nosaukumu 'Ceks'
            Directory.CreateDirectory(ceksDirectory);

            string fileName = vardsBox1.Text +" "+ dateTimePicker1.Text + " ceks.txt"; // izveido teksta failu ar specifisku nosaukumu
            string filePath = Path.Combine(ceksDirectory, fileName); 

            using (StreamWriter writer = new StreamWriter(filePath))  // rāda kas tiek izmantot jeb 'streamwriter' 
            {
                writer.WriteLine(Vards.Text + ": " + vardsBox1.Text); // ievada teksta failā lietotāja vārdu
                writer.WriteLine(Datums.Text + ": " + dateTimePicker1.Text); // ievada teksta failā lietotāja ievadīto datumu
                writer.WriteLine(Nsumma.Text + ": " + Summa.Text + "€"); // ievada teksta failā lietotāja pieejamās naudas summu
                writer.WriteLine(daudz.Text + ": " + Dati_TB.Text + "kg"); // ievada teksta failā lietotāja aprēķināto saldumu daudzumu

                string selected = ""; // zveido jaunu tukšu virkni "selected", kuru izmantosim, lai apkopotu visas atlasītās izvēles.

                if (checkBox1.Checked) // Pārbauda, vai "checkBox1" ir atzīmēts, kas nozīmē, ka tas ir atlases statusā.
                    selected += checkBox1.Text + ", "; // Ja "checkBox1" ir atzīmēts, tad pievieno tā tekstu "selected" virknē, un iekļauj arī komatu un atstarpi pēc tā, lai varētu atšķirt no citām izvēlēm.

                if (checkBox2.Checked) // Pārbauda, vai "checkBox2" ir atzīmēts.
                    selected += checkBox2.Text + ", "; // Ja "checkBox2" ir atzīmēts, tad pievieno tā tekstu "selected" virknē, un iekļauj arī komatu un atstarpi pēc tā.

                if (checkBox3.Checked) // Pārbauda, vai "checkBox3" ir atzīmēts.
                    selected += checkBox3.Text;  // Ja "checkBox3" ir atzīmēts, tad pievieno tā tekstu "selected" virknē, bet šoreiz bez komata un atstarpes.

                if (selected != "") // Pārbauda, vai "selected" virkne nav tukša, kas nozīmē, ka ir kāds saldumu veids atlases statusā.
                {
                    selected = selected.TrimEnd(',', ' '); // Ja "selected" virknē ir iekļauti saldumi, tad noņem beigās iekļauto komatu un atstarpes, lai varētu izvadīt pareizu tekstu.
                    writer.WriteLine("Salduma izvele: " + selected); // Izvada tekstu, kas ietver tekstu "Salduma izvēle" un visus atlasītos saldumus.
                }
                else // Ja neviens saldumu veids nav atlasīts, tad izpildās šī daļa.
                {
                    writer.WriteLine("Nav neviens saldumu veids atlasits"); // Izvada tekstu, kas paziņo, ka nav atlasīts neviens saldumu veids.
                }

            }

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
