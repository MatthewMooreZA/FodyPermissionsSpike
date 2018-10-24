using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FodyPermissionsSpike.Services
{
    public class PermissionsResolver
    {
        private Dictionary<string, List<string>> permissions = new Dictionary<string, List<string>>();

        public PermissionsResolver()
        {
            permissions.Add("User1", new List<string>
            {
                "Class.Method(, Assembly maybe?)",
                "FodyPermissionsSpike.ExampleBusinessServiceReleaseTheHounds"
            });
        }

        // this should ingest a fully loaded user object with roles etc.
        // for now we are going to be permissions based on the name
        // but this is obv a contrived example.
        public bool CanInvoke(string user, string methodName)
        {
            return true;
            if (permissions.ContainsKey(user))
            {
                return permissions[user].Any(x => x == methodName);
            }
            return false;
        }
    }
}
