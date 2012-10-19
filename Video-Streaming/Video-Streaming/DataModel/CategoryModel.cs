using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Streaming.Data
{
    class CategoryModel : Video_Streaming.Common.BindableBase
    {
        public IEnumerable<StreamModel> Stream { get; set; }
        public String Title { get; set; }
    }
}
