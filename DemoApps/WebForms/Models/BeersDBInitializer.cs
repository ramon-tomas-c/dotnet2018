using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BeersDBInitializer
/// </summary>
public class BeersDBInitializer : CreateDatabaseIfNotExists<BeersContext>
{

    public BeersDBInitializer()
    {
    }

    protected override void Seed(BeersContext context)
    {
        AddBeers(context);
    }

    private void AddBeers(BeersContext context)
    {
        if (!context.Beers.Any())
        {
            context.Beers.AddRange(GetDefaultBeers());

            context.SaveChanges();
        }
    }

    private IEnumerable<Beer> GetDefaultBeers()
    {
        return new[]
        {
                new Beer()
                {
                    Name = "Guinness",
                    Country = "Ireland",
                    Code = "guinness"
                },
                new Beer()
                {
                    Name = "Blue Moon",
                    Country = "Belgium",
                    Code = "blue_moon"
                },
                new Beer()
                {
                    Name = "Dos Equis",
                    Country = "Mexico",
                    Code = "dos_equis"
                },
                new Beer()
                {
                    Name = "Fat Tire",
                    Country = "Belgium",
                    Code = "fat_tire"
                },
                new Beer()
                {
                    Name = "Heady Topper",
                    Country = "US",
                    Code = "heady_topper"
                },
                new Beer()
                {
                    Name = "Dogfish Head",
                    Country = "US",
                    Code = "dogfish_head"
                },
                new Beer()
                {
                    Name = "Goose Island",
                    Country = "US",
                    Code = "goose_island"
                },
                new Beer()
                {
                    Name = "Mikkeller",
                    Country = "Denmark",
                    Code = "mikkeller"
                },
                new Beer()
                {
                    Name = "Foster's Lager",
                    Country = "Australia",
                    Code = "foster's_lager"
                }
            };
    }
}