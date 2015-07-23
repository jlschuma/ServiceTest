using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ServiceModel.Samples
{
    public class Movie
    {
        public Movie()
        { }
        public Movie(string Title, int DirectorId, string DirectorName, int YearMade, int Id)
        {
            this.Title = Title;
            this.DirectorId = DirectorId;
            this.DirectorName = DirectorName;
            this.YearMade = YearMade;
            this.Id = Id;
        }

        public string Title { get; set; }
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }
        public int YearMade { get; set; }
        public int Id { get; set; }

    }
}
