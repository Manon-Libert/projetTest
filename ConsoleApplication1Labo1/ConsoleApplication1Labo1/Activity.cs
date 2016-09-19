using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1Labo1
{
    class Activity
    {
        // attributs
        private Boolean compulsory;
        private string libelle;
        // propriétés
        

        public Boolean Compulsory        {
            get { return compulsory; }
            set { compulsory = value; }
        }

        public string Libelle
        {
            get{return libelle;}
            set{ libelle = (value == null) ?  "default" : value; }
        }

        //constructeur

        public Activity(String libelle, Boolean compulsory)
        {
            Libelle = libelle;
            Compulsory = compulsory;
        }


        //méthodes

        public override string ToString()
        {
            return (Compulsory) ? Libelle+"(obligatoire)": Libelle;
        }

    }
}
