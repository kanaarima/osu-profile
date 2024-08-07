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
            public List<Mode> Stats { get; set; }

            [JsonProperty("clan")]
            public Clan Clan { get; set; }

            [JsonProperty("followers")]
            public int Followers { get; set; }

            [JsonProperty("chosen_mode")]
            public Stats ChosenMode { get; set; }
        }

        public class Mode
        {
            [JsonProperty("std")]
            public Stats Std { get; set; }

            [JsonProperty("taiko")]
            public Stats Taiko { get; set; }

            [JsonProperty("ctb")]
            public Stats Ctb { get; set; }

            [JsonProperty("mania")]
            public Stats Mania { get; set; }
        }

        public class Stats
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

        public class UserFirsts
        {
            [JsonProperty("total")]
            public int Total { get; set; }
            [JsonProperty("scores")]
            public List<Score> Scores { get; set; }
        }

        public class Leaderboard
        {
            public string Json { get; set; }

            [JsonProperty("users")]
            public List<UserInfo> Users { get; set; }
        }

        public static string GetResponse(string url) {
            using (HttpClient client = new HttpClient()) {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("osu-profile/0.0.1 (+https://github.com/kanaarima/osu-profile)");
                while (true) {
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    if (!response.IsSuccessStatusCode) {
                        if ((int)response.StatusCode < 500) {
                            return "";
                        } else {
                            Thread.Sleep(2000);
                            continue;
                        }
                    }
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        public static UserInfo GetUserInfo(int user_id) {
            var responseBody = GetResponse($"https://akatsuki.gg/api/v1/users/full?id={user_id}");
            UserInfo json = JsonConvert.DeserializeObject<UserInfo>(responseBody);
            json.Json = responseBody;
            Thread.Sleep(250);
            return json;
        }

        public static UserScores GetUserScores(int user_id, int mode, int relax, int page, int size=100) {
            var responseBody = GetResponse($"https://akatsuki.gg/api/v1/users/scores/best?mode={mode}&p={page}&l={size}&rx={relax}&id={user_id}");
            UserScores json = JsonConvert.DeserializeObject<UserScores>(responseBody);
            Thread.Sleep(500);
            return json;
        }

        public static UserFirsts GetUserFirsts(int user_id, int mode, int relax, int page, int size=100) {
            var responseBody = GetResponse($"https://akatsuki.gg/api/v1/users/scores/first?mode={mode}&p={page}&l={size}&rx={relax}&id={user_id}");
            UserFirsts json = JsonConvert.DeserializeObject<UserFirsts>(responseBody);
            Thread.Sleep(500);
            return json;
        }

        public static Leaderboard GetScoreLeaderboard(int mode, int relax, int page, int size=500) {
            var responseBody = GetResponse($"https://akatsuki.gg/api/v1/leaderboard?mode={mode}&rx={relax}&p={page}&l={size}&country=&sort=score");
            Leaderboard json = JsonConvert.DeserializeObject<Leaderboard>(responseBody);
            json.Json = responseBody;
            Thread.Sleep(500);
            return json;
        }

        public static Leaderboard GetPPLeaderboard(int mode, int relax, int page, int size = 500) {
            var responseBody = GetResponse($"https://akatsuki.gg/api/v1/leaderboard?mode={mode}&rx={relax}&p={page}&l={size}&country=&sort=pp");
            Leaderboard json = JsonConvert.DeserializeObject<Leaderboard>(responseBody);
            json.Json = responseBody;
            Thread.Sleep(500);
            return json;
        }

    }

}
