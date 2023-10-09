﻿using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void TBookingStatusChangeApproved2(int id);
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeWait(int id);
        int TGetBookingCount();
        List<Booking> TLast6Bookings();
    }
}
