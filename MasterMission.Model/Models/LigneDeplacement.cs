
using System;

namespace MasterMission.Models
{
    public class LigneDeplacement
    {
        public int Id { get; set; }

        public int FeuilleDeFraisId { get; set; }
        public virtual FeuilleDeFrais FeuilleDeFrais { get; set; }

        public DateTime Date { get; set; }

        public string LibelleDeDeplacement { get; set; }

        public double NbKmVehiculeSoc { get; set; }
        public double NbKmVehiculePerso { get; set; }
        
        public double MontantIndemniteVehiPerso { get; set; }
        public double MontantHtEntretienVehSoc { get; set; }
        public double MontantHtHotelResto { get; set; }
        public double MontantCarbParkPeage { get; set; }
        public double MontantHtAutresFrais { get; set; }
        public double MontantTvaDeductible { get; set; }
    }
}