using AulaSub.Data;
using Microsoft.EntityFrameworkCore;


namespace AulaSub.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AulaSubContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AulaSubContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                context.Aula.AddRange(
                    new Aula
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },
                   
                );
                context.SaveChanges();
            }
        }
    }
}
