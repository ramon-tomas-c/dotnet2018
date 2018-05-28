using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    public BeersContext db { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        var data = db.Beers.AsQueryable().Select(s =>
                new Beer()
                {
                    Id = s.Id,
                    Code = s.Code,
                    Country = s.Country,
                    Name = s.Name,
                    ImageUrl = $"{AppConfiguration.BlobStorageUrl}{s.Code}.jpg"

                }).ToList();

        beerList.DataSource = data;
        beerList.DataBind();
    }
}