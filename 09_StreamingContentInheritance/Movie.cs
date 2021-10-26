using _08_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContentInheritance
{
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }
        public Movie()
        {

        }
        public Movie(string title, string description, double starRating, MaturityRating maturityRating, GenreType genreType, double runTime)
            :base(title, description, starRating, maturityRating, genreType)
            //base class is streaming repository class, it is inherited 
        {
            RunTime = runTime;
        }
    }
}
