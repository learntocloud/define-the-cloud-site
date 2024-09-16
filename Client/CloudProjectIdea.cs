using Newtonsoft.Json;

namespace BlazorBasic
{
    public class CloudProjectIdea
    {
        
            public string? Title { get; set; }
            public string? Description { get; set; }
            public List<string>? Steps { get; set; }

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Resources { get; set; } = new List<string>();


        
    }
}
