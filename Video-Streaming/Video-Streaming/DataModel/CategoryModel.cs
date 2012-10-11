using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Streaming.DataModel
{
    class CategoryModel
    {
        public IEnumerable<StreamModel> Stream { get; set; }
        public String Title { get; set; }
    
    }
}
