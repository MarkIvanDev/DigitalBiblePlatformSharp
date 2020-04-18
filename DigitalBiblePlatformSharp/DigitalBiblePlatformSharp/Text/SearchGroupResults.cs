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
using System.Collections.ObjectModel;
using System.Text;
using DigitalBiblePlatformSharp.Converters;
using Newtonsoft.Json;

namespace DigitalBiblePlatformSharp.Text
{
    [JsonConverter(typeof(SearchGroupResultsConverter))]
    public class SearchGroupResults
    {
        public SearchGroupResults()
        {
            Items = new Collection<SearchGroupResult>();
        }

        public int TotalResults { get; set; }

        public Collection<SearchGroupResult> Items { get; set; }
    }

    public class SearchGroupResult
    {
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        [JsonProperty("book_name")]
        public string BookName { get; set; }

        [JsonProperty("book_id")]
        public string BookCode { get; set; }

        [JsonProperty("book_order")]
        public string BookOrder { get; set; }

        [JsonProperty("chapter_id")]
        public int Chapter { get; set; }

        [JsonProperty("verse_id")]
        public int Verse { get; set; }

        [JsonProperty("verse_text")]
        public string Text { get; set; }

        [JsonProperty("results")]
        public int Results { get; set; }
    }
}
