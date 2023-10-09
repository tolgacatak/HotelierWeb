using Hotel.BusinessLayer.Abstract;
using Hotel.DataAccessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BusinessLayer.Concrete
{
    public class CrewManager : ICrewService
    {
        private readonly ICrewDal _crewDal;

        public CrewManager(ICrewDal crewDal)
        {
            _crewDal = crewDal;
        }

        public void TDelete(Crew t)
        {
            _crewDal.Delete(t);  
        }

        public Crew TGetByID(int id)
        {
            return _crewDal.GetByID(id);
        }

        public int TGetCrewCount()
        {
            return _crewDal.GetCrewCount();
        }

        public List<Crew> TGetList()
        {
            return _crewDal.GetList();
        }

        public void TInsert(Crew t)
        {
            _crewDal.Insert(t);
        }

        public List<Crew> TLast4Crew()
        {
            return _crewDal.Last4Crew();
        }

        public void TUpdate(Crew t)
        {
            _crewDal.Update(t);
        }
    }
}
