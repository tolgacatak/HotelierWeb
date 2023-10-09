using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DataAccessLayer.Abstract;
using Hotel.DataAccessLayer.Concrete;
using Hotel.DataAccessLayer.Repositories;
using Hotel.EntityLayer.Concrete;

namespace Hotel.DataAccessLayer.EntityFramework
{
    public class EfCrewDal : GenericRepository<Crew>, ICrewDal
    {
        public EfCrewDal(Context context) : base(context)
        {

        }

        public int GetCrewCount()
        {
            using var context = new Context();
            var value = context.Crews.Count();
            return value;
        }

        public List<Crew> Last4Crew()
        {
            using var context = new Context();
            var values = context.Crews.OrderByDescending(x => x.CrewID).Take(4).ToList();
            return values;
        }
    }
}
