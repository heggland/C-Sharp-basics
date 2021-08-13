﻿using System;

namespace inheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
            Console.WriteLine(post1.ToString());


            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Denis Panjuta",
                "https://images.com/shoes", true);

            Console.WriteLine(imagePost1.ToString());


            VideoPost videoPost1 = new VideoPost("FailVideo", "Denis Panjuta",
                "https://video.com/failvideo", true, 10);


            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();


            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();

            Console.ReadLine();
        }
    }
}
