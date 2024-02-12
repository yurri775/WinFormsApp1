using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Etudiant
    {
        string nom;
        string prenom;
        string email;
        DateTime dateN;
        string bac;
        Mention mention;
        Genre genre;

        public Etudiant()
        {
        }

        public override string ToString()
        {
            return nom+" "+prenom+" "+genre+" "+email+
                " "+dateN.ToShortDateString()+" "+bac+" "+mention;
        }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateN { get => dateN; set => dateN = value; }
        public string Bac { get => bac; set => bac = value; }
        public Genre Genre { get => genre; set => genre = value; }
        internal Mention Mention { get => mention; set => mention = value; }
    }
}
