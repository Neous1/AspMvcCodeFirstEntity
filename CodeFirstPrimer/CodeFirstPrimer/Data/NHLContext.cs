using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstPrimer.Data
{
    public class NHLContext: DbContext
    {
        public NHLContexContext() : base("DefaultConnection")
        {
            
        }
    }
}