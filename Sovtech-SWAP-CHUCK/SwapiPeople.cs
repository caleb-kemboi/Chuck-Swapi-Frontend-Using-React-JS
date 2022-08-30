namespace Sovtech_SWAP_CHUCK
{
    public class SwapiPeople
    {
        public class PeopleResult
        {
            public string name { get; set; }
            public string height { get; set; }
            public string mass { get; set; }
            public string hair_color { get; set; }
            public string skin_color { get; set; }
            public string eye_color { get; set; }
            public string birth_year { get; set; }
            public string gender { get; set; }
            public string homeworld { get; set; }
            public List<string> films { get; set; }
            public List<string> species { get; set; }
            public List<string> vehicles { get; set; }
            public List<string> starships { get; set; }
            public DateTime created { get; set; }
            public DateTime edited { get; set; }
            public string url { get; set; }
        }

        public class PeopleResponse
        {
            public int count { get; set; }
            public string next { get; set; }
            public object previous { get; set; }
            public List<PeopleResult> results { get; set; }
        }

        public class CategoryResult
        {
            public List<object> categories { get; set; }
            public string created_at { get; set; }
            public string icon_url { get; set; }
            public string id { get; set; }
            public string updated_at { get; set; }
            public string url { get; set; }
            public string value { get; set; }
        }

        public class CategoryResponse
        {
            public int total { get; set; }
            public List<CategoryResult> result { get; set; }
        }

    }
}