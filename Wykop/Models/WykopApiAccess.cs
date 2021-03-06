﻿using Newtonsoft.Json;

namespace Wykop.Models
{
    public class WykopApiAccess
    {
        [JsonProperty("ApiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Secret")]
        public string Secret { get; set; }
    }
}
