using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Beat Cristiano and win $1,000,000", "MrBeast", 1364);
        video1.AddComment(new Comment("strokkur24", "I love how all of the pros were so kind to their opponents. True sportsmanship"));
        video1.AddComment(new Comment("alisonbella7662", "I love how Ronaldo was being supportive"));
        video1.AddComment(new Comment("Cattois ", "Imagine Ronaldo cheering you up just by your side, that's just priceless."));
        _videos.Add(video1);

        Video video2 = new Video("A Worldwide Celebration of Jesus Christ's Birth | Light the World", "The Church of Jesus Christ of Latter-day Saints", 133);
        video2.AddComment(new Comment("THE_KlNG", "I'm the 'tough guy' at work and my co-workers are so confused since there is a river of happy tears coming out of my cubicle as I'm watching this video!"));
        video2.AddComment(new Comment("lokela77", "What a beautiful video. Christ didn’t come for some, he came for all."));
        _videos.Add(video2);

        Video video3 = new Video("Marvel Rivals | Launch Trailer", "Marvel Entertainment", 84);
        video3.AddComment(new Comment("NecrosOW", "YOU CAN JUST FEEL THE PASSION OOZING OUT OF THIS TRAILER!! CAN'T WAIT TO PLAY THIS GAME!"));
        video3.AddComment(new Comment("jonalee5262", "Suddenly I'm hyped cuz they made this launch trailer like an anime opening"));
        _videos.Add(video3);

        foreach (var video in _videos)
        {
            video.DisplayInfo();
        }
    }
}