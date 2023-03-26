using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("***********PRODUCT AWARENESS TRACKER***********");
        Console.WriteLine("-- Here is the data collected so far from YouTube videos and their comments --");
        Console.WriteLine("");
        List<Video> videos = new List<Video>();

        Video video1 = new Video {Title = "SPECIALIST testing DOVE PINK, COCONUT MILK, RESTORE and GO FRESH FRESH TOUCH SOAPS on the FACE", Author = "Pharmacy&Makeup", Length = 676};
        video1.AddComment("Maria M", "I’ve been using dove baby bar for a month now and I’m actually happy with the results");
        video1.AddComment("EMPRESS KOFOWOROLA TV", "Tried the Original Dove on my oily face this morning it's not drying like the green one");
        video1.AddComment("Adiba not from 63rd", "What’s the difference ⁉");
        video1.AddComment("Katarina Bujosevic", "Not Dove again I would love to hear more from you");
        videos.Add(video1);

        Video video2 = new Video {Title = "The Truth About Dove Bar Soap", Author = "Hyram", Length = 877};
        video2.AddComment("Sumari Van Staden", "I love that he brings environmental issues in, I feel not enough people talk about it.");
        video2.AddComment("Nebiyu", "As a chronic dermatologist ,Dove soap is literally a mild cleanser that doesn't come with water in plastic bottle which means no more preservatives! Done throw yur plastics get dove bar's!");
        video2.AddComment("Ysha NP", "When I started getting eczema breakouts, this is what my dermatologist recommended and it saved my skin. This is the only body cleansing product I will ever use from now on.");
        video2.AddComment("Journey Teale", "I love love love that you take into account ethics into your skincare. Beauty ain’t only on the outside!!!");
        videos.Add(video2);

        Video video3 = new Video {Title = "I Used DOVE SOAP ON FACE FOR 7 DAYS (MUST WATCH RESULTS!) ~ Immy", Author = "Immy Maryam", Length = 872};
        video3.AddComment("Naila Mohamed", "I always use Dove soap in the shower for my face. You can even use the Dove body wash for your body. Very gentle and moisturizing!");
        video3.AddComment("NIDA NAVEED", "I have used this for almost 15 to 16 years(recommended by a skin specialist)...its best for dry/sensitive skin. Btw love ur vdos");
        video3.AddComment("Anna-Lena", "Did you continue to use the first bar or did you switch the sensitive one? I had to get the original dove cream bar because there are no others in the stores here");
        video3.AddComment("Ayub Ali", "I have been using dove for two years and Its very  beneficial");
        videos.Add(video3);

        Video video4 = new Video {Title = "Washing My Face With DOVE Soap For 1 Week", Author = "Chelsea Gomez", Length = 152};
        video4.AddComment("Lemon Does It All", "It actually took me 3 months of using only Dove for my face to finally look good!");
        video4.AddComment("Yuuki Yamamoto", "i like how she made the video unfiltered very real");
        video4.AddComment("Chaimae Rakhim", "I don't know but I feel that Dove makes the skin oily, just use it when you feel that your skin is dry. I'm using La roche posay effaclar cleanser and it works fine");
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (in seconds): " + video.Length);
            Console.WriteLine("Number of comments: " + video.NumComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}