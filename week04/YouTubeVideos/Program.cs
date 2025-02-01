using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Video 1", "Author 1", 360);
        Video video2 = new Video("Video 2", "Author 2", 420);
        Video video3 = new Video("Video 3", "Author 3", 300);
        Video video4 = new Video("Video 4", "Author 4", 480);

        video1.AddComment(new Comment("John Doe", "Great video!"));
        video1.AddComment(new Comment("Jane Doe", "I loved it!"));
        video1.AddComment(new Comment("Bob Smith", "Nice job!"));
        video1.AddComment(new Comment("Alice Johnson", "Excellent!"));

        video2.AddComment(new Comment("Mike Brown", "Good video!"));
        video2.AddComment(new Comment("Emily Davis", "I liked it!"));
        video2.AddComment(new Comment("Tom Harris", "Nice work!"));
        video2.AddComment(new Comment("Sarah Taylor", "Great job!"));

        video3.AddComment(new Comment("David Lee", "Excellent video!"));
        video3.AddComment(new Comment("Lisa Nguyen", "I loved it!"));
        video3.AddComment(new Comment("Kevin White", "Good job!"));
        video3.AddComment(new Comment("Rebecca Martin", "Nice work!"));

        video4.AddComment(new Comment("James Wilson", "Great video!"));
        video4.AddComment(new Comment("Jessica Thompson", "I liked it!"));
        video4.AddComment(new Comment("William Jackson", "Nice job!"));
        video4.AddComment(new Comment("Amanda Garcia", "Excellent!"));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}