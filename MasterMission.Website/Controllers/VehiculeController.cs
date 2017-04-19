
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

using MasterMission.Data;
using MasterMission.Models;

namespace MasterMission.Controllers
{
    public class VehiculeController : ApiController
    {
        private DataContext DataContext = new DataContext();

        // GET api/personne
        public IEnumerable<Vehicule> Get()
        {
            var test = (new MasterDbContext()).Vehicules;
            var test2 = test.ToList();
            return test2;
        }

        // GET api/personne/5
        public Vehicule Get(int id)
        {
            var list = (new MasterDbContext()).Vehicules;
            var item = list.FirstOrDefault(t => t.Id == id);
            if(item == null)
            {
                throw new HttpRequestException("Item not found");
            }
            return item;
        }

        /*
        // POST api/personne
        public Vehicule Post([FromBody] Vehicule value)
        {
            var list = DataContext.GetListPersonne();
            if(string.IsNullOrWhiteSpace(value.FirstName) || string.IsNullOrWhiteSpace(value.LastName))
            {
                throw new HttpException("Firstname and lastname can not be empty.");
            }
            foreach (var item in list)
            {
                if (item.FirstName.ToLower().Equals(value.FirstName.ToLower()) || item.LastName.ToLower().Equals(value.LastName.ToLower()))
                {
                    throw new HttpException("A person with the same firstname and lastname exists already.");
                }
            }
            value.Id = list.Count() + 1;
            list.Add(value);
            return value;
        }

        // PUT api/personne/5
        public void Put(int id, [FromBody] Vehicule value)
        {
            var list = DataContext.GetListPersonne();
            var item = list.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                item.FirstName = value.FirstName;
                item.LastName = value.LastName;
                item.Birthday = value.Birthday;
            }
        }
        */

        // DELETE api/personne/5
        public void Delete(int id)
        {
            var list = (new MasterDbContext()).Vehicules;
            var item = list.FirstOrDefault(t => t.Id == id);
            if(item != null)
            {
                list.Remove(item);
            }
        }
    }
}
