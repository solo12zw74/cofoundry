﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofoundry.Core.DependencyInjection;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

namespace Cofoundry.Domain
{
    public class ModelMetadataDependencyRegistration : IDependencyRegistration
    {
        public void Register(IContainerRegister container)
        {
            container
                .RegisterInstance<CofoundryDisplayMetadataProvider>()
                .RegisterAll<IModelMetadataDecorator>(RegistrationOptions.SingletonScope())
                ;
        }
    }
}
