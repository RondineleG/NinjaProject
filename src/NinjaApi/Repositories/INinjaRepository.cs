﻿using NinjaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaApi.Repositories
{
    public interface INinjaRepository
    {
        Task<IEnumerable<Ninja>> ReadAllAsync();
        Task<IEnumerable<Ninja>> ReadAllInClanAsync(string clanName);
        Task<Ninja> ReadOneAsync(string clanName, string ninjaKey);
        Task<Ninja> CreateAsync(Ninja ninja);
        Task<Ninja> UpdateAsync(Ninja ninja);
        Task<Ninja> DeleteAsync(string clanName, string ninjaKey);
    }
}
