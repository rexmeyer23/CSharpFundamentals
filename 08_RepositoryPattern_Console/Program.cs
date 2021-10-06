using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client wants a console app for her users that allow them to store a collection of streaming content
            //List<string>, List<StreamingContent>
            //StreamingContent.cs
            //Point of application is for users to interact with their collection so that they can keep an up to date collection of their fav streaming content at that time
            //interact with my users inside my console app - User Interface - ProgramUI.cs
            //users interact with collection - business logic - Repository Pattern - Repo.cs (inside of  Repo class contains only CRUD methods)
            //Business logic exchnage between database and collection, user interacts with collection is an indicator of business logic

            //Single Responsibility Principle
            //console app project - be the application/user interface
            //Program.cs
            //ProgramUI.cs

            // Class Library - users interact with collection - business logic
            // Repo.cs
            // StreamingContent.cs

        }
    }
}
