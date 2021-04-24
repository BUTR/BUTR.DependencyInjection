﻿// <auto-generated>
//   This code file has automatically been added by the "BUTR.DependencyInjection" NuGet package (https://www.nuget.org/packages/BUTR.DependencyInjection).
//   Please see https://github.com/BUTR/BUTR.DependencyInjection for more information.
//
//   IMPORTANT:
//   DO NOT DELETE THIS FILE if you are using a "packages.config" file to manage your NuGet references.
//   Consider migrating to PackageReferences instead:
//   https://docs.microsoft.com/en-us/nuget/consume-packages/migrate-packages-config-to-package-reference
//   Migrating brings the following benefits:
//   * The "Harmony.Extensions" folder and the "SymbolExtensions2.cs" file don't appear in your project.
//   * The added file is immutable and can therefore not be modified by coincidence.
//   * Updating/Uninstalling the package will work flawlessly.
// </auto-generated>

#region License
// MIT License
//
// Copyright (c) Bannerlord's Unofficial Tools & Resources
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

#if !BUTRDEPENDENCYINJECTION_DISABLE
#nullable enable
#if !BUTRDEPENDENCYINJECTION_ENABLEWARNINGS
#pragma warning disable
#endif

namespace BUTR.DependencyInjection.LightInject
{
    using global::BUTR.DependencyInjection.LightInject.LightInject;
    using global::BUTR.DependencyInjection.Logger;
    using global::System;
    using global::System.Linq;

    internal class LightInjectServiceContainer : IGenericServiceContainer
    {
        private readonly IServiceContainer _serviceContainer;

        public LightInjectServiceContainer(IServiceContainer serviceContainer) => _serviceContainer = serviceContainer;

        public IGenericServiceContainer RegisterSingleton<TService>() where TService : class
        {
            _serviceContainer.RegisterSingleton<TService>();
            return this;
        }

        public IGenericServiceContainer RegisterSingleton<TService>(Func<IGenericServiceFactory, TService> factory) where TService : class
        {
            _serviceContainer.RegisterSingleton(lightInjectFactory => factory(new LightInjectGenericServiceFactory(lightInjectFactory)));
            return this;
        }

        public IGenericServiceContainer RegisterSingleton<TService, TImplementation>() where TService : class where TImplementation : class, TService
        {
            _serviceContainer.RegisterSingleton<TService, TImplementation>();
            return this;
        }

        public IGenericServiceContainer RegisterScoped<TService>() where TService : class
        {
            _serviceContainer.RegisterScoped<TService>();
            return this;
        }

        public IGenericServiceContainer RegisterScoped<TService>(Func<IGenericServiceFactory, TService> factory) where TService : class
        {
            _serviceContainer.RegisterScoped(lightInjectFactory => factory(new LightInjectGenericServiceFactory(lightInjectFactory)));
            return this;
        }

        public IGenericServiceContainer RegisterScoped<TService, TImplementation>() where TService : class where TImplementation : class, TService
        {
            _serviceContainer.RegisterScoped<TService, TImplementation>();
            return this;
        }

        public IGenericServiceContainer RegisterTransient(Type serviceType, Type implementationType)
        {
            _serviceContainer.RegisterTransient(serviceType, implementationType);
            return this;
        }

        public IGenericServiceContainer RegisterTransient<TService>() where TService : class
        {
            _serviceContainer.RegisterTransient<TService>();
            return this;
        }

        public IGenericServiceContainer RegisterTransient<TService>(Func<IGenericServiceFactory, TService> factory) where TService : class
        {
            _serviceContainer.RegisterTransient(lightInjectFactory => factory(new LightInjectGenericServiceFactory(lightInjectFactory)));
            return this;
        }

        public IGenericServiceContainer RegisterTransient<TService, TImplementation>() where TService : class where TImplementation : class, TService
        {
            _serviceContainer.RegisterTransient<TService, TImplementation>();
            return this;
        }

        public IGenericServiceContainer RegisterTransient(Type serviceType, Func<object> factory)
        {
            _serviceContainer.RegisterTransient(serviceType, _ => factory());
            return this;
        }

        public IGenericServiceContainer RegisterTransient<TService>(Func<TService> factory) where TService : class
        {
            _serviceContainer.RegisterTransient<TService>(_ => factory());
            return this;
        }

        public IGenericServiceProvider Build()
        {
            if (_serviceContainer.AvailableServices.All(s => s.ServiceType != typeof(IBUTRLogger)))
            {
                _serviceContainer.RegisterTransient<IBUTRLogger, DefaultBUTRLogger>();
            }
            if (_serviceContainer.AvailableServices.All(s => s.ServiceType != typeof(IBUTRLogger<>)))
            {
                _serviceContainer.RegisterTransient(typeof(IBUTRLogger<>), typeof(DefaultBUTRLogger<>));
            }

            _serviceContainer.Compile();
            return new LightInjectGenericServiceProvider(_serviceContainer);
        }
    }
}

#pragma warning restore
#nullable restore
#endif // BUTRDEPENDENCYINJECTION_DISABLE