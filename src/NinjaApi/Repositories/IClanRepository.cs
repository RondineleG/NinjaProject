﻿using NinjaApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaApi.Repositories
{
    public interface IClanRepository
    {
        Task<IEnumerable<Clan>> ReadAllAsync();
        Task<Clan> ReadOneAsync(string clanName);
        Task<Clan> CreateAsync(Clan clan);
        Task<Clan> UpdateAsync(Clan clan);
        Task<Clan> DeleteAsync(string clanName);
    }
}
