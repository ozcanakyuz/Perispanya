using Perispanya.DataAccessLayer.Abstract;
using Perispanya.DataAccessLayer.Context;
using Perispanya.DataAccessLayer.Repositories;
using Perispanya.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perispanya.DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(PerispanyaContext context) : base(context)
        {
        }
    }
}
