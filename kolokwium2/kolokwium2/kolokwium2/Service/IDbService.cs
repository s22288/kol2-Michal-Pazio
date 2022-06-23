
using kolokwium2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fighterFighters.Service
{
    public interface IDbService
    {
        // Task<IEnumerable<FireFighter>> FigherFighters();

        Task<IEnumerable<TeamDto>> GetInfoAboutAction(int id);
        void AddUser(Member member,Team team);
    }
}
