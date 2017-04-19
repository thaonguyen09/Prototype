
using System;

namespace MasterMission.Models
{
    public class Salarie
    {
        public int Id { get; set; }

        public string Identifiant { get; set; }
        public string MotDePasse { get; set; }

        public string Matricule { get; set; }
        
        public string Nom { get; set; }
        public string Prenom { get; set; }
        
        public DateTime DateEntree { get; set; }
        public DateTime DateSortie { get; set; }

        public int VehiculePersonnel { get; set; }

        public string Profil { get; set; }
        
        public int AgenceId { get; set; }
        public virtual Agence Agence { get; set; }
    }
}