﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    public interface Observers
    {
        void onUpdate(object sender, Argus args);
    }
}
