﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autofacsameple
{
    public static class Locator
    {
        private readonly static Dictionary<Type, Func<object>>
            services = new Dictionary<Type, Func<object>>();

        public static void Register<T>(Func<T> resolver)
        {
            Locator.services[typeof(T)] = () => resolver();
        }

        public static T Resolver<T>()
        {
            return (T)Locator.services[typeof(T)]();
        }

        public static void Reset()
        {
            Locator.services.Clear();
        }
    }
}
