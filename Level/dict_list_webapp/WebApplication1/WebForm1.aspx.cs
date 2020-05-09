using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Country country1 = new Country()
            {
                Code = "AUS",
                Name = "AUSTRALIA",
                Capital = "Canberra"
            };

            Country country2 = new Country()
            {
                Code = "IND",
                Name = "INDIA ",
                Capital = "New Delhi"
            };

            Country country3 = new Country()
            {
                Code = "USA",
                Name = "UNITED STATES",
                Capital = "Washington D.C."
            };

            Country country4 = new Country()
            {
                Code = "GBR",
                Name = "UNITED KINGDOM",
                Capital = "London"
            };

            Country country5 = new Country()
            {
                Code = "CAN",
                Name = "CANADA",
                Capital = "Ottawa"
            };

            //List<Country> listCountries = new List<Country>();
            //listCountries.Add(country1);
            //listCountries.Add(country2);
            //listCountries.Add(country3);
            //listCountries.Add(country4);
            //listCountries.Add(country5);

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);

            Session["CountriesData"] = dictionaryCountries;
        }
    }

    protected void txtCountryCode_TextChanged(object sender,EventArgs e)
    {
        Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>
        Country resultCountry = dictionaryCountries.ContainsKey(txtCountry.Text.ToUpper() ? dictionaryCountries[strCountryCode] : null;

        if (resultCountry == null)
        {
            
        }
        else
        {
            Console.WriteLine("Name = " + resultCountry.Name + " Captial =" + resultCountry.Capital);
        }

    }


}