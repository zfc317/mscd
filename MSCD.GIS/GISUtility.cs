using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MSCD.Model;
using SuperMap.Data;
using FieldInfo = SuperMap.Data.FieldInfo;

namespace MSCD.GIS
{
    public class GISUtility
    {
        public static DataTable RecordsetToDataTable(Recordset rs,LayerInfo layerInfo)
        {
            var dt = CreateDataTableByLayerInfo(layerInfo);
            if (rs.IsEmpty) return dt;

            while (!rs.IsEOF)
            {
                var row = dt.NewRow();
                foreach (var fieldInfo in layerInfo.FieldInfos)
                {
                    var value = rs.GetFieldValue(fieldInfo.FieldName);
                    row[fieldInfo.FieldName] = value;
                }
                dt.Rows.Add(row);
                rs.MoveNext();
            }
            return dt;

        }

        private static DataTable CreateDataTableByLayerInfo(LayerInfo layerInfo)
        {
            var dt= new DataTable();
            foreach (var fieldInfo in layerInfo.FieldInfos)
            {
                dt.Columns.Add(new DataColumn() {Caption = fieldInfo.FieldCaption, ColumnName = fieldInfo.FieldName});
            }
            return dt;
        }
    }
}
