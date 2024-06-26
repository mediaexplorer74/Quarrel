﻿using Newtonsoft.Json;

namespace DiscordAPI.API.Guild.Models
{
    public class ModifyGuildRole
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("permissions")]
        public int Permissions { get; set; }
        [JsonProperty("position")]
        public int Position { get; set; }
        [JsonProperty("color")]
        public int Color { get; set; }
        [JsonProperty("hoist")]
        public bool Hoist { get; set; }
    }
}
