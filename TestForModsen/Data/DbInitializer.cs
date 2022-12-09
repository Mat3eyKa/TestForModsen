using System;
using System.Linq;
using TestForModsen.Models;

namespace TestForModsen.Data
{
    public class DbInitializer
    {
        public static void Initialize(ModsenContext context)
        {
            if (context.Events.Any())
                return;

            context.Events.AddRange(new Event[]
            { 
                new Event {Name = "", Description = "", Plan = "", Sponsor = "", Speaker = "", Location = "", StartDate = DateTime.Now },
                new Event {Name = "", Description = "", Plan = "", Sponsor = "", Speaker = "", Location = "", StartDate = DateTime.Now },
                new Event {Name = "", Description = "", Plan = "", Sponsor = "", Speaker = "", Location = "", StartDate = DateTime.Now }
            });
            context.SaveChanges();
        }
    }
}
