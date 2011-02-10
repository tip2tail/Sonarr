using System.Collections.Generic;
using NzbDrone.Core.Repository;

namespace NzbDrone.Core.Providers
{
    public interface ISeasonProvider
    {
        Season GetSeason(int seasonId);
        List<Season> GetSeasons(int seriesId);
        Season GetLatestSeason(int seriesId);
        void EnsureSeason(int seriesId, int seasonId, int seasonNumber);
        int SaveSeason(Season season);
        bool IsIgnored(int seasonId);
        bool IsIgnored(int seriesId, int seasonNumber);
    }
}