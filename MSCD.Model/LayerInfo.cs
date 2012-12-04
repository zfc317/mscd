using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSCD.Model
{
    public class LayerInfo
    {
        public string LayerName { get; set; }
        public string LayerCaption { get; set; }
        public bool Queryable { get; set; }
        public List<FieldInfo> FieldInfos { get; set; } 
    }
}
