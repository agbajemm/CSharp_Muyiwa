using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Databaze_osob
{/// <summary>
 /// třída reprezentující Osobu a info o ní
 /// </summary>
    public class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        //public DateTime DatumNarozeni { get; set; }

        public int ID { get; set; }

        public bool Pohlavi { get; set; }   //true -muž/ false -žena

        [XmlIgnore]
        public Image Foto
        {
            get
            {
                if (FotoByte != null)
                {
                   

                    return Image.FromStream(new MemoryStream(FotoByte));
                }
                else return null;
            }
            set 
            {
                
                    var stream = new MemoryStream();
                    Foto.Save(stream, Foto.RawFormat);
                    FotoByte =  stream.ToArray();
              

            }
        }

        public byte[] FotoByte { get; set; }// obrazek zaspsaný v poli bytu, aby šel serializovat




        public Osoba(int id, string jmeno, string prijmeni, bool pohlavi)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;

            ID = id;
            Pohlavi = pohlavi;

        }


        public Osoba() { }//prázdný konstruktor aby fungovala serializace
        public override string ToString()
        {
            return String.Format($"{Jmeno} {Prijmeni} - {ID}");
        }


    }






}
