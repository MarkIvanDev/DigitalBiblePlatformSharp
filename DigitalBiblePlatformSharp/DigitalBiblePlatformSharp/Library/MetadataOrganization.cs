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
using DigitalBiblePlatformSharp.Core;
using Newtonsoft.Json;

namespace DigitalBiblePlatformSharp.Library
{
    public class MetadataOrganization
    {
        [JsonProperty("organization_id")]
        public int Id { get; set; }

        [JsonProperty("organization")]
        public string Name { get; set; }

        [JsonProperty("organization_english")]
        public string EnglishName { get; set; }

        [JsonProperty("organization_role")]
        public OrganizationRole Role { get; set; }

        [JsonProperty("organization_url")]
        public string Url { get; set; }

        [JsonProperty("organization_donation")]
        public string Donation { get; set; }

        [JsonProperty("organization_address")]
        public string Address { get; set; }

        [JsonProperty("organization_address2")]
        public string Address2 { get; set; }

        [JsonProperty("organization_city")]
        public string City { get; set; }

        [JsonProperty("organization_state")]
        public string State { get; set; }

        [JsonProperty("organization_country")]
        public string Country { get; set; }

        [JsonProperty("organization_zip")]
        public string Zip { get; set; }

        [JsonProperty("organization_phone")]
        public string Phone { get; set; }
    }
}
