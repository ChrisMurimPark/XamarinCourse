using System;
using System.Collections.Generic;
using System.Linq;
using XamCourse.Models;

namespace XamCourse.Services
{
    public class SearchService
    {
        static List<Search> m_searches = 
            new List<Search>
            {
                new Search(0, "West Hollywood, CA, United States", "Sep 1, 2016", "Nov 1, 2016"),
                new Search(1, "Santa Monica, CA, United States", "Sep 1, 2016", "Nov 1, 2016"),
                new Search(2, "Springfield, MO, United States", "Sep 1, 2016", "Nov 1, 2016"),
                new Search(3, "Chicago, IL, United States", "Sep 1, 2016", "Nov 1, 2016")
            };

        public static IEnumerable<Search> GetSearches(string filter = null)
        {
            // here, normally would go to remote service
            if (String.IsNullOrWhiteSpace(filter))
                return m_searches;
            return m_searches.Where(s => CaseInsensitiveContains(s.m_location, filter));
        }

        public static void DeleteSearch(int search_id)
        {
            foreach (Search s in m_searches)
            {
                if (s.m_id == search_id)
                {
                    m_searches.Remove(s);
                    break;
                }
            }
        }

        private static bool CaseInsensitiveContains(string whole_text, string search, 
                                     StringComparison string_comparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return whole_text.IndexOf(search, string_comparison) >= 0;
        }
    }
}
