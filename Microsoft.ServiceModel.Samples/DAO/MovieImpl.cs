using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ServiceModel.Samples.DAO
{
    public class MovieImpl : MovieDAO
    {

        private DAL dal = new DAL();

        public List<Movie> GetMovies()
        {
            List<Movie> movies = dal.GetMovies();
            List<Person> people = dal.GetPeople();


            IEnumerable<Movie> results =
                from movie in movies
                join person in people on movie.DirectorId equals person.Id
                select new Movie(movie.Title, movie.DirectorId, person.FirstName + " "+person.LastName, movie.YearMade, movie.Id);

            //return dal.GetMovies();
            return results.ToList(); 
        }

        public List<Movie> GetMoviesByActor(string firstName, string lastName)
        {
            List<Movie> movies = dal.GetMovies();
            List<Person> people = dal.GetPeople();
            List<ActsIn> actsIn = dal.GetActsIn();


            IEnumerable<Movie> results=
                from movie in movies
                join actIn in actsIn on movie.Id equals actIn.MovieId
                join person in people on actIn.ActorId equals person.Id
                where person.FirstName.Equals(firstName)
                where person.LastName.Equals(lastName)
                select movie;
            
            return results.ToList();
                   
        }

        public List<Movie> GetMoviesByDirector(string firstName, string lastName)
        {
            List<Movie> movies = dal.GetMovies();
            List<Person> people = dal.GetPeople();



            IEnumerable<Movie> results =
                from movie in movies
                join person in people on movie.DirectorId equals person.Id
                where person.FirstName.Equals(firstName)
                where person.LastName.Equals(lastName)
                select movie;

            return results.ToList();
        }
    }
}
