using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTest
{
    using Microsoft.ServiceModel.Samples;
    using Microsoft.ServiceModel.Samples.DAO;
    using NUnit.Framework;

    [TestFixture]
    public class DAOTest
    {
        [Test]
        public void GetMoviesTest()
        {
            MovieImpl dal = new MovieImpl();
            List<Movie> movies =  dal.GetMovies();
            
            Assert.GreaterOrEqual(movies.Count,1);
        }

        [Test]
        public void GetPeopleTest()
        {
            PersonImpl dal = new PersonImpl();
            List<Person> people = dal.GetPeople();

            Assert.GreaterOrEqual(people.Count, 1);
        }

        [Test]
        public void GetActsInTest()
        {
            DAL dal = new DAL();
            List<ActsIn> ActsIn = dal.GetActsIn();
            Assert.GreaterOrEqual(ActsIn.Count, 1);
        }

   


        [Test]
        public void GetMovieByActorTest()
        {
            MovieImpl dal = new MovieImpl();
            List<Movie> movies = dal.GetMoviesByActor("Bruno","Zanin");
            Assert.GreaterOrEqual(movies.Count, 1);
        }

        [Test]
        public void GetMovieByDirectorTest()
        {
            MovieImpl dal = new MovieImpl();
            List<Movie> movies = dal.GetMoviesByDirector("John", "Singleton");
            Assert.GreaterOrEqual(movies.Count, 1);
        }


    }
}
