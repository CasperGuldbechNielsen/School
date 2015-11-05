using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Status status = new Status("I like turtles");

            string _status = status.GetStatusText();

            int _likes = status.GetNoOfLikes();
            int _dislikes = status.GetNoOfDislikes();
            int _numOfReads = status.getNumOfReads();

            Console.WriteLine("Status: " +_status);
            Console.WriteLine("Likes: " + _likes);
            Console.WriteLine("Dislikes: " + _dislikes);
            Console.WriteLine("Read by: " + _numOfReads);

            for (int i = 0; i < 5; i++)
            {
                status.AddOneLike();
            }

            for (int i = 0; i < 2; i++)
            {
                status.AddOneDislike();
            }

            for (int i = 0; i < 10; i++)
            {
                status.ReadStatus();
            }

            _likes = status.GetNoOfLikes();
            _dislikes = status.GetNoOfDislikes();
            _numOfReads = status.getNumOfReads();

            Console.WriteLine(".................");

            Console.WriteLine("Status: " + _status);
            Console.WriteLine("Likes: " + _likes);
            Console.WriteLine("Dislikes: " + _dislikes);
            Console.WriteLine("Read by: " + _numOfReads);

            // The LAST line of code should be ABOVE this line
        }
    }
}
