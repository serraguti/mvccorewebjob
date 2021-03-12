using MvcCoreWebJob.Data;
using MvcCoreWebJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreWebJob.Repositories
{
    public class RepositoryChollos
    {
        ChollosContext context;

        public RepositoryChollos(ChollosContext context)
        {
            this.context = context;
        }

        public List<Chollo> GetChollos()
        {
            return this.context.Chollos.ToList();
        }
    }
}
