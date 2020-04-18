// MIT License

// Copyright(c) 2020 Mark Ivan Basto

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using System.Text;
using DigitalBiblePlatformSharp.Converters;
using DigitalBiblePlatformSharp.Core;
using Newtonsoft.Json;

namespace DigitalBiblePlatformSharp.Library
{
    [JsonConverter(typeof(VolumeConverter))]
    public class Volume
    {
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        [JsonProperty("fcbh_id")]
        public string FcbhId { get; set; }

        [JsonProperty("volume_name")]
        public string Name { get; set; }

        public Version Version { get; set; }

        [JsonProperty("status")]
        public PublishingStatus Status { get; set; }

        [JsonProperty("dbp_agreement")]
        public bool Agreement { get; set; }

        [JsonProperty("created_on")]
        [JsonConverter(typeof(DateConverter))]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        [JsonConverter(typeof(DateConverter))]
        public DateTimeOffset? UpdatedOn { get; set; }

        [JsonProperty("expiration")]
        [JsonConverter(typeof(DateConverter), "yyyy-MM-dd")]
        public DateTimeOffset? Expiration { get; set; }

        [JsonProperty("right_to_left")]
        public bool RightToLeft { get; set; }

        [JsonProperty("num_art")]
        public int ArtCount { get; set; }

        [JsonProperty("num_sample_audio")]
        public int SampleAudioCount { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("collection_code")]
        public CollectionType Collection { get; set; }

        [JsonProperty("collection_name")]
        public string CollectionName { get; set; }

        [JsonProperty("media_type")]
        public DramaType DramaType { get; set; }

        [JsonProperty("media")]
        public MediaType MediaType { get; set; }

        [JsonProperty("delivery")]
        public Delivery[] DeliveryMethods { get; set; }

        [JsonProperty("resolution")]
        public Resolution[] Resolutions { get; set; }

        public Language Language { get; set; }

        public LanguageFamily LanguageFamily { get; set; }

        [JsonProperty("font")]
        public Font Font { get; set; }

        [JsonProperty("audio_zip_path")]
        public string AudioZipPath { get; set; }
    }

}
