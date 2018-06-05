using System;
using System.Collections.Generic;

using XamCourse.Models;

namespace XamCourse.Services
{
    public class ActivityService
    {
        public static List<Activity> GetActivities()
        {
            // would normally call into remote service here
            return new List<Activity>
            {
                new Activity(0, "Tom liked your post!"),
                new Activity(1, "Jordan liked your post!"),
                new Activity(2, "Jennifer said hello!")
            };
        }
    }
}
