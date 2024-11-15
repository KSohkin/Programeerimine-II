namespace KooliProjekt.Data
{
    public static class SeedData
    {
        public static void GenerateClients(ApplicationDbContext context)
        {
            if (context.Client.Any()) // Asenda TableName oma tegeliku tabeli nimega
            {
                Console.WriteLine("Kliendid on juba olemas");
                return; // Kui on andmed, siis ei tee midagi
            }

            var clients = new List<Client>
    {
        new Client { First_name = "Jordan", Last_name = "Smith", ID = "101", Phone_number = "5027010", Email = "Jordan.Smith@gmail.com" },
        new Client { First_name = "John", Last_name = "Doe", ID = "102", Phone_number = "5027011", Email = "John.Doe@gmail.com" },
        new Client { First_name = "Alice", Last_name = "Johnson", ID = "103", Phone_number = "5027012", Email = "Alice.Johnson@gmail.com" },
        new Client { First_name = "Michael", Last_name = "Brown", ID = "104", Phone_number = "5027013", Email = "Michael.Brown@gmail.com" },
        new Client { First_name = "Emily", Last_name = "Davis", ID = "105", Phone_number = "5027014", Email = "Emily.Davis@gmail.com" },
        new Client { First_name = "David", Last_name = "Miller", ID = "106", Phone_number = "5027015", Email = "David.Miller@gmail.com" },
        new Client { First_name = "Sophia", Last_name = "Wilson", ID = "107", Phone_number = "5027016", Email = "Sophia.Wilson@gmail.com" },
        new Client { First_name = "James", Last_name = "Taylor", ID = "108", Phone_number = "5027017", Email = "James.Taylor@gmail.com" },
        new Client { First_name = "Olivia", Last_name = "Anderson", ID = "109", Phone_number = "5027018", Email = "Olivia.Anderson@gmail.com" },
        new Client { First_name = "William", Last_name = "Thomas", ID = "110", Phone_number = "5027019", Email = "William.Thomas@gmail.com" }
    };

            context.Client.AddRange(clients);

            context.SaveChanges();
        }


        public static void GenerateEvents(ApplicationDbContext context)
        {
            if (context.Event.Any()) // Asenda TableName oma tegeliku tabeli nimega
            {
                Console.WriteLine("Üritused on juba olemas");
                return; // Kui on andmed, siis ei tee midagi
            }

            var events = new List<Event>
 {
        new Event { ID = "101", Name = "WinterFest", Time = new DateTime(2024, 11, 25, 9, 0, 0), Description = "Winter Stuff", Spots = "1000", Eventplan = "idk", Price = "20m", Summary = "WIHWWRF", Organizer = "SM Co", },
        new Event { ID = "102", Name = "New Year Festival", Time = new DateTime(2024, 12, 5, 9, 0, 0), Description = "Fireworks and stuff", Spots = "5000", Eventplan = "idk", Price = "50m", Summary = "WIHWWRF", Organizer = "WT Co.", },
        new Event { ID = "103", Name = "Indepentence drinking festival", Time = new DateTime(2025, 2, 15, 9, 0, 0), Description = "Drinking to celebrate indepentence", Spots = "500", Eventplan = "idk", Price = "10m", Summary = "WIHWWRF", Organizer = "WHO Co.", },
        new Event { ID = "104", Name = "Early summer Festival", Time = new DateTime(2025, 4, 17, 9, 0, 0), Description = "Drinking and stuff", Spots = "250", Eventplan = "idk", Price = "5m", Summary = "WIHWWRF", Organizer = "NF Co.", }
    };

            context.Event.AddRange(events);

            context.SaveChanges();
        }
        public static void GenerateOrganizers(ApplicationDbContext context)
        {
               if (context.Organizer.Any()) // Asenda TableName oma tegeliku tabeli nimega
               {
                   Console.WriteLine("Planeerijad on juba olemas");
                   return; // Kui on andmed, siis ei tee midagi
               }

               var organizers = new List<Organizer>
 {
        new Organizer { ID = "42", Name = "SM Co", Description = "Idk", },
        new Organizer { ID = "12", Name = "WT Co", Description = "Idk", },
        new Organizer { ID = "63", Name = "NF CO", Description = "Idk", },
        new Organizer { ID = "16", Name = "WHO Co", Description = "Idk", }
    };

                context.Organizer.AddRange(organizers);

                context.SaveChanges();

            }
    }  
}