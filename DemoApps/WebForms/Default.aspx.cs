using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class _Default : Page
    {
        public BeersContext db { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var data = db.Beers.AsNoTracking().ToList();
            var beers = data.Select(s =>
                    new BeerModel()
                    {
                        Id = s.Id,
                        Code = s.Code,
                        Country = s.Country,
                        Name = s.Name,
                        ImageUrl = $"{AppConfiguration.BlobStorageUrl}{s.Code}.jpg"

                    });

            beerList.DataSource = beers;
            beerList.DataBind();
        }
    }
}