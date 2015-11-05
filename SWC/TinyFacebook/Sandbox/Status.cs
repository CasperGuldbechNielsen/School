using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // This class could be part of an application similar to Facebook.
    // The class represents a status that a user can post - other users
    // can then "like" or "dislike" the status post 
    public class Status
    {
        private string statusText;              // this is an instance field
        private int likes;                      // so is this
        private int dislikes;                   // and this
        private int numOfReads;

        // Create the Status - initially, the status has zero likes
        // and zero dislikes
        public Status(string statusText)        // This is the constructor. 
        {                                       // It has no int, string, void etc. after
            this.statusText = statusText;       // public ... status - this is because
            this.likes = 0;                     // a constructor has no returnvalues.
            this.dislikes = 0;
            this.numOfReads = 0;
        }

        public void ReadStatus()
        {
            numOfReads += 1;
        }

        public int getNumOfReads()
        {
            return numOfReads;
        }

        public void AddOneLike()                // this method add likes
        {
            likes = likes + 1;
        }

        public void AddOneDislike()             // this method add dislikes
        {
            dislikes = dislikes + 1;
        }

        public string GetStatusText()           // this method returns statusText
        {
            return statusText;                  // here
        }

        public int GetNoOfLikes()               // this method return likes
        {
            return likes;                       // here
        }

        public int GetNoOfDislikes()            // this method return dislikes
        {
            return dislikes;                    // here
        }
    }
}
