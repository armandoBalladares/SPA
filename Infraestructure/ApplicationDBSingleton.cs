using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA.Infraestructure
{
    public class ApplicationDBSingleton
    {
        private static readonly SPA.Domain.ApplicationDbContext _context;
        public ApplicationDBSingleton() { }
        /*
        public static SPA.Domain.ApplicationDbContext getInstance() {
            if (_context == null)
            {
                _context = new SPA.Domain.ApplicationDbContext();
            }
            return _context;
        }
        */
    }
}
