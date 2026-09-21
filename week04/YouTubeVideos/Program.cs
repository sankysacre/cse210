using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Classes & Abstraction", "Code With Me", 480);
        video1.AddComment(new Comment("Alex", "Super clear explanation of abstraction!"));
        video1.AddComment(new Comment("Maria", "This helped me finish my homework."));
        video1.AddComment(new Comment("Daniel", "Can you make a video on inheritance next?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 VS Code Extensions", "DevTips", 620);
        video2.AddComment(new Comment("Sarah", "Prettier and Auto Rename Tag are lifesavers."));
        video2.AddComment(new Comment("James", "Great list! Thanks for sharing."));
        video2.AddComment(new Comment("Linda", "Subscribed after watching this."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Git & GitHub Essentials", "Tech Today", 900);
        video3.AddComment(new Comment("Eric", "Finally understood git push vs git commit."));
        video3.AddComment(new Comment("Grace", "Short, concise, and to the point."));
        video3.AddComment(new Comment("Kevin", "Rewatching this for my team project setup."));
        videos.Add(video3);

        // Iterate through videos and display details
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}