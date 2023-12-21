using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AccessibilityModels
{
    public class Ervaringsdeskundige : Gebruiker
    {

        public string Voornaam { get; set; }

        public string Achternaam { get; set; }

        public string? AandoeningOfZiekte { get; set; }

        public string VoorkeurBenadering { get; set; }

        public bool MagCommercieelBenaderdWorden { get; set; }

        public List<DateTime> BeschikbareTijden { get; set; }

        public string? NaamVoogd { get; set; }

        public string? EmailVoogd { get; set; }

        public string? TelefoonnummerVoogd { get; set; }

        public List<OnderzoekDeelname>? OnderzoekDeelnames { get; set; }

        public List<ErvaringsdeskundigeHulpmiddel>? GebruikteHulpmiddelen { get; set; }

        public List<ErvaringsdeskundigeBeperking>? Beperkingen { get; set; }

        public List<Interesse>? GetoondeInteresses { get; set; }


        public DateTime GeboorteDatum { get; set; }

        public int Leeftijd
        {
            get
            {
                return BerekenLeeftijd(GeboorteDatum, DateTime.Now);
            }
        }

        private int BerekenLeeftijd(DateTime geboorteDatum, DateTime huidigeDatum)
        {
            int leeftijd = huidigeDatum.Year - geboorteDatum.Year;

            if (huidigeDatum.Month < geboorteDatum.Month || (huidigeDatum.Month == geboorteDatum.Month && huidigeDatum.Day < geboorteDatum.Day))
            {
                leeftijd--;
            }

            return leeftijd;
        }

    }
}