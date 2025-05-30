using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Comment c1 = new Comment("Comment1", "Author1");
        Comment c2 = new Comment("Comment2", "Author1");
        Comment c3 = new Comment("Comment3", "Author1");
        Comment c4 = new Comment("Comment4", "Author1");
        Comment c5 = new Comment("Comment5", "Author1");
        Comment c6 = new Comment("Comment6", "Author1");
        Comment c7 = new Comment("Comment7", "Author1");
        Comment c8 = new Comment("Comment8", "Author1");
        Comment c9 = new Comment("Comment9", "Author1");

        Video v1 = new Video();
        v1._title = "Title1";
        v1._author = "Author1";
        v1._length = 203;
        v1.NumberOfComments();
        v1._comment = [c1, c2, c3];
        v1._comment = new List<Comment> { c1, c2, c3 };

        Video v2 = new Video();
        v2._title = "Title2";
        v2._author = "Author2";
        v2._length = 203;
        v2.NumberOfComments();
        v2._comment = new List<Comment> { c4, c5, c6 };

        Video v3 = new Video();
        v3._title = "Title3";
        v3._author = "Author3";
        v3._length = 203;
        v3.NumberOfComments();
        v3._comment = new List<Comment> { c7, c8, c9 };

        List<Video> videos = new List<Video> { v1, v2, v3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments}");
            Console.WriteLine($"Comments:");
            foreach (var comment in video._comment)
            {
                Console.WriteLine($"-{comment._name}: {comment._text}");
            }
            Console.WriteLine(" ");
        }
    }
}    