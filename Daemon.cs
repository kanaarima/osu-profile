﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace osu_stats
{
    internal class Daemon
    {
        public class LeaderboardModel()
        {
            public DateTime LastUpdated { get; set; }
            public static LeaderboardModel Load(bool reset=false) {
                try {
                    if (!reset)
                        return JsonConvert.DeserializeObject<LeaderboardModel>(File.ReadAllText("leaderboard.json"));
                } catch {}
                var model = new LeaderboardModel();
                model.LastUpdated = DateTime.FromFileTimeUtc(0);
                return model;
            }

            public void Save() {
                File.WriteAllText("leaderboard.json", JsonConvert.SerializeObject(this, Formatting.Indented));
            }
        }
        public Daemon() { }

        public void Start() {
            Thread thread = new Thread(new ThreadStart(Run));
            thread.IsBackground = true;
            thread.Start();
        }
        public void Run() {
            while (true) {
                try {
                    var settings = Settings.Load();
                    (int, int)[] modes = new (int, int)[] {
                    (0,0), (0,1), (0,2), (1,0), (1,1), (2,0), (2,1), (3,0) };

                    if (settings.UserID == 0) {
                        Thread.Sleep(1000 * 60);
                        continue;
                    }
                    Trace.TraceInformation("Starting stats update cycle");
                    var statistics = Akatsuki.GetUserInfo(settings.UserID);
                    settings.NewJson = statistics.Json;

                    if (settings.OldJson == null)
                        settings.OldJson = statistics.Json;

                    if (settings.Clears == null) {
                        Trace.TraceInformation("Users clears never fetched, starting initial cycle");
                        settings.ClearsPage = new int[8];
                        settings.Clears = new int[8];
                        for (int i = 0; i < modes.Length; i++) {
                            var mode = modes[i];
                            var page = 1;
                            var size = 0;
                            while (true) {
                                Trace.TraceInformation($"Finding clears page: {page}");
                                var response = Akatsuki.GetUserScores(settings.UserID, mode.Item1, mode.Item2, page);
                                if (response.Scores == null || response.Scores.Count != 100) {
                                    Trace.TraceInformation($"Found clears page: {page}");
                                    break;
                                }
                                page += 10;
                            }
                            Trace.TraceInformation("Trying to find precise page");
                            while (true) {
                                var response = Akatsuki.GetUserScores(settings.UserID, mode.Item1, mode.Item2, page);
                                if (response.Scores != null && response.Scores.Count > 0) {
                                    size = response.Scores.Count;
                                    break;
                                }
                                page -= 1;
                                if (page < 1) {
                                    page = 1;
                                    size = 0;
                                    break;
                                }
                            }
                            settings.ClearsPage[i] = page;
                            settings.Clears[i] = (page - 1) * 100 + size;
                        }
                    }
                    // Update clears for all modes
                    if (settings.ClearsOld == null) {
                        settings.ClearsOld = (int[]?)settings.Clears.Clone();
                    }
                    Trace.TraceInformation("Updating clears");
                    for (int i = 0; i < modes.Length; i++) {
                        var mode = modes[i];
                        var page = settings.ClearsPage[i];
                        while (true) {
                            var response = Akatsuki.GetUserScores(settings.UserID, mode.Item1, mode.Item2, page);
                            if (response.Scores == null) {
                                break;
                            }
                            if (response.Scores.Count != 100) {
                                settings.Clears[i] = (page - 1) * 100 + response.Scores.Count;
                                break;
                            }
                            page += 1;
                        }
                        settings.ClearsPage[i] = page;
                    }
                    Trace.TraceInformation("Updating score rank");
                    // Check score leaderboard for score rank
                    var leaderboards = LeaderboardModel.Load();
                    var difference = DateTime.Now - leaderboards.LastUpdated;
                    if (difference.TotalMinutes > 15) {
                        settings.ScoreRank = new int[8];
                        for (int i = 0; i < modes.Length; i++) {
                            var mode = modes[i];
                            var response = Akatsuki.GetScoreLeaderboard(mode.Item1, mode.Item2, 1);
                            var rank = 1;
                            var found = false;
                            foreach (var user in response.Users) {
                                if (user.Id == settings.UserID) {
                                    found = true;
                                    break;
                                }
                                rank += 1;
                            }
                            if (!found)
                                rank = -1;
                            settings.ScoreRank[i] = rank;
                        }
                        if (settings.ScoreRankOld == null)
                            settings.ScoreRankOld = (int[]?)settings.ScoreRank.Clone();
                    }
                    leaderboards.Save();
                    settings.Save();
                    Thread.Sleep(1000 * 60);
                } catch (Exception e){
                    Program.LogException(e);
                }
            }
        }
    }
}
