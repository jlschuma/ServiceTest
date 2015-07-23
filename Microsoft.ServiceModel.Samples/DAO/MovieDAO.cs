using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ServiceModel.Samples.DAO
{
    interface MovieDAO
    {
        List<Movie> GetMovies();
        List<Movie> GetMoviesByActor(string firstName, string lastName);
        List<Movie> GetMoviesByDirector(string firstName, string lastName);

    }
}
