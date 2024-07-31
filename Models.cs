using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_stats
{
    public class Settings
    {
        public int UserID { get; set; }
        public int[] ClearsPage { get; set; }
        public int[] Clears { get; set; }
        public int[] ClearsOld { get; set; }
        public int[] Firsts { get; set; }
        public int[] FirstsOld { get; set; }
        public int[] ScoreRank { get; set; }
        public int[] ScoreRankOld { get; set; }
        public int DefaultGameMode { get; set; }
        public string NewJson { get; set; }
        public string OldJson { get; set; }
        public Dictionary<string, bool> Fields { get; set; }

        public static Settings Load() {
            try {
                return JsonConvert.DeserializeObject<Settings>(File.ReadAllText("settings.json"));
            } catch {
                return new Settings();
            }
        }

        public void Save() {
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }

    public class LeaderboardModel()
    {
        public DateTime LastUpdated { get; set; }
        public static LeaderboardModel Load(bool reset = false) {
            try {
                if (!reset)
                    return JsonConvert.DeserializeObject<LeaderboardModel>(File.ReadAllText("leaderboard.json"));
            } catch { }
            var model = new LeaderboardModel();
            model.LastUpdated = DateTime.FromFileTimeUtc(0);
            return model;
        }

        public void Save() {
            File.WriteAllText("leaderboard.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }

}
