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
                new Event {Name = "Собрание", Description = "Ежемесечне собрание", Plan = "1. Выполеные работы\n 2. Планировка задач", Sponsor = "ООО Техника", Speaker = "Все", Location = "Кабинет 103", StartDate = DateTime.Now },
                new Event {Name = "Собрание1", Description = "Ежемесечне собрание", Plan = "1. Выполеные работы\n 2. Планировка задач", Sponsor = "ООО Техника", Speaker = "Все", Location = "Кабинет 103", StartDate = DateTime.Now },
                new Event {Name = "Собрание2", Description = "Ежемесечне собрание", Plan = "1. Выполеные работы\n 2. Планировка задач", Sponsor = "ООО Техника", Speaker = "Все", Location = "Кабинет 103", StartDate = DateTime.Now },
                new Event {Name = "Собрание3", Description = "Ежемесечне собрание", Plan = "1. Выполеные работы\n 2. Планировка задач", Sponsor = "ООО Техника", Speaker = "Все", Location = "Кабинет 103", StartDate = DateTime.Now },
                new Event {Name = "Собрание4", Description = "Ежемесечне собрание", Plan = "1. Выполеные работы\n 2. Планировка задач", Sponsor = "ООО Техника", Speaker = "Все", Location = "Кабинет 103", StartDate = DateTime.Now },new Event {Name = "Собрание", Description = "Ежемесечне собрание", Plan = "1. Выполеные работы\n 2. Планировка задач", Sponsor = "ООО Техника", Speaker = "Все", Location = "Кабинет 103", StartDate = DateTime.Now },
                new Event {Name = "Собрание5", Description = "Ежемесечне собрание", Plan = "1. Выполеные работы\n 2. Планировка задач", Sponsor = "ООО Техника", Speaker = "Все", Location = "Кабинет 103", StartDate = DateTime.Now },
            });
            context.SaveChanges();
        }
    }
}
