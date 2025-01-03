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
    public class EfSliderDal : GenericRepository<Slider>, ISliderDal
    {
        public EfSliderDal(PerispanyaContext context) : base(context)
        {
        }
    }
}
