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
    public class ContacManager : IContacService

    {
        private readonly IContacDal _contectDal;

        public ContacManager(IContacDal contectDal)
        {
           _contectDal = contectDal;
        }

        public void TDelete(Contac t)
        {
            _contectDal.Delete(t);
        }

        public Contac TGetByID(int id)
        {
            return _contectDal.GetByID(id);
        }

        public int TGetContactCount()
        {
            return _contectDal.GetContactCount();
        }

        public List<Contac> TGetList()
        {
            return _contectDal.GetList();
        }

        public void TInsert(Contac t)
        {
            _contectDal.Insert(t);
        }

        public void TUpdate(Contac t)
        {
            _contectDal.Update(t);
        }
    }
}
