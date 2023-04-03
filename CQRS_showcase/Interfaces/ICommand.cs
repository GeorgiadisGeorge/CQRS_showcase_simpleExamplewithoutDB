﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_showcase.Interfaces
{
    public interface ICommand<T>
    {
        void Execute(T item);
    }
}
