using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Comment c1 = new Comment();
        c1._text = "Ohana means familyI'm 27 now and i still remember that line the first time i watched lilo and stich when im still a kid.";
        c1._name = "@njmn-d6r";

        Comment c2 = new Comment();
        c2._text = "The way Stitch looks is EXACTLY how I imagined him in live action";
        c2._name = "@Super165i";

        Comment c3 = new Comment();
        c3._text = "I can already tell this is gonna be the best Disney live action remake… this live action Stitch design is just too adorable";
        c3._name = "@RaphJohn";

        Comment c4 = new Comment();
        c4._text = "My dad used to play this on guitar and sing me to sleep, while I sung along. He was in the navy, so he read me books like Treasure Island, and played soft songs like this when I had nightmares. I truly cherish those memories, I wish I could go back to those times";
        c4._name = "@abio-o9679";

        Comment c5 = new Comment();
        c5._text = "This song is how I got introduced to the Beatles. No matter what I hear from them, this song will always solidify what the Beatles are to me.";
        c5._name = "@dog-w3rop";

        Comment c6 = new Comment();
        c6._text = "This song is great";
        c6._name = "@GKIMDigital";

        Comment c7 = new Comment();
        c7._text = "I just started this winter semester, and it’s been a blessing for me!!!";
        c7._name = "@editaamante3306";

        Comment c8 = new Comment();
        c8._text = "One step at a time , thank you BYU Pathway ! Now i am in my second semester in BYUi :)";
        c8._name = "@dongtvs506";

        Comment c9 = new Comment();
        c9._text = "I’m so excited to start this journey! Thank you BYU Pathway!";
        c9._name = "@arielkezele7758";


        Video v1 = new Video();
        v1._title = "Lilo & Stitch | Official Trailer | In Theaters May 23";
        v1._author = "Disney";
        v1._length = 134;
        v1._comment = [c1, c2, c3];
        v1._comment = new List<Comment> { c1, c2, c3 };

        Video v2 = new Video();
        v2._title = "Yellow Submarine";
        v2._author = "The Beatles";
        v2._length = 143;
        v2._comment = new List<Comment> { c4, c5, c6 };

        Video v3 = new Video();
        v3._title = "How Pathway Works";
        v3._author = "BYU Pathway Connect";
        v3._length = 138;
        v3._comment = new List<Comment> { c7, c8, c9 };

        List<Video> videos = new List<Video> { v1, v2, v3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine($"Comments:");
            foreach (var comment in video._comment)
            {
                Console.WriteLine($"-{comment._name}: {comment._text}");
            }
            Console.WriteLine(" ");
        }
    }
}    