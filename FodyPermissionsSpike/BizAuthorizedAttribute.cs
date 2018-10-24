using FodyPermissionsSpike;
using MethodDecorator.Fody.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

[module: BizAuthorized]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class)]
public class BizAuthorizedAttribute : Attribute, IMethodDecorator
{
    internal static Func<Func<MethodBase, bool>> Filter { get; set; }
    public void Init(object instance, MethodBase method, object[] args)
    {
        if (!Filter.Invoke().Invoke(method))
        {
            throw new UnauthorizedAccessException();
        }
    }

    public void OnEntry()
    {        
    }

    public void OnException(Exception exception)
    {      
    }

    public void OnExit()
    {        
    }
}

