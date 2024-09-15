using HomeFinder.Domain.Models;
using System.Data.SqlTypes;
using System.Text;

namespace HomeFinder.Domain.Services
{
    public class SearchServices : ISearchServices
    {
        public string CreateSearchURL(QueryField queryField)
        {
            StringBuilder url = new StringBuilder();

            url.Append(string.Format("https://www.xe.gr/property/results?geo_lat_from={0}&geo_lat_to={1}&geo_lng_from={2}&geo_lng_to={3}", 
                queryField.Geo_lat_from, queryField.Geo_lat_to, queryField.Geo_lng_from, queryField.Geo_lng_to));
            url.Append("&item_type = re_residence&transaction_name=rent");

            if (queryField.MinPrice != 0)
            {
                url.Append(string.Format("&minimum_price={0}", queryField.MinPrice));
            }
            if (queryField.MaxPrice != 0)
            {
                url.Append(string.Format("&maximum_price={0}", queryField.MaxPrice));
            }

            if (queryField.MinLevel != 0)
            {
                url.Append(string.Format("&minimum_level={0}", queryField.MinLevel));
            }
            if (queryField.MaxLevel != 0)
            {
                url.Append(string.Format("&maximum_level={0}", queryField.MaxLevel));
            }

            if (queryField.MinSize != 0)
            {
                url.Append(string.Format("&minimum_size={0}", queryField.MinSize));
            }
            if (queryField.MaxSize != 0)
            {
                url.Append(string.Format("&maximum_size={0}", queryField.MaxSize));
            }

            if (queryField.MinBedrooms != 0)
            {
                url.Append(string.Format("&minimum_bedrooms={0}", queryField.MinBedrooms));
            }
            if (queryField.MaxBedrooms != 0)
            {
                url.Append(string.Format("&maximum_bedrooms={0}", queryField.MaxBedrooms));
            }

            if (queryField.MinConstruction_year != 1899)
            {
                url.Append(string.Format("&minimum_construction_year={0}", queryField.MinConstruction_year));
            }
            if (queryField.MaxConstruction_year != 1899)
            {
                url.Append(string.Format("&maximum_construction_year={0}", queryField.MaxConstruction_year));
            }

            if (queryField.MinPricePerUnitArea != 0)
            {
                url.Append(string.Format("&minimum_price_per_unit_area={0}", queryField.MinPricePerUnitArea));
            }
            if (queryField.MaxPricePerUnitArea != 0)
            {
                url.Append(string.Format("&maximum_price_per_unit_area={0}", queryField.MaxPricePerUnitArea));
            }

            if (queryField.MinEnergyClass != "No Preference")
            {
                url.Append(string.Format("&minimum_energy_class={0}", queryField.MinEnergyClass));
            }
            if (queryField.MaxEnergyClass != "No Preference")
            {
                url.Append(string.Format("&maximum_energy_class={0}", queryField.MaxEnergyClass));
            }

            if (queryField.Availability[0] != "")
            {
                url.Append(string.Format("&building_availability_options={0}", queryField.Availability[0]));
            }
            if (queryField.Availability[1] != "")
            {
                url.Append(string.Format("&building_availability_options={0}", queryField.Availability[1]));
            }

            String FinalUrl = url.ToString();

            return FinalUrl;
        }
    }
}
