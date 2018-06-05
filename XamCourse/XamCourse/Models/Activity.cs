using System;
namespace XamCourse.Models
{
    public class Activity
    {
        public string m_activity { get; set; }
        public int m_user_id { get; set; }

        public Activity(int user_id, string activity)
        {
            m_user_id = user_id;
            m_activity = activity;
        }
    }
}
