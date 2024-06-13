using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_PAW_Smeureanu
{
    public partial class Form1 : Form
    {

        List<Bilet> lstBilete = new List<Bilet>(); //declaram variabila globala ca sa o folosim oriunde in aplicatie
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AdaugaBilet_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //cream un form2 din care sa adaugam informatiile si asteptam raspunsul din partea lui
            if(form2.ShowDialog() == DialogResult.OK) //daca raspunsul este OK
            {
                lstBilete.Add(form2.BiletCreat); //adaugam in lista noastra biletul citit din form2
                UpdateListaBilete(); //dam update la listView
            }
            else
            {
                MessageBox.Show("Nu s-a inregistrat biletul!"); //altfel afisam un mesaj care ne anunta ca nu s-a adaugat biletul
            }
        }

        private void UpdateListaBilete()
        {
            lv_Bilete.Items.Clear(); //stergem tot ce e in listView
            foreach(Bilet b in lstBilete) //pentru fiecare bilet din lstBilete
            {
                ListViewItem itm = new ListViewItem(b.Id); //Tinem minte intr-un ListViewItems primul atribut din lista
                itm.SubItems.Add(b.StatiePlecare);
                itm.SubItems.Add(b.DataCursei.ToString());
                itm.SubItems.Add(b.Destinatie);
                itm.SubItems.Add(b.Pret.ToString()); //apoi in subitemele ListViewItem-ului creat (itm) adaugam IN ORDINE urmatoarele atribute

                lv_Bilete.Items.Add(itm); //Itemele din lv-ul nostru de actualizeaza cu itm
            }
            
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) //OBLIGATORIU SA PRIMIM OK DIN PARTEA SAVEFILEDIALOG
            {
                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write); //cream un fileStream cu un constructor care sa contina saveFileDialog.FileName, FileMode so FileAcces
                BinaryFormatter bf = new BinaryFormatter(); //cream un binaryFormatter
                bf.Serialize(fileStream, lstBilete); //serializam binaryFormatter-ul
                fileStream.Close(); //inchidem fileStream-ul creat
            }
            
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //OBLIGATORIU SA PRIMIM OK DIN PARTEA OPENFILEDIALOG
            {
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read); //identic
                BinaryFormatter b = new BinaryFormatter(); //identic
                lstBilete.Clear(); //lista noastra trebuie curata mai intai
                lstBilete = (List<Bilet>)b.Deserialize(fileStream); //deserializam binaryFormatterul si ii facem cast la Lista Noastra
                fileStream.Close(); //inchidem fileStream-ul
            }


        }
    }
}
