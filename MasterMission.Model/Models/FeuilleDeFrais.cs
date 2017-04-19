
using System;
using System.Collections.Generic;

namespace MasterMission.Models
{
    public class FeuilleDeFrais
    {
        public int Id { get; set; }

        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public int SalarieId { get; set; }
        public virtual Salarie Salarie { get; set; }

        public int ResponsableId { get; set; }
        public virtual Salarie Responsable { get; set; }

        public virtual IList<LigneDeplacement> Lignes { get; set; }

        public double KilometrageMois { get; set; }
        public double CompteurDebutMois { get; set; }
        public DateTime DateDePaiement { get; set; }

        public string ModePaiement { get; set; }
        public string ReferenceDePiece { get; set; }

        public int AgenceId { get; set; }
        public virtual Agence Agence { get; set; }

        public int VehiculeId { get; set; }
        public virtual Vehicule Vehicule { get; set; }

        public bool VehiculePersonnel { get; set; }
        public bool VehiculeSociete { get; set; }
        public bool EtatValide { get; set; }
    }
}