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
using DigitalBiblePlatformSharp.Video;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBiblePlatformSharp
{
    public partial class DigitalBiblePlatformClient
    {
        public async Task<Collection<VideoLocation>> GetVideoLocations()
        {
            var request = new HttpRequest(ApiEndpoints.Video.Location, baseQuery);
            var response = await httpClient.ExecuteAsync<Collection<VideoLocation>>(request);
            return response ?? new Collection<VideoLocation>();
        }

        public async Task<Collection<VideoSegment>> GetVideoSegments(string dam_id, VideoEncoding encoding, Resolution? resolution = null, int? segment_order = null, string book_id = null, int? chapter_id = null, int? verse_id = null)
        {
            var request = new HttpRequest(ApiEndpoints.Video.Path, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);
            request.Query.AddRequiredParameter(nameof(encoding), encoding);
            request.Query.AddOptionalParameter(nameof(resolution), resolution);
            request.Query.AddOptionalParameter(nameof(segment_order), segment_order);
            request.Query.AddOptionalParameter(nameof(book_id), book_id);
            request.Query.AddOptionalParameter(nameof(chapter_id), chapter_id);
            request.Query.AddOptionalParameter(nameof(verse_id), verse_id);

            var response = await httpClient.ExecuteAsync<Collection<VideoSegment>>(request);
            return response ?? new Collection<VideoSegment>();
        }
    }
}
