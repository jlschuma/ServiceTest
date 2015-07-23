using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ServiceModel.Samples.DAO
{
    public class DAL
    {
        private string connString = "Server=JESSICA-PC\\SQLEXPRESS;Database=Movie;User Id=jess;Password=jess";
        private SqlConnection conn;
        private SqlCommand command;

        public List<Movie> GetMovies()
        {
            string sqlSelectString = "select title, director, year_made, id from Movies";
            List<Movie> moviesList = new List<Movie>();
            try
            {
                using (conn)
                {
                    conn = new SqlConnection(connString);
                    command = new SqlCommand(sqlSelectString, conn);
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Movie movie = new Movie();
                        movie.Title = reader[0].ToString();
                        movie.DirectorId = Convert.ToInt16(reader[1]);
                        movie.YearMade = Convert.ToInt16(reader[2]);
                        movie.Id = Convert.ToInt16(reader[3]);

                        moviesList.Add(movie);
                    }
                    return moviesList;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }


        public List<Person> GetPeople()
        {
            string sqlSelectString = "select fnames, lname, id from persons";

            List<Person> peopleList = new List<Person>();
            try
            {
                using (conn)
                {
                    conn = new SqlConnection(connString);
                    command = new SqlCommand(sqlSelectString, conn);
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Person person = new Person();
                        person.FirstName = reader[0].ToString();
                        person.LastName = reader[1].ToString();
                        person.Id = Convert.ToInt16(reader[2]);
                        peopleList.Add(person);
                    }
                    return peopleList;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public List<ActsIn> GetActsIn()
        {
            string sqlSelectString = "select actor, movie from acts_in";

            List<ActsIn> ActsInList = new List<ActsIn>();
            try
            {
                using (conn)
                {
                    conn = new SqlConnection(connString);
                    command = new SqlCommand(sqlSelectString, conn);
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ActsIn actsIn = new ActsIn();
                        actsIn.ActorId = Convert.ToInt16(reader[0]);
                        actsIn.MovieId = Convert.ToInt16(reader[1]);

                        ActsInList.Add(actsIn);
                    }
                    return ActsInList;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }





    }
}
