﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Antes
{
    public abstract class AdvancedRemoteControl : RemoteControl
    {
        public abstract void SetChannel(int number);
    }
}
