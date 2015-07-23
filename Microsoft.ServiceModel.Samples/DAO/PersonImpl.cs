using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ServiceModel.Samples.DAO
{
    public class PersonImpl : PersonDAO
    {
        DAL dal = new DAL();

        public List<Person> GetPeople()
        {
            return dal.GetPeople();

        }

        public List<Person> GetActors(string Movie)
        {
            List<Movie> movies = dal.GetMovies();
            List<Person> people = dal.GetPeople();
            List<ActsIn> actsIn = dal.GetActsIn();


            IEnumerable<Person> results =
                from movie in movies
                join actIn in actsIn on movie.Id equals actIn.MovieId
                join person in people on actIn.ActorId equals person.Id
                where movie.Title.Equals(Movie)
                select person;

            return results.ToList();
        }

        public List<Person> GetDirector(string Movie)
        {
            throw new NotImplementedException();
        }
    }
}
