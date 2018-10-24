using FodyPermissionsSpike.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FodyPermissionsSpike
{
    public class BizFilter
    {
        private readonly PermissionsResolver permissionsResolver;
        private readonly UserResolver userResolver;

        public BizFilter(PermissionsResolver permissionsResolver, UserResolver userResolver)
        {
            this.permissionsResolver = permissionsResolver;
            this.userResolver = userResolver;
        }

        public bool CheckPermissions(MethodBase methodBase)
        {
            var user = userResolver.GetUser();
            
            var methodName = $"{methodBase.DeclaringType.FullName}{methodBase.Name}";
            return permissionsResolver.CanInvoke(user, methodName);
        }
    }
}
