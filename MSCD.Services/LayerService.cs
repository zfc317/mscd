using System;
using System.Collections.Generic;
using System.Xml.Linq;
using MSCD.Model;

namespace MSCD.Services
{
    public class LayerService
    {
        public static readonly LayerService INSTANCE=new LayerService();
        private readonly List<LayerInfo> _StationLayerInfos;
        private readonly List<LayerType> _StationLayerType;
        private readonly List<LayerCatalog> _StationLayerCatalogs; 
        private LayerService()
        {
            _StationLayerInfos = GetStationLayers();
            _StationLayerType = GetStationLayerType();
            _StationLayerCatalogs = GetStationLayerCatalog();
        }

        private List<LayerInfo> GetStationLayers()
        {
            var configBLLL = new BLL.Config();
            var layerInfoConfigModel = configBLLL.GetModel("stationLayer");
            return ParaseLayerInfo(layerInfoConfigModel.info);
        }

        private List<LayerType> GetStationLayerType()
        {
            var layerTypeBll = new BLL.LayerType();
            return layerTypeBll.GetModelList("");
        } 

        private List<LayerCatalog> GetStationLayerCatalog()
        {
            var layerCatalogBll = new BLL.LayerCatalog();
            return layerCatalogBll.GetModelList("");
        }

        private static List<LayerInfo> ParaseLayerInfo(string layerInfoXml)
        {
            var layerInfos = new List<LayerInfo>();
            var xDoc = XDocument.Parse(layerInfoXml);
            var layerEls = xDoc.Root.Elements("layer");
            foreach (var layerEl in layerEls)
            {
                var layerInfo = new LayerInfo
                                    {
                                        LayerCaption = layerEl.Attribute("caption").Value,
                                        LayerName = layerEl.Attribute("name").Value,
                                        Queryable = Convert.ToBoolean(layerEl.Attribute("queryable").Value)
                                    };
                var fieldEls = layerEl.Descendants("field");
                layerInfo.FieldInfos=new List<FieldInfo>();
                foreach (var fieldEl in fieldEls)
                {
                    var fieldInfo = new FieldInfo();
                    var attribute = fieldEl.Attribute("caption");
                    if (attribute != null)
                        fieldInfo.FieldCaption = attribute.Value;
                    var xAttribute = fieldEl.Attribute("name");
                    if (xAttribute != null) fieldInfo.FieldName = xAttribute.Value;
                    layerInfo.FieldInfos.Add(fieldInfo);
                }
                layerInfos.Add(layerInfo);
            }

            return layerInfos;
        } 

        public List<LayerInfo> GetStationLayerInfos()
        {
            return _StationLayerInfos;
        } 

        public List<LayerType> GetStationLayerTypes()
        {
            return _StationLayerType;
        } 

        public List<LayerCatalog> GetStationLayerCatalogs()
        {
            return _StationLayerCatalogs;
        } 
    }
}
