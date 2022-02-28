using SocialMedia.Entities;
using System;

namespace SocialMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime moment1 = new DateTime(2018, 06, 21, 13, 05, 44);
            string title1 = "Traveling to new Zealand";
            string content1 = "I'm going to visit this wonderful country! ";
            int likes1 = 12;

            string c1 = "Have a nice trip";
            string c2 = "thats awesome!";

            Comment c11 = new Comment(c1);
            Comment c12 = new Comment(c2);

            Post PostOne = new Post(moment1, title1, content1, likes1);

            PostOne.AddComment(c11);
            PostOne.AddComment(c12);

            Console.WriteLine(PostOne);
            Console.WriteLine();

            DateTime moment2 = new DateTime(2018, 07, 28, 23, 14, 19);
            string title2 = "Good night guys";
            string content2 = "See you tomorrow";
            int likes2 = 5;

            Post PostTwo = new Post(moment2, title2, content2, likes2);

            string c13 = "Good Night";
            string c14 = "May the force be with you";

            Comment c15 = new Comment(c13);
            Comment c16 = new Comment(c14);

            PostTwo.AddComment(c15);
            PostTwo.AddComment(c16);

            Console.WriteLine(PostTwo);


        }
    }
}
