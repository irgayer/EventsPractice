﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EventsPractice.Man;

namespace EventsPractice
{
    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }
}
