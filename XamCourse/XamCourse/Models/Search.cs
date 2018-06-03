namespace XamCourse.Models
{
    public class Search
    {
        public int m_id { get; set; }
        public string m_location { get; set; }
        public string m_check_in { get; set; }
        public string m_check_out { get; set; }
        public string m_duration
        {
            get
            {
                return string.Format("{0} - {1}", m_check_in, m_check_out);
            }
        }

        public Search(int id, string location, string check_in, string check_out)
        {
            m_id = id;
            m_location = location;
            m_check_in = check_in;
            m_check_out = check_out;
        }
    }
}
