using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_PAW_Smeureanu
{
    public partial class Form2 : Form
    {
        public Bilet BiletCreat { get; set; } //cream un bilet public ca sa putem avea acces la el si din form1, asta este singura noastra legatura dintre form1 si form2
        public Form2()
        {
            InitializeComponent();
            tb_StatiePlecare.Text = "Bucuresti"; //facem asta ca sa fie scris deja text la statia de plecare de cand deschidem formularul
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string id;
            DateTime dataCursei;
            string statiePlecare;
            string destinatie;
            int pret; //scriem toate atributele din clasa, dar fara private in fata

            id = tb_Id.Text; //adaugam in atributele respective ce citim noi in form (denumirile pe care le-am dat TB, CB ETC)
            statiePlecare = tb_StatiePlecare.Text;
            dataCursei = DateTime.Parse(dtp_DataCursei.Text);
            destinatie = cb_Destinatie.Text;
            if(int.TryParse(tb_Pret.Text, out pret))
            {
                pret = Convert.ToInt32(tb_Pret.Text);
            }

            BiletCreat = new Bilet(id, dataCursei, statiePlecare, destinatie, pret); //biletul creat la inceput ia valoarea unui bilet cu toate atributele citite
            DialogResult = DialogResult.OK; //OBLIGATORIU - ca sa aratam ca formul nostru s-a inchis cu OK
            this.Close(); //OBLIGATORIU - ca sa inchidem formul
    }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //OBLIGATORIU - ca sa aratam ca formul nostru s-a inchis cu Cancel
            this.Close(); //OBLIGATORIU - ca sa inchidem formul
        }
    }
}
