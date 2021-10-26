using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using statements are there to reference other FOLDERS aka projects, assemblies, and namespaces
namespace _08_RepositoryPattern_Repository
{
    public class StreamingContentRepository //class only purpose is to host methods below
    {   //variables are not a class member, therefore they can not go inside a class
        //new instance of the list class
        //new list object that contains streamcontent objects
        //what is the differnce between private and protected?
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        //REPO - holds my business logic
        //allowing transfer of info from my collection to my user interface, most of the time collections will be databases
        //CRUD methods
        //single responisbility principle means a method can only do thing inside of a method
        //CRUD belongs in repo
        //Create
        //take in a streaming content object and add it to my list
        //refactor - where you change code to either be better or to adjust for breaking changes
        public bool AddContentToDirectory(StreamingContent content)
        //alway give above an object to access all whats in the class (class StreamingContent in StreamingContent.cs
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content); //add an item to my list of streaming content objects
            //Did my startingCount change?
            bool wasAdded = _contentDirectory.Count > startingCount ? true : false;
            return wasAdded;
            //return _contentDirectory.Count > startingCount;
        } //we build methods to be testable, use bool return type
        //Read
        //give me every item in my collection
        public List<StreamingContent> GetAllContents()
            //returning all properties in collection, so List<StreamingContent> is return type
            //asking computer to give me something, go into each item in list and give me this
        {
            return _contentDirectory;
        }
        //find the old streaming content by title
        //The Incredibles
        //the incredibles
        //ThE InCredIblEs
        public StreamingContent GetContentByTitle(string title)
        {
            //searching collection for a title
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                    //.ToLower is an example of fail safe for case sensitivity
                    //two or more items with the same title is another example of needing a fail safe
                    //inner scope can not be seen by outer scope
                {
                    return content;
                }
            }
            return null; //null means NO VALUE, you still return something which is no value aka null
        }
        //Update
        //need to update a streaming content object to have new values for its properties
        //find the old streaming content object in my list and then update its properties
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle); //just has to take in a string, does not have to put in title
            //returns null or streamingcontent object with value
           //must put failsafe around code so it does not return null
           if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                //no need for FamilyFriendly because it automatically gets calculated with maturity rating, there is also no set for it either
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
           else
            {
                return false;
            }


            //update its properties
        }
        //Delete
        //take in a existing streaming content and delete from my list
        public bool DeleteExistingContent(StreamingContent existingContent)
        {

            bool deletedContent = _contentDirectory.Remove(existingContent);
            return deletedContent;
            
        }
    }
}
