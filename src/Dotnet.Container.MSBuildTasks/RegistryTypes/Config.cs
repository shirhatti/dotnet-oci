﻿using Newtonsoft.Json;

namespace dotnet_container.RegistryTypes
{
    public class Config
    {
        [JsonProperty("mediaType")]
        public string MediaType { get; set; }
        [JsonProperty("size")]
        public long Size { get; set; }
        [JsonProperty("digest")]
        public string Digest { get; set; }
    }
}