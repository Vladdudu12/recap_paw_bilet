using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Model_PAW_Smeureanu
{
    [Serializable] //folosim asta pentru ca avem citire / scriere in fisier binar
    public class Bilet: ICalculEficienta //implementam interfata creata de noi
    {

        private string id;
        private DateTime dataCursei;
        private string statiePlecare;
        private string destinatie;
        private int pret;

        public Bilet(string id = "-", DateTime dataCursei = new DateTime(), string statiePlecare = "-", string destinatie = "-", int pret = 0) //parametrii sunt impliciti, asa ca trebuie initializati aici
        {
            this.id = id;
            this.dataCursei = dataCursei;
            this.statiePlecare = statiePlecare;
            this.destinatie = destinatie;
            this.pret = pret;
        }

        public string Destinatie { get => destinatie; set => destinatie = value; }
        public int Pret { get => pret; set => pret = value; }
        public string Id { get => id; set => id = value; }
        public DateTime DataCursei { get => dataCursei; set => dataCursei = value; }
        public string StatiePlecare { get => statiePlecare; set => statiePlecare = value; }

        public float pretPerKm()
        {
            FileStream fileStream = new FileStream("distante.dat", FileMode.Open, FileAccess.Read); //citim din fisierul creat de noi cu FileStream
            StreamReader streamReader = new StreamReader(fileStream); //citim cu StreamReader
            string linie = streamReader.ReadLine(); //cream un string in care citim prima linie din fisier
            string[] vector = linie.Split(' '); //cream un vector de stringuri care ne desparte linia citita la fiecare spatiu
            float nrKm = float.Parse(vector[2]); //stim ca pe pozitia 2 a vectorului de afla distanta (asa am pus noi), asadar facem float.Parse la acel element pentru a obtine nrKM
            return (float)(this.pret / nrKm); //facem impartirea si conversie la float

            //citireBinara
            //FileStream fileStream = new FileStream("distante.dat", FileMode.Open, FileAccess.Read);
            //BinaryFormatter binaryFormatter = new BinaryFormatter();
            //string linie = (string)binaryFormatter.Deserialize(fileStream);
            //string[] vector = linie.Split(' ');
            //float nrKm = float.Parse(vector[3]);
            //return (float)(this.pret / nrKm);
        }


    }
}
