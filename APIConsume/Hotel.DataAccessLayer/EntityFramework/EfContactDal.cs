using Hotel.DataAccessLayer.Abstract;
using Hotel.DataAccessLayer.Concrete;
using Hotel.DataAccessLayer.Repositories;
using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contac>, IContacDal
    {
        public EfContactDal(Context context) : base(context)
        {
        }

        public int GetContactCount()
        {
            var context = new Context();
            var value = context.Contacs.Count();
            return value;
        }
    }
}
