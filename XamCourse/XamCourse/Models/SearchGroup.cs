using System.Collections.Generic;

namespace XamCourse.Models
{
    public class SearchGroup : List<Search>
    {
        public string m_title { get; }
        public SearchGroup(IEnumerable<Search> searches)
        {
            m_title = "Recent Searches";
            foreach (Search s in searches)
                this.Add(s);
        }
    }
}
