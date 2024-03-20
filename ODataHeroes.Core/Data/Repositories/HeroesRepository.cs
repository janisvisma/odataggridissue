using System;
using ODataHeroes.Contracts.Data.Repositories;
using ODataHeroes.Migrations;
using ODataHeroes.Migrations.Entities;
using System.Collections.Generic;

namespace ODataHeroes.Core.Data.Repositories
{
    public class HeroesRepository : Repository<Hero>, IHeroesRepository
    {
        public HeroesRepository(DatabaseContext context) : base(context)
        {
        }

        public Hero GetHeroes(int id)
        {
            return Get(id);
        }

        public List<Hero> GetAll()
        {
            var heroes = new List<Hero>();
            for (int i = 1; i <= 100; i++)
            {
                heroes.Add(new Hero
                {
                    Id = i,
                    Name = $"Hero {i}",
                    AddedOn = DateTime.Now,
                    Description = $"Description for Hero {i}"
                });
            }

            return heroes;
        }
    }
}