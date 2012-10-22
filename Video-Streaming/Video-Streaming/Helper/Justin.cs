using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Video_Streaming.Data;

namespace Video_Streaming
{
    class Justin : Video_Streaming.Common.BindableBase
    {
        private const string JUSTINTVAPI = "http://api.justin.tv/api/";
        

        public class Stream
        {
            public async static Task<Streams<StreamModel>> List()
            {
                string webText = await (new HttpClient()).GetStringAsync(JUSTINTVAPI + "stream/list.json");
                if (webText != null)
                {
                    return JsonConvert.DeserializeObject<Streams<StreamModel>>(webText);
                }
                return null;
            }

            /// <summary>
            /// Get aggregate information about all the streams (total viewers, total number of streams, average bitrate)
            /// </summary>
            /// <returns></returns>
            public void Summary() { }

            /// <summary>
            /// Register a callback url for stream events on a channel - you can register for stream_up and stream_down
            /// </summary>
            public void register_callback() { }

            /// Unregister a pre-registered callback
            public void unregister_callback() { }

            /// List all the callbacks currently registered on a given channel
            public void list_callbacks() { }


            /// Get information about the live stream results of a search query.
            public static void search() { }

        }

        public class User { }

        public class Channel { }

        public class Fan { }

        public class Clip { }

        public class Chat { }

        public class Account { }

        public class Category { }

    }
}
