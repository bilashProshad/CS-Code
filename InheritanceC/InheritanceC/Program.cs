using System;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Bilash Proshad");
            Console.WriteLine(post1.ToString());
            
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Bilash Proshad", "https://images.com/", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Check out my new video", "John", true, "https:videos.com/", 10);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();

            Console.ReadLine(); 
        }
    }
}
