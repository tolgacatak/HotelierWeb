using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusChangeApproved2(int id);
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeWait(int id);
        int GetBookingCount();
        List<Booking> Last6Bookings();
        
    }
}
