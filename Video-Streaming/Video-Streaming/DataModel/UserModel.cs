using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Video_Streaming.DataModel
{
    class UserModel
    {
        [JsonProperty("embed_code")]
        public string embedCode { get; set; }

        [JsonProperty]
        public string location { get; set; }

        [JsonProperty("pro_account")]
        public bool proAccount { get; set; }

       [JsonProperty("image_url_tiny")]
        public string imageUrlTiny { get; set; }

        [JsonProperty("image_url_huge")]
        public string imageUrlHuge { get; set; }

        [JsonProperty]
        public string sex { get; set; }

        [JsonProperty]
        public int id { get; set; }

        [JsonProperty]
        public string broadcaster { get; set; }

        [JsonProperty("image_url_large")]
        public string imageUrlLarge { get; set; }

        [JsonProperty("image_url_small")]
        public string imageUrlSmall { get; set; }

        [JsonProperty]
        public string name { get; set; }

        [JsonProperty("image_url_medium")]
        public string imageUrlMedium { get; set; }

        [JsonProperty]
        public string login { get; set; }

        [JsonProperty("favorite_quotes")]
        public string favoriteQuotes { get; set; }
    }
}
