using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Web Scraping Tutorial using Python and BeautifulSoup in Hindi";
        video1._author = "CodewithHarry";
        video1._length = 3120;
        Comment comment1Video1 = new Comment();
        comment1Video1._text = "Doing a great job!!! thank you for making scrapping so easy...please make videos on web crawling";
        comment1Video1._author = "Jai Gupta";
        Comment comment2Video1 = new Comment();
        comment2Video1._text = "Hi Harry, I am big fan of you and your videos. You're really doing a wonderful job for the programmers like me";
        comment2Video1._author = "Mayank Namdev";
        Comment comment3Video1 = new Comment();
        comment3Video1._text = "Sir, this channel is really great and it explains various python applications";
        comment3Video1._author = "Soumya";

        Video video2 = new Video();
        video2._title = "Using Chat GPT for web desing (AI for web designers)";
        video2._author = "Tristan Parker";
        video2._length = 692;
        Comment comment1Video2 = new Comment();
        comment1Video2._text = "Thanks Tristan, I really like the idea of using it for colour palate generation specifically";
        comment1Video2._author = "Sam Roff";
        Comment comment2Video2 = new Comment();
        comment2Video2._text = "That's awesome great work Tristan love your videos";
        comment2Video2._author = "Zeeshan razzaq";
        Comment comment3Video2 = new Comment();
        comment3Video2._text = "Tristan - you're a legend, so grateful for everything you share";
        comment3Video2._author = "Jonny";

        Video video3 = new Video();
        video3._title = "C# Programming - Creating Basic Classes, Methods, and Properties";
        video3._author = "Caleb Curry";
        video3._length = 480;
        Comment comment1Video3 = new Comment();
        comment1Video3._text = "The analogy of a class to the header column of a spreadsheet and instances as a data row below it encapsulates (pun intended) the concept wonderfully explained";
        comment1Video3._author = "Robert Pardinas";
        Comment comment2Video3 = new Comment();
        comment2Video3._text = "You are seriously underrated man. You are an amazing teacher";
        comment2Video3._author = "Johnathan Drushel-Smith";
        Comment comment3Video3 = new Comment();
        comment3Video3._text = "Great video";
        comment3Video3._author = "Allen Warner";

        video1._commentsList.Add(comment1Video1);
        video1._commentsList.Add(comment2Video1);
        video1._commentsList.Add(comment3Video1);
        video2._commentsList.Add(comment1Video2);
        video2._commentsList.Add(comment2Video2);
        video2._commentsList.Add(comment3Video2);
        video3._commentsList.Add(comment1Video3);
        video3._commentsList.Add(comment2Video3);
        video3._commentsList.Add(comment3Video3);

        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayDetails();
            video.DisplayComments();
        }



    }
}