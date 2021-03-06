﻿using System.ServiceModel;
using System.ServiceModel.Activation;
using WebConnect.Core;

namespace WebConnect.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public abstract class AbstractService
    {
    }

    public abstract class AbstractService<TClass> : AbstractService where TClass : class  
    {
        public TObj Invoke<TObj>() where TObj : class => AppCtx.Resolve<TObj>();
        public TClass Invoke() => AppCtx.Resolve<TClass>();
    }
}