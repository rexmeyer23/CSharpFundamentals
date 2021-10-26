using _09_Inheritance_ClassLibrary;
using _08_RepositoryPattern_Repository;
using _09_StreamingContentInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_InheritanceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat1 = new Cat();
            //cat1.Move();


            //Animal animal1 = new Animal();
            //animal1.Move();

            //Lion lion1 = new Lion();
            //lion1.Move();
            //lion1.MakeSounds();



            //Console.ReadKey();
            StreamingContent st = new StreamingContent();
            Movie movie1 = new Movie();

            Show show1 = new Show();

            List<StreamingContent> listStreamingContent = new List<StreamingContent>();
            listStreamingContent.Add(movie1);
            listStreamingContent.Add(show1);

            List<Movie> movies = new List<Movie>();

            StreamingContent stContent = new StreamingContent();
            //movies.Add(stContent);
            //above code doesn't work because Movie inherited StreamingContent properties, so StreamingContent can't be referenced as the parent
            //the Movie class is considered a child of the StreamingContent class And the child can be referenced  as its parent but the parent cannot be referenced as its child
            //movies inherited from stContent, so movies can't refer to stContent
            //stContent is parent, movies is child, think of child inheriting traits from parents

            listStreamingContent.Add(stContent);
            Movie movie2 = new Movie("Titanic", "a ship wrecks and people drown", 4.00, MaturityRating.PG_13, GenreType.Drama, 204.00);

        }
    }
}
