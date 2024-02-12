using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class GestionEtudiants
    {
        List<Etudiant> etudiants;
        public GestionEtudiants()
        {
            Etudiants=new List<Etudiant>();
        }

        internal List<Etudiant> Etudiants { get => etudiants; set => etudiants = value; }

        public void AddEtudiant(Etudiant etudiant)
        {
            Etudiants.Add(etudiant);
        }
        public Etudiant GetEtudiant(string nom, string prenom)
        {
            foreach (var item in Etudiants)
            {
                if(item.Nom == nom && item.Prenom==prenom)
                    return item;
            }
            return null;
        }
    }
}
