﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterisk.NET.Manager.Event
{
    public class ConfbridgeListRoomsCompleteEvent : ResponseEvent
    {

        public ConfbridgeListRoomsCompleteEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
