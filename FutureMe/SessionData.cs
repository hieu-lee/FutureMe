using FutureMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Blazored.LocalStorage;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace FutureMe
{
    public class SessionData
    {
        public static string SessionKey = "FutureMeClientUserSessionKey";
        public Account MyAccount { get; set; }
        public string Key { get; set; }
        public bool Logged => (MyAccount is not null);
        public void ClearData()
        {
            MyAccount = null;
            Key = string.Empty;
        }
    }
}
