using HomeFinder.Domain.Models;
using HtmlAgilityPack;
using System;
using System.Data.SqlTypes;
using System.Net;
using System.Reflection.Emit;
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
        public IEnumerable<House> PerformSearch(string searchURL)
        {
            var houses = new List<House>();
            var house = new House("https://www.youtube.com/?app", "450€", "2€", "2οs", "Kamares", "#;3", "#;1", "#;1700");

            houses.Add(house);
            house = new House("https://gg.deals/", "300€", "6€", "3ο", "Aigio", "#;1", "#;4", "#;1800");

            houses.Add(house);
            return houses;
            /*
            HtmlDocument document = new();

            DownloadPageData(ref document, searchURL);

            foreach (var item in document.DocumentNode.SelectNodes("//div[contains(@class, 'common-ad-body grid-y align-justify')]"))
            {
                var ancestors = item.Ancestors();
                var linkNode = item.SelectSingleNode("./a/@href");
                var url = linkNode.GetAttributeValue("href", string.Empty);

                var price = item.SelectSingleNode(".//span[contains(@class, 'property-ad-price')]").InnerHtml;
                var pricesqm = item.SelectSingleNode(".//span[contains(@class, 'property-ad-price-per-sqm')]").InnerHtml;
                var level = item.SelectSingleNode("//span[contains(@class, 'property-ad-level')]").InnerHtml;
                var address = item.SelectSingleNode("//span[contains(@class, 'common-property-ad-address')]").InnerHtml;

                var child = item.ChildNodes[1];
                var bedrooms = child.SelectSingleNode("//div[@class='common-property-ad-details grid-x']/div[@class='grid-x property-ad-bedrooms-container']/span").GetDirectInnerText();
                var bathrooms = child.SelectSingleNode("//div[@class='common-property-ad-details grid-x']/div[@class='grid-x property-ad-bathrooms-container']/span").GetDirectInnerText();
                var year = child.SelectSingleNode("//div[@class='common-property-ad-details grid-x']/div[@class='grid-x property-ad-construction-year-container']/span").GetDirectInnerText();

                var home = new House(url, price, pricesqm, level, address, bedrooms, bathrooms, year);

                houses.Add(home);
            }

            return houses;
            */
        }
        public void DownloadPageData(ref HtmlDocument document, string url)
        {
            // creating the HAP object 
            var web = new HtmlWeb();

            // Create a web page loader class.
            try
            {
                document = web.Load(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
