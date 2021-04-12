using System;
using System.Collections;
namespace ExhibitionTask
{
    public class TopStudent
    {
         
        public Hashtable TopScorer { get; set; }
        public Hashtable CourseBest { get; set; }

        public TopStudent(Hashtable topScorer, Hashtable courseBest)
        {
            TopScorer = topScorer;
            CourseBest = courseBest;
        }


    }
}