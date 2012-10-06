using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Streaming.DataModel;

namespace Video_Streaming
{
    class Justin
    {
        public class Stream {
            public static IEnumerable<StreamModel> List() {
                List<StreamModel> streamModels = new List<StreamModel>();
                StreamModel model = new StreamModel();
                model.name = "test";
                model.title = "title test";
                streamModels.Add(model);

                return streamModels;            
            }
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
