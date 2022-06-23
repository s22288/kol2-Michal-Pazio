
using kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fighterFighters.Service
{
    public class DbService : IDbService
    {
        private readonly MainDbContext _dbContext;

        public DbService(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    
        public void AddUser(Member member,Team team)

        {
            if(member.Organization.OrganizationID == team.OrganizationID)
            {
                _dbContext.Members.Add(member);
            }
            _dbContext.SaveChanges();
            
        }

        public Task<IEnumerable<TeamDto>> GetInfoAboutAction(int id)
        {
            throw new NotImplementedException();
        }





        //    public async Task<bool> DelteActionById(int id)
        //    {
        //        var action = await _dbContext.Actions.FindAsync(id);
        //        if (action == null)
        //            throw new NullReferenceException("Not Found Action reply");
        //        if (action.StartTime > DateTime.Now) {
        //            return false;
        //        }
        //        var firefighter_actions = (from fa in _dbContext.Firefighter_Actions
        //                                   where fa.IdAction == id
        //                                   select fa).ToList();
        //        var firetruck_actions = (from fa in _dbContext.FireTruck_Actions
        //                                 where fa.IdAction == id select fa).ToList();
        //        foreach (var fa in firefighter_actions) {
        //            _dbContext.Firefighter_Actions.Remove(fa);
        //        }
        //        foreach (var fa in firetruck_actions) {
        //            _dbContext.FireTruck_Actions.Remove(fa);
        //        }
        //        _dbContext.Actions.Remove(action);
        //        await _dbContext.SaveChangesAsync();
        //        return true;
        //    } 


        //    public async Task<IEnumerable<FireFighter>> FigherFighters()
        //    {
        //    return  await  _dbContext.FireFighters.ToListAsync();
        //    }

        //    public async Task<IEnumerable<ActionDto>> GetInfoAboutAction(int id)
        //    {

        //        return await _dbContext.Actions.Include(e => e.Firefighter_Actions).Where(e => e.IdAction == id).Select(e => new ActionDto
        //        {
        //            IdAction = e.IdAction,
        //            StartTime = e.StartTime,
        //            EndTime = e.EndTime,
        //            NeedSecialEquipment = e.NeedSecialEquipment,
        //        fireFighters = e.Firefighter_Actions.Select(e => new FireFighterDto { IdFirefighter = e.FireFighter.IdFirefighter, FirstName = e.FireFighter.FirstName, LastName = e.FireFighter.LastName}).ToList(),
        //        }).ToListAsync();

        //    }
        //}
    }
}
