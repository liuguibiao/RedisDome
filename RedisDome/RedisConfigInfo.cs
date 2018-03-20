using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace RedisDome
{
    public class RedisConfigInfo
    {
        public static string WriteServerList = ConfigurationManager.AppSettings["WriteServerList"];
        public static string ReadServerList = ConfigurationManager.AppSettings["ReadServerList"];
        public static int MaxWritePoolSize = Convert.ToInt32(ConfigurationManager.AppSettings["MaxWritePoolSize"]);
        public static int MaxReadPoolSize = Convert.ToInt32(ConfigurationManager.AppSettings["MaxReadPoolSize"]);
        public static int LocalCacheTime = Convert.ToInt32(ConfigurationManager.AppSettings["LocalCacheTime"]);
        public static bool AutoStart = ConfigurationManager.AppSettings["AutoStart"].Equals("true") ? true : false;
    }
}