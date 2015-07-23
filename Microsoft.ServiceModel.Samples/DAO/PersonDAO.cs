using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ServiceModel.Samples.DAO
{
    interface PersonDAO
    {
        List<Person> GetPeople();
        List<Person> GetActors(string Movie);
        List<Person> GetDirector(string Movie);
    }
}
