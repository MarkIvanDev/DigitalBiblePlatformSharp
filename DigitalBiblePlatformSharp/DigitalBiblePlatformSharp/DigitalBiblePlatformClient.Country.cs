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
using DigitalBiblePlatformSharp.Country;
using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBiblePlatformSharp
{
    public partial class DigitalBiblePlatformClient
    {
        public async Task<Collection<CountryLanguage>> GetCountryLanguages(string lang_code = null, string country_code = null, bool? additional = null, ImageType? img_type = null, string img_size = null, SortCountryLanguageBy? sort_by = null)
        {
            var request = new HttpRequest(ApiEndpoints.Country.Language, baseQuery);
            request.Query.AddOptionalParameter(nameof(lang_code), lang_code);
            request.Query.AddOptionalParameter(nameof(country_code), country_code);
            request.Query.AddOptionalParameter(nameof(additional), !additional.HasValue ? (int?)null : additional.Value ? 1 : 0);
            request.Query.AddOptionalParameter(nameof(img_type), img_type);
            if (img_type == ImageType.png)
            {
                request.Query.AddRequiredParameter(nameof(img_size), img_size);
            }
            else
            {
                request.Query.AddOptionalParameter(nameof(img_size), img_size);
            }
            request.Query.AddOptionalParameter(nameof(sort_by), sort_by);

            var response = await httpClient.ExecuteAsync<Collection<CountryLanguage>>(request);
            return response ?? new Collection<CountryLanguage>();
        }
    }
}
