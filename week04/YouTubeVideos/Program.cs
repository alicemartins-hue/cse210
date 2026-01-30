using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine(" ");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("video 1", "author", 320);
        video1.AddComment("name1", "text");
        video1.AddComment("name2", "text");
        video1.AddComment("name3", "text");
        video1.AddComment("name4", "text");

        Video video2 = new Video("video 2", "author 2", 488);
        video2.AddComment("name1", "text");
        video2.AddComment("name2", "text");
        video2.AddComment("name3", "text");
        video2.AddComment("name4", "text");

        Video video3 = new Video("video 3", "author 3", 60);
        video3.AddComment("name1", "text");
        video3.AddComment("name2", "text");
        video3.AddComment("name3", "text");
        video3.AddComment("name4", "text");


        Video video4 = new Video("video 4", "author 4", 520);
        video4.AddComment("name1", "text");
        video4.AddComment("name2", "text");
        video4.AddComment("name3", "text");
        video4.AddComment("name4", "text");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach(var video in videos)
        {
            Console.WriteLine(video.GetDisplay());
            Console.WriteLine($" The video get {video.NumberOfComments()} comments");
            video.DisplayComments();
            Console.WriteLine("");
        }

    }
}