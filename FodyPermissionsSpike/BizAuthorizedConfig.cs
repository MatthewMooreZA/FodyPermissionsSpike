using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FodyPermissionsSpike
{
    public static class BizAuthorizedConfig
    {
        public static void Setup(Func<Func<MethodBase, bool>> func)
        {
            BizAuthorizedAttribute.Filter = func;
        }

        //public static void SetupAlternative<T>(IServiceProvider serviceProvider)
        //{
        //    Setup(() =>
        //    {
        //        serviceProvider.GetService(typeof(T)).CheckPermissions
        //    });
        //}   WHERE T impkements CheckPermissions or something to that effect
    }
}
