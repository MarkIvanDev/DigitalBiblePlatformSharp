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

using DigitalBiblePlatformSharp.Core;
using DigitalBiblePlatformSharp.Text;
using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBiblePlatformSharp
{
    public partial class DigitalBiblePlatformClient
    {
        public async Task<Collection<Font>> GetFonts(int? id = null, string name = null, Platform? platform = null)
        {
            var request = new HttpRequest(ApiEndpoints.Text.Font, baseQuery);
            request.Query.AddOptionalParameter(nameof(id), id);
            request.Query.AddOptionalParameter(nameof(name), name);
            request.Query.AddOptionalParameter(nameof(platform), platform);

            var response = await httpClient.ExecuteAsync<Collection<Font>>(request);
            return response ?? new Collection<Font>();
        }

        public async Task<Collection<Verse>> GetText(string dam_id, string book_id = null, int? chapter_id = null, int? verse_start = null, int? verse_end = null)
        {
            var request = new HttpRequest(ApiEndpoints.Text.Verse, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);
            request.Query.AddOptionalParameter(nameof(book_id), book_id);
            request.Query.AddOptionalParameter(nameof(chapter_id), chapter_id);
            request.Query.AddOptionalParameter(nameof(verse_start), verse_start);
            request.Query.AddOptionalParameter(nameof(verse_end), verse_end);

            var response = await httpClient.ExecuteAsync<Collection<Verse>>(request);
            return response ?? new Collection<Verse>();
        }

        public async Task<Collection<SearchResult>> GetSearchResults(string dam_id, string query, string book_id = null, int? offset = null, int? limit = null)
        {
            var request = new HttpRequest(ApiEndpoints.Text.Search, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);
            request.Query.AddRequiredParameter(nameof(query), query);
            request.Query.AddOptionalParameter(nameof(book_id), book_id);
            request.Query.AddOptionalParameter(nameof(offset), offset);
            request.Query.AddOptionalParameter(nameof(limit), limit);

            var response = await httpClient.ExecuteAsync<Collection<SearchResult>>(request);
            return response ?? new Collection<SearchResult>();
        }

        public async Task<SearchGroupResults> GetSearchGroupResults(string dam_id, string query)
        {
            var request = new HttpRequest(ApiEndpoints.Text.Search, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);
            request.Query.AddRequiredParameter(nameof(query), query);

            var response = await httpClient.ExecuteAsync<SearchGroupResults>(request);
            return response ?? new SearchGroupResults();
        }
    }
}
