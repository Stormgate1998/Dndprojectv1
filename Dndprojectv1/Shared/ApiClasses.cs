using System.Text.Json.Serialization;
namespace Dndprojectv1.Shared
{


    public class ApiClasses
    {

        public class Rootobject
        {
            [JsonIgnore]
            public int count { get; set; }
            public Result[] results { get; set; }
        }

        public class Result
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

    }
}
