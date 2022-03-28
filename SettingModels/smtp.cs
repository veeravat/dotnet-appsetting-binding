using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestedConfig_dotnet.SettingModels
{
    public class SettingTest
    {
        public Smtp Smtp { get; set; }
    }

    public class Smtp
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public bool RequireAuthentication { get; set; }
        public bool EnableSsl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}