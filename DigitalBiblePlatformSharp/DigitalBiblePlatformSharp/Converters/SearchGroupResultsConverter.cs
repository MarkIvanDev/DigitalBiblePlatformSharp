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
using System.Collections.ObjectModel;
using System.Text;
using DigitalBiblePlatformSharp.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DigitalBiblePlatformSharp.Converters
{
    public class SearchGroupResultsConverter : JsonConverter<SearchGroupResults>
    {
        public override bool CanWrite => false;

        public override SearchGroupResults ReadJson(JsonReader reader, Type objectType, SearchGroupResults existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var results = new SearchGroupResults();

            var json = JToken.Load(reader);
            if(json.Type == JTokenType.Array)
            {
                results.TotalResults = json.First.First.SelectToken("total_results")?.ToObject<int>() ?? 0;
                
                if(json.First.Next is JArray array)
                {
                    var items = new Collection<SearchGroupResult>();
                    foreach (var a in array)
                    {
                        var item = new SearchGroupResult();
                        serializer.Populate(a.CreateReader(), item);
                        items.Add(item);
                    }
                    results.Items = items;
                }
                
            }

            return results;
        }

        public override void WriteJson(JsonWriter writer, SearchGroupResults value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
