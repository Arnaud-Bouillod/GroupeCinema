﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupeCinema.MyFaker
{
    public interface IFakerLoader<T>
    {
        T LoadSingleItem();
        List<T> LoadMultipleItems();
     
    }
}
