using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Create Video instances
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video! Very helpful."));
        video1.AddComment(new Comment("Bob", "I learned a lot from this."));
        video1.AddComment(new Comment("Charlie", "Amazing content!"));

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 450);
        video2.AddComment(new Comment("Dave", "This was a bit complicated, but good."));
        video2.AddComment(new Comment("Eve", "Thanks for the explanations."));
        video2.AddComment(new Comment("Frank", "Looking forward to more advanced topics!"));

        Video video3 = new Video("C# for Beginners", "Alice Johnson", 600);
        video3.AddComment(new Comment("Grace", "Perfect for newbies!"));
        video3.AddComment(new Comment("Hank", "Very clear and concise."));
        video3.AddComment(new Comment("Ivy", "I wish I had this when I started."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the videos and display information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(); // Blank line for better readability
        }
    }
}