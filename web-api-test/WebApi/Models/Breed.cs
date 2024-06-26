namespace WebApi.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Attributes
    {
        public string name { get; set; }
        public int min_life { get; set; }
        public int max_life { get; set; }
        public string description { get; set; }
        public bool hypoallergenic { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
    }

    public class Breed
    {
        public Data data { get; set; }
        public Links links { get; set; }
    }


}
