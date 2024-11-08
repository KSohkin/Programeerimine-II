namespace KooliProjekt.Data
{
    public static class SeedData
    {
        public static void Generate(ApplicationDbContext context)
        {
            if (context.TodoLists.Any())
            {
                return;
            }

            var list = new TodoList();
            

            context.TodoLists.Add(list);

            // Veel andmeid

            context.SaveChanges();
        }
    }
}
