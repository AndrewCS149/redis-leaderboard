﻿using RedisLeaderboard.Models;

namespace RedisLeaderboard.Interfaces
{
    public interface ILeaderboardEntryService
    {
        Task<List<LeaderboardEntryModel>> GetLeaderboardEntries();
    }
}