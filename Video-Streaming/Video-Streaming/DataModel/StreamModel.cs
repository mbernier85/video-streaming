using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Streaming.Data
{
    [Windows.Foundation.Metadata.WebHostHidden]
    class StreamModel : Video_Streaming.Common.BindableBase
    {

        [JsonProperty]
        public ChannelModel channel { get; set; }

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

        [JsonProperty("channel_count")]
        public int channelCount { get; set; }

        [JsonProperty]
        public string format { get; set; }

        [JsonProperty]
        public bool featured { get; set; }

        [JsonProperty("site_count")]
        public string siteCount { get; set; }

        [JsonProperty("abuse_reported")]
        public bool abuseReported { get; set; }

        [JsonProperty("video_height")]
        public int videoHeight { get; set; }

        [JsonProperty]
        public string language { get; set; }

        [JsonProperty("video_bitrate")]
        public double videoBitrate { get; set; }

        [JsonProperty]
        public string id { get; set; }

        [JsonProperty("meta_game")]
        public string metaGame { get; set; }

        [JsonProperty]
        public string broadcaster { get; set; }

        [JsonProperty("broadcaster_part")]
        public int broadcastPart { get; set; }

        [JsonProperty("audio_codec")]
        public string audioCodec { get; set; }

        [JsonProperty("up_time")]
        public string upTime { get; set; }

        [JsonProperty("video_width")]
        public int videoWidth { get; set; }

        [JsonProperty]
        public string geo { get; set; }

        [JsonProperty("channel_view_count")]
        public int channelViewCount { get; set; }

        [JsonProperty("channel_subscription")]
        public bool channelSubscription { set; get; }

        [JsonProperty("embed_enabled")]
        public bool embedEnabled { get; set; }

        [JsonProperty("stream_type")]
        public string streamType { get; set; }

        [JsonProperty("video_codec")]
        public string videoCodec { get; set; }



    }
}
