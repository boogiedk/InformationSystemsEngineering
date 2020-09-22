using System;
using InformationSystemsEngineering.Patterns.Strategy.Models;

namespace InformationSystemsEngineering.Patterns.Strategy
{
    public class Context
    {
        public IScheduleService ScheduleService { private get; set; }

        public ScheduleDto Get()
        {
            if (ScheduleService == null)
            {
                throw new ArgumentException();
            }

            return ScheduleService.Get();
        }
    }
}