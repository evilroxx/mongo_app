﻿using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.QueueCore
{
    public interface IQueueClient : IDisposable
    {
        IBus Bus { get; }
    }
}
