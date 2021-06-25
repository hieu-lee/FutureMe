using FutureMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureMe
{
    public class SessionData
    {
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
