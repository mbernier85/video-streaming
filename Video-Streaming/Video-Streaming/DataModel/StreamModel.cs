using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Streaming.DataModel
{
    class StreamModel
    {
        [JsonProperty("embed_count")]
        public string embedCount { get; set; }

        [JsonProperty]
        public string name { get; set; }

        [JsonProperty("stream_count")]
        public string streamCount { get; set; }

        [JsonProperty]
        public string category { get; set; }

        [JsonProperty]
        public string title { get; set; }
    }
}
