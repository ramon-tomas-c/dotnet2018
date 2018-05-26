using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var data = new List<Beer>()
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

        var dataFinal = data.AsQueryable().Select(s =>
                new Beer()
                {
                    Id = s.Id,
                    Code = s.Code,
                    Country = s.Country,
                    Name = s.Name,
                    ImageUrl = "https://dotnet2018dockerdemo.blob.core.windows.net/beers/" + s.Code + ".jpg"

                }).ToList();

        beerList.DataSource = dataFinal;
        beerList.DataBind();
    }
}