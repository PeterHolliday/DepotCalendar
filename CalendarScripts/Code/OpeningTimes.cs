using CalendarScripts.Models;

namespace CalendarScripts.Code
{
    public class OpeningTimes
    {
        public List<Depot> ListOpeningTimes()
        {
            List<Depot> depots = new List<Depot>();

            //depots.Add(new Depot { Id = 1800, Name = "Erith", Short = "EAP" });
            //depots.Add(new Depot { Id = 1700, Name = "Heathrow", Short = "HAP" });

            List<OpeningHours> TapOpening = new List<OpeningHours>();
            TapOpening.Add(new OpeningHours { Day = "Monday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            TapOpening.Add(new OpeningHours { Day = "Tuesday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            TapOpening.Add(new OpeningHours { Day = "Wednesday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            TapOpening.Add(new OpeningHours { Day = "Thursday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            TapOpening.Add(new OpeningHours { Day = "Friday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            TapOpening.Add(new OpeningHours { Day = "Saturday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1200", ClosedUntil = "2400" });
            TapOpening.Add(new OpeningHours { Day = "Sunday", ClosedFrom = "0000", OpensAt = "2400", ClosesAt = string.Empty, ClosedUntil = string.Empty });

            depots.Add(new Depot { Id = 3, Name = "Theale", Short = "TAP", Openings = TapOpening });

            List<OpeningHours> NapOpening = new List<OpeningHours>();
            NapOpening.Add(new OpeningHours { Day = "Monday", ClosedFrom = "0200", OpensAt = "0600", ClosesAt = string.Empty, ClosedUntil = string.Empty });
            NapOpening.Add(new OpeningHours { Day = "Tuesday", ClosedFrom = "0200", OpensAt = "0600", ClosesAt = string.Empty, ClosedUntil = string.Empty });
            NapOpening.Add(new OpeningHours { Day = "Wednesday", ClosedFrom = "0200", OpensAt = "0600", ClosesAt = string.Empty, ClosedUntil = string.Empty });
            NapOpening.Add(new OpeningHours { Day = "Thursday", ClosedFrom = "0200", OpensAt = "0600", ClosesAt = string.Empty, ClosedUntil = string.Empty });
            NapOpening.Add(new OpeningHours { Day = "Friday", ClosedFrom = "0200", OpensAt = "0600", ClosesAt = string.Empty, ClosedUntil = string.Empty });
            NapOpening.Add(new OpeningHours { Day = "Saturday", ClosedFrom = "0200", OpensAt = "0700", ClosesAt = "1200", ClosedUntil = "2400" });
            NapOpening.Add(new OpeningHours { Day = "Sunday", ClosedFrom = "0000", OpensAt = "2400", ClosesAt = string.Empty, ClosedUntil = string.Empty });

            depots.Add(new Depot { Id = 2400, Name = "Newhaven", Short = "NAP", Openings = NapOpening });

            List<OpeningHours> CapOpening = new List<OpeningHours>();
            CapOpening.Add(new OpeningHours { Day = "Monday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            CapOpening.Add(new OpeningHours { Day = "Tuesday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            CapOpening.Add(new OpeningHours { Day = "Wednesday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            CapOpening.Add(new OpeningHours { Day = "Thursday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            CapOpening.Add(new OpeningHours { Day = "Friday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "2000", ClosedUntil = "2400" });
            CapOpening.Add(new OpeningHours { Day = "Saturday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1200", ClosedUntil = "2400" });
            CapOpening.Add(new OpeningHours { Day = "Sunday", ClosedFrom = "0000", OpensAt = "2400", ClosesAt = string.Empty, ClosedUntil = string.Empty });

            depots.Add(new Depot { Id = 1052, Name = "Croydon", Short = "CAP", Openings = CapOpening });

            List<OpeningHours> AapOpening = new List<OpeningHours>();
            AapOpening.Add(new OpeningHours { Day = "Monday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1800", ClosedUntil = "2400" });
            AapOpening.Add(new OpeningHours { Day = "Tuesday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1800", ClosedUntil = "2400" });
            AapOpening.Add(new OpeningHours { Day = "Wednesday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1800", ClosedUntil = "2400" });
            AapOpening.Add(new OpeningHours { Day = "Thursday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1800", ClosedUntil = "2400" });
            AapOpening.Add(new OpeningHours { Day = "Friday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1800", ClosedUntil = "2400" });
            AapOpening.Add(new OpeningHours { Day = "Saturday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1200", ClosedUntil = "2400" });
            AapOpening.Add(new OpeningHours { Day = "Sunday", ClosedFrom = "0000", OpensAt = "2400", ClosesAt = string.Empty, ClosedUntil = string.Empty });

            depots.Add(new Depot { Id = 1500, Name = "Aldershot", Short = "AAP", Openings = AapOpening });

            List<OpeningHours> RapOpening = new List<OpeningHours>();
            RapOpening.Add(new OpeningHours { Day = "Monday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1300", ClosedUntil = "2400" });
            RapOpening.Add(new OpeningHours { Day = "Tuesday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1300", ClosedUntil = "2400" });
            RapOpening.Add(new OpeningHours { Day = "Wednesday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1300", ClosedUntil = "2400" });
            RapOpening.Add(new OpeningHours { Day = "Thursday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1300", ClosedUntil = "2400" });
            RapOpening.Add(new OpeningHours { Day = "Friday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1300", ClosedUntil = "2400" });
            RapOpening.Add(new OpeningHours { Day = "Saturday", ClosedFrom = "0000", OpensAt = "0600", ClosesAt = "1300", ClosedUntil = "2400" });
            RapOpening.Add(new OpeningHours { Day = "Sunday", ClosedFrom = "0000", OpensAt = "2400", ClosesAt = string.Empty, ClosedUntil = string.Empty });

            depots.Add(new Depot { Id = 1600, Name = "Reading", Short = "RAP", Openings = RapOpening });

            return depots;

        }
    }
}
