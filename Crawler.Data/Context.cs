using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Data
{
    public class Context : DbContext
    {
        public Context()
            : base()
        {

        }
        public DbSet<Game> Games { get; set; }
    }
}
