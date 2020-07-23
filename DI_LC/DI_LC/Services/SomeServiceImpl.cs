using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_LC.Services
{
    public class SomeServiceImpl : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public SomeServiceImpl()
        {
            id = Guid.NewGuid();
        }
        public Guid GetID()
        {
            return id;
        }

    }
}
