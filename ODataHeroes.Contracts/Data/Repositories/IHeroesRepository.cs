using ODataHeroes.Contracts.Models;
using ODataHeroes.Migrations.Entities;
using System.Collections.Generic;

namespace ODataHeroes.Contracts.Data.Repositories
{
    public interface IHeroesRepository : IRepository<Hero>
    {
        Hero GetHeroes(int id);
        List<Hero> GetAll();
    }
}