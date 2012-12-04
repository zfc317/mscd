using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperMap.Data;

namespace MSCD.GIS
{
    public class GISUtility
    {
        public static Dictionary<string,string> RecordsetToDictionary(Recordset rs)
        {
            var values =new Dictionary<string, string>();
            var fieldInfos = rs.GetFieldInfos();
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                if (fieldInfo.IsSystemField) continue;
                var value = rs.GetFieldValue(fieldInfo.Name);
                var valueStr = "";
                if(value!=null)
                {
                    valueStr = value.ToString();
                }
                values.Add(fieldInfo.Name, valueStr);
            }
            return values;
        }
    }
}
