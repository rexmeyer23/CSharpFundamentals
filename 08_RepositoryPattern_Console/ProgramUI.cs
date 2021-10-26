using _08_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Console
{//can't say AND in single responsibility principle
    //google readonly value types
    public class ProgramUI
        //repository hosts CRUD methods, data class single repsonibility is there ti be blueprint to host other sorts of data
    {
        //remember we can't declare variables inside of class because they are not class members, but we can declare and initialize fields

        //create an empty blueprint when newing up an instance of a class
        //global field means its accesible to an entire class
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();
        //made private so intsance is only available inside of this class
        //User Interface
        //purpose is to host user interactions AND run my application
        //Point of application is for users to interact with their collection so that they can keep an up to date collection of their fav streaming content at that time
        //CRUD
        //creating new streaming content - add that to my collection
        //read the collection
        //update their collection
        //delete contents from their collection
        public void Run()
        {
            SeedContentList();
            RunMenu();
            //Purpose of method is to make application run
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun) //add loop to take user back to menu, remember loops keep going until it gets a false result
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to your application.\n" +
                    "Here is where you can create and interact with a list of your favorite TV Shows and Movies.\n" +
                    "Enter the number of the option you would like to select: \n" +
                    "1. Show all streaming content. \n" +
                    "2. Find streaming content by title.\n" +
                    "3. Add new streaming content.\n" +
                    "4. Remove streaming content.\n" +
                    "5. Exit");
                string userInput = Console.ReadLine(); //you want to save users input
                switch (userInput)
                {
                    case "1":
                        //show all
                        ShowAllContent();
                        break;
                    case "2":
                        //find by title

                        break;
                    case "3":
                        //add new
                        CreateNewContent();
                        break;
                    case "4":
                        //remove content
                        break;
                    case "5":
                        //exit
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 5. \n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void CreateNewContent()
        {
            StreamingContent content = new StreamingContent();
            //the user is going to have to create this streaming content object
            //Title
            Console.WriteLine("Time to add your streaming content to your collection.\n" +
                "Let's get started!\n" +
                "Please enter in your the title of the content: \n");
            content.Title = Console.ReadLine();
            //Description
            Console.WriteLine("Please enter the description: ");
            content.Description = Console.ReadLine();

            //StarRating
            Console.WriteLine("Please enter the star rating (1-5): ");
            string starRatingInput = Console.ReadLine();
            //try catch
            //allow application to capture an error, and instead of breaking, move on
            try
            {
                content.StarRating = double.Parse(starRatingInput);
            }
            catch
            {
                Console.WriteLine("Sorry. You need to enter a valid decimal.");
            }
            //MaturityRating
            Console.WriteLine("Please select a maturity rating (1-7):\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. NC_17\n" +
                "6. TV_MA\n" +
                "7. NR");
            string maturityString = Console.ReadLine();
            switch (maturityString.ToUpper())
            //.ToLower works but cases would have to be lower case i.e. case "g"
            {
                case "1":
                case "G":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                case "PG":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                case "PG_13":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                case "R":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                case "NC_17":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                case "TV_MA":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
                case "7":
                case "NR":
                    content.MaturityRating = MaturityRating.NR;
                    break;
                default:
                    Console.WriteLine("Please enter in a valid rating. ");
                    break;
            }
            //TypeOfGenre
            Console.WriteLine("Please select a Genre: \n" +
                "1. Horror\n" +
                "2. Thriller\n" +
                "3. Mockumentary\n" +
                "3. RomCom\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy");
            string genreInput = Console.ReadLine();
            try
            {
                int genreID = int.Parse(genreInput);
                content.TypeOfGenre = (GenreType)genreID;
            }
            catch
            {
                Console.WriteLine("Please enter in a valid number between 1-8.");
            }
            //AddContentToDirectory take in streaming content object and add it to my collection
            _streamingRepo.AddContentToDirectory(content);
        }
        private void ShowAllContent()
        {
           List<StreamingContent> listOfContent = _streamingRepo.GetAllContents();

            foreach(StreamingContent contentVariable in listOfContent)
            {
                DisplayContent(contentVariable);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title}");
            Console.WriteLine($"Description: {content.Description}");
        }
        //method below will add content to content directory
        private void SeedContentList()
        {
            StreamingContent movieOne = new StreamingContent("Jaws", "Fish eats man", 3.5, MaturityRating.R, GenreType.Horror);
            StreamingContent movieTwo = new StreamingContent("Intersellar", "Space and stuff.", 4.0, MaturityRating.PG_13, GenreType.Thriller);
            _streamingRepo.AddContentToDirectory(movieOne);
            _streamingRepo.AddContentToDirectory(movieTwo);
        }
    }
}
