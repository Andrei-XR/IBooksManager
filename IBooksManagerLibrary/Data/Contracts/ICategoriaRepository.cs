﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBooksManagerLibrary.Data.Contracts
{
    public interface ICategoriaRepository
    {
        bool ValidarRemocao(int id);
    }
}
