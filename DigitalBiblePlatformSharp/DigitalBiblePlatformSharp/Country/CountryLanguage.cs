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
using Newtonsoft.Json;

namespace DigitalBiblePlatformSharp.Country
{
    public class CountryLanguage
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country_primary")]
        public string CountryIso { get; set; }

        [JsonProperty("primary_country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_image")]
        public string Image { get; set; }

        [JsonProperty("lang_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("iso_language_code")]
        public string LanguageIso { get; set; }

        [JsonProperty("regional_lang_name")]
        public string LanguageName { get; set; }

        [JsonProperty("family_id")]
        public string LanguageFamilyCode { get; set; }

        [JsonProperty("country_additional")]
        public string Additional { get; set; }

    }
}
