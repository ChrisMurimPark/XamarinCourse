using System;
namespace XamCourse.Models
{
    public class User
    {
        public string m_name { get; set; }
        public string m_status { get; set; }
        public int m_id { get; set; }

        public User(string name, string status, int id)
        {
            m_name = name;
            m_status = status;
            m_id = id;
        }
    }
}
