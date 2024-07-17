using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("AmericanStandardK9", "3 Things you should do when you get a puppy", "42");
        Video video2 = new Video("German Sheper Dog Learn Sit & Stay", "OfficialGSDShorts", "15");
        Video video3 = new Video("Do This Every Morning After You Feed Your Puppy", "McCannDogs", "56");
        Video video4 = new Video("This Quick Dog Training Tip Will Change Everything", "TomDavidsOfficial", "59");

        List<Video> videos = new List<Video> {video1, video2, video3, video4};

        Comment comment1 = new Comment("shekinah33", "I would also work on food guarding. Especially if you have small children.  My poodle would see little ones playing near his food and run into the other room. I trained him not to worry about food.");
        Comment comment2 = new Comment("mysocksarewet", "Reminds me of one time I left my puppy alone at home for 2 frickin hours and somehow she put a hole in the wall.");
        Comment comment3 = new Comment("andrewjohnson1285", "Love the way you’re direct to the point");
        Comment comment4 = new Comment("rondo2ooo", "The dog of someone I know pood while being out. Later the robo-cleaner took care of polishing the floor with it.");
        Comment comment5 = new Comment("sukuna6834", "German shepherds are the best breed.");
        Comment comment6 = new Comment("TheBootsKid", "What a good doggo");
        Comment comment7 = new Comment("jimalvares3863", "Great looking puppy so smart");
        Comment comment8 = new Comment("walkforlove", "I need puppy");
        Comment comment9 = new Comment("misscarmen491", "Great video! Great to tech manners so puppies do not bolt out the open door.  Thank you.");
        Comment comment10 = new Comment("timo57890", "How do you unlearn the naughty scratching the door behavior?");
        Comment comment11 = new Comment("stevewhite791", "You are an awesome trainer/teacher.");
        Comment comment12 = new Comment("davidserlin8097", "The dog is so lucky to have someone like you instilling confidence and manners in her!");
        Comment comment13 = new Comment("MNBlackNBlue", "Lol that struggle of trying not to confuse the dog so saying good... that while trying to explain, so relatable");
        Comment comment14 = new Comment("sofiadelgado3109", "Aww him talking at the end and his dog wanting to play with the and left it on the ground for him ");
        Comment comment15 = new Comment("isnoterica", "The dog’s focus on him is incredible. Not once did she take her eyes off him except to fetch the ball");
        Comment comment16 = new Comment("hildia5439", "I started saying good (insert behavior) yesterday and saw an immediate difference in her walking behavior, she's paying a lot more attention to me and it is much easier to redirect.");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);
        video4.AddComment(comment13);
        video4.AddComment(comment14);
        video4.AddComment(comment15);
        video4.AddComment(comment16);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()} >> Author: {video.GetAuthor()} >>  Length: {video.GetLenght()} >> Number of comments: {video.NumberComments()}");

            foreach (var comment in video.comments)
            {
                Console.WriteLine($"Comment by {comment.GetName()}: {comment.GetComment()}");
            }
            Console.WriteLine();
        }

    }
}