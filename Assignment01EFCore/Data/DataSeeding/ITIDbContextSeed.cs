using Assignment01EFCore.Data.Models;
using Assignment02EFCore.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment02EFCore.Data.DataSeeding
{
    internal static class ITIDbContextSeed
    {
        public static bool SeedData<TEntity>(ITIDbContext iTIDbContext , string path) where TEntity : class
        {
			try
			{
				if(!iTIDbContext.Set<TEntity>().Any())
				{
					var EntityJson = File.ReadAllText(path);
					var Record = JsonSerializer.Deserialize<List<TEntity>>(EntityJson);
					if(Record?.Count() > 0)
					{
						iTIDbContext.Set<TEntity>().AddRange(Record);
						iTIDbContext.SaveChanges();
					}
				}
				return true;
			}
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding {typeof(TEntity).Name}: {ex.Message}");
                return false;
            }
        }

    }
}
