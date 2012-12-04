using System;
using System.Configuration;
using NLog;

namespace MSCD.Common
{
    /// <summary>
    /// web.config操作类
    /// Copyright (C) Maticsoft
    /// </summary>
    public sealed class ConfigHelper
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 获取配置文件节点信息
        /// </summary>
        /// <param name="cfgName">配置名称</param>
        /// <returns>配置值</returns>
        public static string GetConfig(string cfgName)
        {
            var cfgValue = "";
            try
            {
                cfgValue = ConfigurationManager.AppSettings[cfgName];
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取'{0}'配置发生错误{1}", cfgName, ex));
            }
            return cfgValue;
        }

        /// <summary>
        /// 设置配置文件节点信息
        /// </summary>
        /// <param name="cfgName">配置名称</param>
        /// <param name="cfgValue">配置值</param>
        public static void SetConfig(string cfgName, string cfgValue)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove(cfgName);
                config.AppSettings.Settings.Add(cfgName, cfgValue);
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("设置{0}配置失败:{1}", cfgName,ex));
            }
            
        }
    }
}
