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

using DigitalBiblePlatformSharp.Audio;
using DigitalBiblePlatformSharp.Core;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBiblePlatformSharp
{
    public partial class DigitalBiblePlatformClient
    {
        public async Task<Collection<AudioLocation>> GetAudioLocations(AudioProtocol protocol)
        {
            var request = new HttpRequest(ApiEndpoints.Audio.Location, baseQuery);
            request.Query.AddRequiredParameter(nameof(protocol), protocol.ToString().Replace('_', '-'));

            var response = await httpClient.ExecuteAsync<Collection<AudioLocation>>(request);
            return response ?? new Collection<AudioLocation>();
        }

        public async Task<Collection<AudioPath>> GetAudioPaths(string dam_id, AudioEncoding? encoding = null, int? book_order = null, string book_id = null, int? chapter_id = null)
        {
            var request = new HttpRequest(ApiEndpoints.Audio.Path, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);
            request.Query.AddOptionalParameter(nameof(encoding), encoding);
            request.Query.AddOptionalParameter(nameof(book_order), book_order);
            request.Query.AddOptionalParameter(nameof(book_id), book_id);
            request.Query.AddOptionalParameter(nameof(chapter_id), chapter_id);

            var response = await httpClient.ExecuteAsync<Collection<AudioPath>>(request);
            return response ?? new Collection<AudioPath>();
        }

        public async Task<Collection<AudioTimecode>> GetAudioTimecodes(string dam_id, string osis_code, int chapter_number)
        {
            var request = new HttpRequest(ApiEndpoints.Audio.VerseStart, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);
            request.Query.AddRequiredParameter(nameof(osis_code), osis_code);
            request.Query.AddRequiredParameter(nameof(chapter_number), chapter_number);

            var response = await httpClient.ExecuteAsync<Collection<AudioTimecode>>(request);
            return response ?? new Collection<AudioTimecode>();
        }
    }
}
