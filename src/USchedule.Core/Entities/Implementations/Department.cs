﻿using System;
using USchedule.Core.Entities.Implementations.Base;

namespace USchedule.Core.Entities.Implementations
{
    public class Department: ShortTitleEntityBase
    {
        public Guid InstituteId { get; set; }
        public Guid? RoomId { get; set; }
        
        public Institute Institute { get; set; }
        public Room Room { get; set; }
    }
}