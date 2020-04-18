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

using DigitalBiblePlatformSharp.Program;
using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBiblePlatformSharp
{
    public partial class DigitalBiblePlatformClient
    {
        public async Task<Collection<StudyProgram>> GetStudyPrograms(string name = null)
        {
            var request = new HttpRequest(ApiEndpoints.Program.List, baseQuery);
            request.Query.AddOptionalParameter(nameof(name), name);

            var response = await httpClient.ExecuteAsync<Collection<StudyProgram>>(request);
            return response ?? new Collection<StudyProgram>();
        }

        public async Task<StudyProgramDetails> GetStudyProgramDetails(int id, string language = null)
        {
            var request = new HttpRequest(ApiEndpoints.Program.Details, baseQuery);
            request.Query.AddRequiredParameter(nameof(id), id);
            request.Query.AddOptionalParameter(nameof(language), language);

            var response = await httpClient.ExecuteAsync<StudyProgramDetails>(request);
            return response;
        }
    }
}
