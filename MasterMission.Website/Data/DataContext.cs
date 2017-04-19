
using System;
using System.Collections.Generic;

using MasterMission.Model;

namespace MasterMission.Data
{
    public class DataContext
    {
        /// <summary>
        /// La liste des personnes, stocké dans la mémoire vive de l'application web
        /// à remplacer par database
        /// </summary>
        private static List<Personne> Personnes;

        /// <summary>
        /// Retourner la liste des personnes (en statique).
        /// Si la liste n'existe pas encore, en créer une.
        /// </summary>
        /// <returns></returns>
        public List<Personne> GetListPersonne()
        {
            if(Personnes == null)
            {
                Personnes = new List<Personne>()
                {
                    new Personne() { Id=1, FirstName="NGUYEN", LastName="Huu", Birthday=new DateTime(1991,11,1) },
                    new Personne() { Id=2, FirstName="TRAN", LastName="Nguyen", Birthday=new DateTime(1991,11,6) },
                    new Personne() { Id=3, FirstName="LE THI", LastName="Lam Thui", Birthday=new DateTime(1991,10,12) },
                    new Personne() { Id=4, FirstName="LE DOAN", LastName="Giang Ngoc", Birthday=new DateTime(1991,12,25) }
                };
            }
            return Personnes;
        }
    }
}