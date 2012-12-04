using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSCD.Common;
using NLog;
using SuperMap.Data;

namespace MSCD.GIS
{
    public class WorkspaceService
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static Workspace _workspace;
        private WorkspaceService()
        {
            _workspace = InitWorkspace();
        }
        public static readonly WorkspaceService Instance=new WorkspaceService();

        private static Workspace InitWorkspace()
        {
            try
            {
                var workspace = new Workspace();
                var workspaceConnectionInfo = new WorkspaceConnectionInfo
                {
                    Type = WorkspaceType.SQL,
                    Driver = ConfigHelper.GetConfig("WorkspaceDriver"),
                    Server = ConfigHelper.GetConfig("WorkspaceServer"),
                    Database = ConfigHelper.GetConfig("WorkspaceDatabase"),
                    Name = ConfigHelper.GetConfig("WorkspaceName"),
                    User = ConfigHelper.GetConfig("WorkspaceUser"),
                    Password = ConfigHelper.GetConfig("WorkspacePassword")
                };
                if (workspace.Open(workspaceConnectionInfo))
                {
                    return workspace;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("打开工作空间失败:{0}",ex));
            }
            return null;
        }

        public  Workspace GetWorkspace()
        {
            return _workspace;
        }

        public Dataset GetDataset(string datasourceName, string datasetName)
        {
            return _workspace.Datasources[datasourceName].Datasets[datasetName];
        }

    }
}
