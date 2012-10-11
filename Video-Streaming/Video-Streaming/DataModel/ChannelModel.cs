using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Streaming.Data
{
    class ChannelModel : Video_Streaming.Common.BindableBase
    {
        public ChannelModel()
        {

        }
     
        [JsonProperty("subcategory_title")]
        public string subcategoryTitle { get; set; }

        [JsonProperty]
        public string subcategory { get; set; }

        [JsonProperty("screen_cap_url_small")]
        public string screenCapUrlSmall { get; set; }

        [JsonProperty("screen_cap_url_medium")]
        public string screenCapUrlMedium { get; set; }

        [JsonProperty("screen_cap_url_huge")]
        public string screenCapUrlHuge { get; set; }

        [JsonProperty]
        public string status { get; set; }

        [JsonProperty]
        public string category { get; set; }

        [JsonProperty]
        public string title { get; set; }

        [JsonProperty("embed_code")]
        public string embedCode { get; set; }

        [JsonProperty]
        public bool producer { get; set; }

        [JsonProperty("image_url_tiny")]
        public string imageUrlTiny { get; set; }

        [JsonProperty("image_url_huge")]
        public string imageUrlHuge { get; set; }

        [JsonProperty("image_url_large")]
        public string imageUrlLarge { get; set; }

        [JsonProperty("image_url_small")]
        public string imageUrlSmall { get; set; }

        [JsonProperty("image_url_medium")]
        public string imageUrlMedium { get; set; }

        [JsonProperty]
        public string timezone { get; set; }

        [JsonProperty]
        public int id { get; set; }

        [JsonProperty("views_count")]
        public string viewsCount { get; set; }

        [JsonProperty("embed_enable")]
        public bool embedEnable { get; set; }

        [JsonProperty]
        public string login { get; set; }

        [JsonProperty]
        public string tags { get; set; }

        [JsonProperty]
        public string categoryTitle { get; set; }

        [JsonProperty("channel_url")]
        public string channelUrl { get; set; }

        [JsonProperty]
        public string language { get; set; }

        [JsonProperty]
        public bool? mature { get; set; }

    }
}
