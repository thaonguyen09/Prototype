﻿
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
            using (var context = new MasterDbContext())
            {
                return context.Vehicules.ToList();
            }
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

        // POST api/personne
        public Vehicule Post([FromBody] Vehicule value)
        {
            using (var context = new MasterDbContext())
            {
                context.Vehicules.Add(value);
                context.SaveChanges();
                return value;
            }
        }

        // PUT api/personne/5
        public void Put(int id, [FromBody] Vehicule value)
        {
            using (var context = new MasterDbContext())
            {
                var list = context.Vehicules;
                var item = list.FirstOrDefault(t => t.Id == id);
                if (item != null)
                {
                    item.PlaqueMineralogique = value.PlaqueMineralogique;
                    item.PuissanceFiscale = value.PuissanceFiscale;
                    item.Kilometrage = value.Kilometrage;
                }
            }
        }

        // DELETE api/personne/5
        public void Delete(int id)
        {
            using (var context = new MasterDbContext())
            {
                var list = context.Vehicules;
                var item = list.FirstOrDefault(t => t.Id == id);
                if (item != null)
                {
                    list.Remove(item);
                }
            }
        }
    }
}
