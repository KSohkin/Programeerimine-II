namespace KooliProjekt.Data
{
    public static class SeedData
    {
        public static void Generate(ApplicationDbContext context)
        {
            if (context.Client.Any())
            {
                Console.WriteLine("Kliendid on juba olemas");
                return;
            }

            var Clients = new List<Client>
            
                    
            

                       

            context.Client.AddRange(Clients);

            context.SaveChanges();
        }
    }
}