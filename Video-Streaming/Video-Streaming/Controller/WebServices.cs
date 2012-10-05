using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Streaming.DataModel;

namespace Video_Streaming
{
    class WebServices
    {
        public IList<StreamModel> getStreamList()
        {
            List<StreamModel> streamModels = new List<StreamModel>();
            StreamModel model = new StreamModel();
            model.name = "test";
            model.title = "title test";
            streamModels.Add(model);

            return streamModels;
        }
    }
}
