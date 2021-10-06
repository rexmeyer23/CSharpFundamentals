using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Repository
{
    public enum MaturityRating
    {
        G = 1, //string value and index value, index value always starts at one unless defined
        PG,
        PG_13,
        R,
        NC_17,
        TV_MA,
        NR
    }
    public enum GenreType
    {
        Horror = 1,
        Thriller,
        Mockumentary,
        RomCom,
        Romance,
        Drama,
        Action,
        Comedy
    }
    public class StreamingContent
    {
        //object that we will create a collection of 
        //get method = retrieving value of property
        //set method = giving value of the property
        //set only would be somthing with equal sign like public string name = "Joe"
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public GenreType TypeOfGenre { get; set; }
        //user can NOT set this prop, ONLY retrieve it
        public bool IsFamilyFriendly
        {
            get
            {
                //return true or false based upon maturity rating
                // give computer a maturity rating and it then needs to decide if its family friendly
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.NC_17:
                    case MaturityRating.R:
                    case MaturityRating.PG_13:
                    case MaturityRating.NR:
                    case MaturityRating.TV_MA:
                    default:
                        return false;

                }
                //another way
                //try building this as a terenary
                //if ((int)MaturityRating > 2)
                //{
                //    return false;
                //}
                //else
                //{
                //    return true;
                //}
            }
        }
        //constructor (special type of method) - tell developers what they need to create an instance of that class/ object
        //default constructor - you don't have to give ANY value to create this object
        public StreamingContent() { }
        //overload constructor - you do have to give some value to create this object
        public StreamingContent(string title, string description, double starRating, MaturityRating maturityRating, GenreType genreType)
        {
            //property NAME = parameter NAME/value
            Title = title;
            Description = description;
            //0 = 5.5
            StarRating = starRating;
            MaturityRating = maturityRating;
            TypeOfGenre = genreType;
            //You can NOT do this
            //starRating = StarRating;
            //saying 5.5 = 0 instead of 0 = 5.5
        }
        //can't put family friendly condtructer becuase you can't set its value, only get it
    }
    //private has NOTHING to do with user, only concerns developers
}
