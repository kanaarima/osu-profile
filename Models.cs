using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public long[] NextScoreRank { get; set; }
        public int[] NextPPRank { get; set; }
        public int StdRxPlayTimeOffset { get; set; }
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

    public class FileStream {
        public bool json;
        public string content;
        public string path;

        public string Compile(Dictionary<string, string> parameters) {
            var result = content;
            foreach (var key in parameters.Keys) {
                int index = result.IndexOf($"${key}");
                if (index != -1) {
                    // Replace the first occurrence of $next_rank_score
                    result = result.Remove(index, $"${key}".Length).Insert(index, parameters[key]);
                }
            }
            return result;
        }

    }

    public class FileStreams {
        public List<FileStream> streams;

        public static FileStreams Load() {
            try {
                return JsonConvert.DeserializeObject<FileStreams>(File.ReadAllText("filestreams.json"));
            } catch { }
            var model = new FileStreams();
            model.streams = new List<FileStream>();
            return model;
        }

        public void Save() {
            File.WriteAllText("filestreams.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }
}
