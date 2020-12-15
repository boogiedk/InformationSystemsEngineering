using System;
using InformationSystemsEngineering.Patterns.Strategy.Models;

namespace InformationSystemsEngineering.Patterns.Strategy.Services
{
    public class CourseScheduleService : IScheduleService
    {
        public ScheduleDto Get()
        {
            return new ScheduleDto
            {
                Id = Guid.NewGuid(),
                Content = "Course schedule"
            };
        }
    }
}