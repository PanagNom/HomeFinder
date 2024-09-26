namespace HomeFinder.Domain.Models
{
    public class House
    {
        public string Url { get; set; }
        public string Address { get; set; }
        public ushort Price { get; set; }
        public ushort PricePerSqr { get; set; }
        public ushort Level { get; set; }
        public ushort Bedrooms { get; set; }
        public ushort Bathrooms { get; set; }
        public ushort ConstructionYear { get; set; }
        public string ImageUrl { get; set; }

        public House(string url, string price, string pricePerSqr, string level, string address, string bedrooms, string bathrooms, string constructionYear)
        {
            ImageUrl = "https://a2.xe.gr/20240921/171236_375684_1000_750.webp";
            Url = url.Trim(); 
            Address = address.Trim();
            
            price = price.Remove(price.IndexOf('€')).Trim();
            price = price.Replace(".", "");
            Price = Convert.ToUInt16(price);

            pricePerSqr = pricePerSqr.Trim();
            pricePerSqr = pricePerSqr.Remove(pricePerSqr.IndexOf('€')).Trim();
            pricePerSqr = pricePerSqr.Replace(".", "");
            PricePerSqr = Convert.ToUInt16(pricePerSqr);

            Level = Convert.ToUInt16(level.Trim().Remove(level.Trim().IndexOf('ο')));
            Bedrooms = Convert.ToUInt16(bedrooms.Split(';')[1]);
            Bathrooms = Convert.ToUInt16(bathrooms.Split(';')[1]);
            ConstructionYear = Convert.ToUInt16(constructionYear.Split(';')[1]);
        }
    }
}
