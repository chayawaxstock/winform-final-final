﻿using manageTask.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageTask.Models
{
    public class PresentDay
    {
        public PresentDay()
        {
        }
        public int PresentDayId { get; set; }

        [ValidDateTimeBegin]
        public DateTime TimeBegin { get; set; }

        [ValidDateTimeEnd]
        public DateTime TimeEnd { get; set; }
        public decimal sumHoursDay { get; set; }

        public int UserId { get; set; }

        public int ProjectId { get; set; }

        public User User { get; set; }

        public Project Project { get; set; }


    }
}
