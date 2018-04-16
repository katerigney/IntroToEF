using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEF.Data;


namespace IntroToEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DataContext();

            //INSERT MOVIE

            var theNeverEndingStory = new Movie
            {
                Title = "The NeverEnding Story",
                YearReleased = 1984,
                Genre = "Fantasy",
                Tagline = "A boy who needs a friend finds a world that needs a hero in a land beyond imagination!",
                Rating = 7.4
            };
            /*dbContext.Movies.Add(theNeverEndingStory);

            var dieHard = new Movie
            {
                Title = "Die Hard",
                YearReleased = 1988,
                Genre = "Action",
                Tagline = "40 stories of sheer adventure",
                Rating = 8.2
            };
            dbContext.Movies.Add(dieHard);

            var rogerRabbit = new Movie
            {
                Title = "Who framed Roger Rabbit?",
                YearReleased = 1988,
                Genre = "Comedy",
                Tagline = "It’s the story of a man, a woman, and a rabbit in a triangle of trouble.",
                Rating = 7.7
            };
            dbContext.Movies.Add(rogerRabbit);

            var nightmareOnElmStreet = new Movie
            {
                Title = "Nightmare on Elm Street",
                YearReleased = 1984,
                Genre = "Horror",
                Tagline = "If Nancy doesn't wake up screaming she won't wake up at all.",
                Rating = 7.5
            };
            dbContext.Movies.Add(nightmareOnElmStreet);

            var nightOfTheLivingDead = new Movie
            {
                Title = "Night Of The Living Dead",
                YearReleased = 1968,
                Genre = "Horror",
                Tagline = "They won't stay dead!",
                Rating = 7.8
            };
            dbContext.Movies.Add(nightOfTheLivingDead);

            var saw = new Movie
            {
                Title = "Saw",
                YearReleased = 2004,
                Genre = "Horror",
                Tagline = "Every piece has a puzzle",
                Rating = 7.6
            };
            dbContext.Movies.Add(saw);

            dbContext.SaveChanges();*/



            //FIND HORROR MOVIES

            var horrorMovies = dbContext.Movies.Where(h => h.Genre == "horror");

            Console.WriteLine("Horror movies:");
            foreach (var movie in horrorMovies)
            {
                Console.WriteLine(movie.Title);
            }


            //UPDATE RATING FOR MOVIE MADE IN 1988

            var eighties = dbContext.Movies.Where(m => m.YearReleased == 1988);

            foreach (var movie in eighties)
            {
                movie.Rating = 10;
            }

            dbContext.SaveChanges();


            //DELETE THE NEVERENDING STORY

            //var remove = dbContext.Movies.First(f => f.Title == "The NeverEnding Story");
            //dbContext.Movies.Remove(remove);
            //dbContext.SaveChanges();


            Console.ReadLine();
        }
}
}
