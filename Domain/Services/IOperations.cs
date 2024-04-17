﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA.Domain.Services
{
    public interface IOperations
    {
        void show(int id ); 
        void add(Array data);
        void update(Array data, int id );
        void delete(int id);
    }
}
