﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EntityLayer.Concrete
{
    public class MessageCategory
    {
        public int MessageCategoryID { get; set; }
        public string MessageCategoryName { get; set; }
        public List<Contac> Contacs { get; set; }
    }
}
