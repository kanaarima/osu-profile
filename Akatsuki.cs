using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace osu_stats
{
    internal class Akatsuki
    {

        public class UserInfo
        {

            public string Json { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("stats")]
            public List<Stat> Stats { get; set; }

            [JsonProperty("clan")]
            public Clan Clan { get; set; }

            [JsonProperty("followers")]
            public int Followers { get; set; }

            [JsonProperty("chosen_mode")]
            public Mode ChosenMode { get; set; }
        }

        public class Stat
        {
            [JsonProperty("std")]
            public Mode Std { get; set; }

            [JsonProperty("taiko")]
            public Mode Taiko { get; set; }

            [JsonProperty("ctb")]
            public Mode Ctb { get; set; }

            [JsonProperty("mania")]
            public Mode Mania { get; set; }
        }

        public class Mode
        {
            [JsonProperty("ranked_score")]
            public long RankedScore { get; set; }

            [JsonProperty("total_score")]
            public long TotalScore { get; set; }

            [JsonProperty("playcount")]
            public int Playcount { get; set; }

            [JsonProperty("playtime")]
            public int Playtime { get; set; }

            [JsonProperty("replays_watched")]
            public int ReplaysWatched { get; set; }

            [JsonProperty("total_hits")]
            public int TotalHits { get; set; }

            [JsonProperty("level")]
            public double Level { get; set; }

            [JsonProperty("accuracy")]
            public double Accuracy { get; set; }

            [JsonProperty("pp")]
            public int Pp { get; set; }

            [JsonProperty("global_leaderboard_rank")]
            public int? GlobalLeaderboardRank { get; set; }

            [JsonProperty("country_leaderboard_rank")]
            public int? CountryLeaderboardRank { get; set; }

            [JsonProperty("max_combo")]
            public int MaxCombo { get; set; }

            [JsonProperty("grades")]
            public Grades Grades { get; set; }
        }

        public class Grades
        {
            [JsonProperty("xh_count")]
            public int XhCount { get; set; }

            [JsonProperty("x_count")]
            public int XCount { get; set; }

            [JsonProperty("sh_count")]
            public int ShCount { get; set; }

            [JsonProperty("s_count")]
            public int SCount { get; set; }

            [JsonProperty("a_count")]
            public int ACount { get; set; }

            [JsonProperty("b_count")]
            public int BCount { get; set; }

            [JsonProperty("c_count")]
            public int CCount { get; set; }

            [JsonProperty("d_count")]
            public int DCount { get; set; }
        }

        public class Clan
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("tag")]
            public string Tag { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }

            [JsonProperty("owner")]
            public int Owner { get; set; }

            [JsonProperty("status")]
            public int Status { get; set; }
        }

        public class Difficulty
        {
            [JsonProperty("std")]
            public int Std { get; set; }

            [JsonProperty("taiko")]
            public int Taiko { get; set; }

            [JsonProperty("ctb")]
            public int Ctb { get; set; }

            [JsonProperty("mania")]
            public int Mania { get; set; }
        }

        public class Beatmap
        {
            [JsonProperty("beatmap_id")]
            public int BeatmapId { get; set; }

            [JsonProperty("beatmapset_id")]
            public int BeatmapsetId { get; set; }

            [JsonProperty("beatmap_md5")]
            public string BeatmapMd5 { get; set; }

            [JsonProperty("song_name")]
            public string SongName { get; set; }

            [JsonProperty("ar")]
            public double Ar { get; set; }

            [JsonProperty("od")]
            public double Od { get; set; }

            [JsonProperty("difficulty")]
            public int Difficulty { get; set; }

            [JsonProperty("difficulty2")]
            public Difficulty Difficulty2 { get; set; }

            [JsonProperty("max_combo")]
            public int MaxCombo { get; set; }

            [JsonProperty("hit_length")]
            public int HitLength { get; set; }

            [JsonProperty("ranked")]
            public int Ranked { get; set; }

            [JsonProperty("ranked_status_frozen")]
            public int RankedStatusFrozen { get; set; }

            [JsonProperty("latest_update")]
            public DateTime LatestUpdate { get; set; }
        }

        public class Score
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("beatmap_md5")]
            public string BeatmapMd5 { get; set; }

            [JsonProperty("score")]
            public int ScoreValue { get; set; }

            [JsonProperty("max_combo")]
            public int MaxCombo { get; set; }

            [JsonProperty("full_combo")]
            public bool FullCombo { get; set; }

            [JsonProperty("mods")]
            public int Mods { get; set; }

            [JsonProperty("count_300")]
            public int Count300 { get; set; }

            [JsonProperty("count_100")]
            public int Count100 { get; set; }

            [JsonProperty("count_50")]
            public int Count50 { get; set; }

            [JsonProperty("count_geki")]
            public int CountGeki { get; set; }

            [JsonProperty("count_katu")]
            public int CountKatu { get; set; }

            [JsonProperty("count_miss")]
            public int CountMiss { get; set; }

            [JsonProperty("time")]
            public DateTime Time { get; set; }

            [JsonProperty("play_mode")]
            public int PlayMode { get; set; }

            [JsonProperty("accuracy")]
            public double Accuracy { get; set; }

            [JsonProperty("pp")]
            public double Pp { get; set; }

            [JsonProperty("rank")]
            public string Rank { get; set; }

            [JsonProperty("completed")]
            public int Completed { get; set; }

            [JsonProperty("pinned")]
            public bool Pinned { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("beatmap")]
            public Beatmap Beatmap { get; set; }
        }

        public class UserScores
        {
            [JsonProperty("scores")]
            public List<Score> Scores { get; set; }
        }

        public class Leaderboard
        {
            public string Json { get; set; }

            [JsonProperty("users")]
            public List<UserInfo> Users { get; set; }
        }

        public static UserInfo GetUserInfo(int user_id) {
            using (HttpClient client = new HttpClient()) {
                try {
                    // Send a GET request
                    HttpResponseMessage response = client.GetAsync($"https://akatsuki.gg/api/v1/users/full?id={user_id}").Result;
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    UserInfo json = JsonConvert.DeserializeObject<UserInfo>(responseBody);
                    json.Json = responseBody;
                    Thread.Sleep(250);
                    return json;
                } catch (Exception ex) {
                    throw ex;
                }
            }

        }

        public static UserScores GetUserScores(int user_id, int mode, int relax, int page) {
            using (HttpClient client = new HttpClient()) {
                try {
                    // Send a GET request
                    HttpResponseMessage response = client.GetAsync($"https://akatsuki.gg/api/v1/users/scores/best?mode={mode}&p={page}&l=100&rx={relax}&id={user_id}").Result;
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    UserScores json = JsonConvert.DeserializeObject<UserScores>(responseBody);
                    Thread.Sleep(500);
                    return json;
                } catch (Exception ex) {
                    throw ex;
                }
            }

        }

        public static Leaderboard GetScoreLeaderboard(int mode, int relax, int page, int size=500) {
            using (HttpClient client = new HttpClient()) {
                try {
                    // Send a GET request
                    HttpResponseMessage response = client.GetAsync($"https://akatsuki.gg/api/v1/leaderboard?mode={mode}&rx={relax}&p={page}&l={size}&country=&sort=score").Result;
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    Leaderboard json = JsonConvert.DeserializeObject<Leaderboard>(responseBody);
                    json.Json = responseBody;
                    Thread.Sleep(500);
                    return json;
                } catch (Exception ex) {
                    throw ex;
                }
            }

        }

    }

}
