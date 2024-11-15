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
        new Event { ID = "104", Name = "Early summer Festival", Time = new DateTime(2025, 4, 17, 9, 0, 0), Description = "Drinking and stuff", Spots = "250", Eventplan = "idk", Price = "5m", Summary = "WIHWWRF", Organizer = "NF Co.", },
        new Event { ID = "105", Name = "Spring Carnival", Time = new DateTime(2025, 3, 21, 10, 0, 0), Description = "Carnival rides, games, and fun for all ages", Spots = "3000", Eventplan = "idk", Price = "15m", Summary = "WIHWWRF", Organizer = "ABC Co.", },
        new Event { ID = "106", Name = "Halloween Bash", Time = new DateTime(2024, 10, 31, 18, 0, 0), Description = "Costume party with music, dancing, and tricks", Spots = "2000", Eventplan = "idk", Price = "30m", Summary = "WIHWWRF", Organizer = "GH Co.", },
        new Event { ID = "107", Name = "Summer Solstice Celebration", Time = new DateTime(2025, 6, 21, 12, 0, 0), Description = "Celebrating the longest day of the year", Spots = "1500", Eventplan = "idk", Price = "25m", Summary = "WIHWWRF", Organizer = "TLM Co.", },
        new Event { ID = "108", Name = "Autumn Harvest Festival", Time = new DateTime(2024, 9, 25, 9, 0, 0), Description = "Harvest-themed event with food, music, and dancing", Spots = "1000", Eventplan = "idk", Price = "12m", Summary = "WIHWWRF", Organizer = "HGP Co.", },
        new Event { ID = "109", Name = "Valentine's Day Gala", Time = new DateTime(2025, 2, 14, 18, 0, 0), Description = "A romantic evening with dinner, dancing, and music", Spots = "600", Eventplan = "idk", Price = "35m", Summary = "WIHWWRF", Organizer = "VCO Co.", },
        new Event { ID = "110", Name = "Music and Arts Festival", Time = new DateTime(2025, 7, 10, 11, 0, 0), Description = "Live music, art displays, and creative workshops", Spots = "4000", Eventplan = "idk", Price = "45m", Summary = "WIHWWRF", Organizer = "CREO Co.", }

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
        new Organizer { ID = "42", Name = "SM Co", Description = "Specializes in winter festivals and seasonal events. Known for large-scale outdoor gatherings and winter-themed activities.", },
        new Organizer { ID = "12", Name = "WT Co", Description = "Experts in fireworks displays and New Year's Eve celebrations. They also organize large public festivals and citywide events.", },
        new Organizer { ID = "63", Name = "NF Co", Description = "Known for organizing summer festivals and family-friendly outdoor events. They focus on community participation and entertainment.", },
        new Organizer { ID = "16", Name = "WHO Co", Description = "Specializes in heritage and cultural events. Famous for their Independence Day celebrations and large drinking festivals.", },
        new Organizer { ID = "24", Name = "ABC Co", Description = "Leading in event planning and entertainment.", },
        new Organizer { ID = "55", Name = "GH Co", Description = "Specializing in large-scale festivals and gatherings.", },
        new Organizer { ID = "38", Name = "TLM Co", Description = "Experts in creating vibrant and memorable celebrations.", },
        new Organizer { ID = "77", Name = "HGP Co", Description = "Focused on cultural events and community engagement.", },
        new Organizer { ID = "89", Name = "VCO Co", Description = "Creating magical experiences for couples and romantic events.", },
        new Organizer { ID = "101", Name = "CREO Co", Description = "Passionate about music, arts, and creative workshops.", }

    };

                context.Organizer.AddRange(organizers);

                context.SaveChanges();

            }
    }  
}