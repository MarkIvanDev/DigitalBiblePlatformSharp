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
using DigitalBiblePlatformSharp.Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBiblePlatformSharp
{
    public partial class DigitalBiblePlatformClient
    {
        public async Task<Collection<Language>> GetLanguages(string code = null, string name = null, bool? full_word = null, bool? family_only = null, bool? possibilities = null, SortLanguageBy? sort_by = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.Language, baseQuery);
            request.Query.AddOptionalParameter(nameof(code), code);
            request.Query.AddOptionalParameter(nameof(name), name);
            request.Query.AddOptionalParameter(nameof(full_word), full_word);
            request.Query.AddOptionalParameter(nameof(family_only), family_only);
            request.Query.AddOptionalParameter(nameof(possibilities), possibilities);
            request.Query.AddOptionalParameter(nameof(sort_by), sort_by);

            var response = await httpClient.ExecuteAsync<Collection<Language>>(request);
            return response ?? new Collection<Language>();
        }

        public async Task<Collection<Library.Version>> GetVersions(string code = null, string name = null, SortLanguageBy? sort_by = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.Version, baseQuery);
            request.Query.AddOptionalParameter(nameof(code), code);
            request.Query.AddOptionalParameter(nameof(name), name);
            request.Query.AddOptionalParameter(nameof(sort_by), sort_by);

            var response = await httpClient.ExecuteAsync<Collection<Library.Version>>(request);
            return response ?? new Collection<Library.Version>();
        }

        public async Task<Collection<Volume>> GetVolumes(string dam_id = null, string fcbh_id = null, MediaType? media = null, Delivery? delivery = null, string language = null, bool? full_word = null, string language_code = null, string language_family_code = null, string updated = null, PublishingStatus? status = null, bool? dbp_agreement = null, bool? expired = null, Resolution? resolution = null, int? organization = null, SortVolumeBy? sort_by = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.Volume, baseQuery);
            request.Query.AddOptionalParameter(nameof(dam_id), dam_id);
            request.Query.AddOptionalParameter(nameof(fcbh_id), fcbh_id);
            request.Query.AddOptionalParameter(nameof(media), media);
            request.Query.AddOptionalParameter(nameof(delivery), delivery);
            request.Query.AddOptionalParameter(nameof(language), language);
            request.Query.AddOptionalParameter(nameof(full_word), full_word);
            request.Query.AddOptionalParameter(nameof(language_code), language_code);
            request.Query.AddOptionalParameter(nameof(language_family_code), language_family_code);
            request.Query.AddOptionalParameter(nameof(updated), updated);
            request.Query.AddOptionalParameter(nameof(status), status);
            request.Query.AddOptionalParameter(nameof(dbp_agreement), dbp_agreement);
            request.Query.AddOptionalParameter(nameof(expired), expired);
            request.Query.AddOptionalParameter(nameof(resolution), resolution);
            request.Query.AddOptionalParameter(nameof(organization), organization);
            request.Query.AddOptionalParameter(nameof(sort_by), sort_by);

            var response = await httpClient.ExecuteAsync<Collection<Volume>>(request);
            return response ?? new Collection<Volume>();
        }

        public async Task<Collection<VolumeLanguage>> GetVolumeLanguages(string root = null, bool? full_word = null, string language_code = null, MediaType? media = null, Delivery? delivery = null, PublishingStatus? status = null, Resolution? resolution = null, int? organization_id = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.VolumeLanguage, baseQuery);
            request.Query.AddOptionalParameter(nameof(root), root);
            request.Query.AddOptionalParameter(nameof(full_word), full_word);
            request.Query.AddOptionalParameter(nameof(language_code), language_code);
            request.Query.AddOptionalParameter(nameof(media), media);
            request.Query.AddOptionalParameter(nameof(delivery), delivery);
            request.Query.AddOptionalParameter(nameof(status), status);
            request.Query.AddOptionalParameter(nameof(resolution), resolution);
            request.Query.AddOptionalParameter(nameof(organization_id), organization_id);

            var response = await httpClient.ExecuteAsync<Collection<VolumeLanguage>>(request);
            return response ?? new Collection<VolumeLanguage>();
        }

        public async Task<Collection<VolumeLanguageFamily>> GetVolumeLanguageFamilies(string root = null, bool? full_word = null, string language_code = null, MediaType? media = null, Delivery? delivery = null, PublishingStatus? status = null, Resolution? resolution = null, int? organization_id = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.VolumeLanguageFamily, baseQuery);
            request.Query.AddOptionalParameter(nameof(root), root);
            request.Query.AddOptionalParameter(nameof(full_word), full_word);
            request.Query.AddOptionalParameter(nameof(language_code), language_code);
            request.Query.AddOptionalParameter(nameof(media), media);
            request.Query.AddOptionalParameter(nameof(delivery), delivery);
            request.Query.AddOptionalParameter(nameof(status), status);
            request.Query.AddOptionalParameter(nameof(resolution), resolution);
            request.Query.AddOptionalParameter(nameof(organization_id), organization_id);

            var response = await httpClient.ExecuteAsync<Collection<VolumeLanguageFamily>>(request);
            return response ?? new Collection<VolumeLanguageFamily>();
        }

        public async Task<Collection<VolumeOrganization>> GetVolumeOrganizations(MediaType? media = null, Delivery? delivery = null, string language = null, bool? full_word = null, string language_code = null, string language_family_code = null, string updated = null, PublishingStatus? status = null, bool? expired = null, Resolution? resolution = null, int? organization_id = null, string organization_name = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.VolumeOrganization, baseQuery);
            request.Query.AddOptionalParameter(nameof(media), media);
            request.Query.AddOptionalParameter(nameof(delivery), delivery);
            request.Query.AddOptionalParameter(nameof(language), language);
            request.Query.AddOptionalParameter(nameof(full_word), full_word);
            request.Query.AddOptionalParameter(nameof(language_code), language_code);
            request.Query.AddOptionalParameter(nameof(language_family_code), language_family_code);
            request.Query.AddOptionalParameter(nameof(updated), updated);
            request.Query.AddOptionalParameter(nameof(status), status);
            request.Query.AddOptionalParameter(nameof(expired), expired);
            request.Query.AddOptionalParameter(nameof(resolution), resolution);
            request.Query.AddOptionalParameter(nameof(organization_id), organization_id);
            request.Query.AddOptionalParameter(nameof(organization_name), organization_name);

            var response = await httpClient.ExecuteAsync<Collection<VolumeOrganization>>(request);
            return response ?? new Collection<VolumeOrganization>();
        }

        public async Task<Collection<VolumeHistory>> GetVolumeHistories(string dam_id, string submitted_by = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.VolumeHistory, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);
            request.Query.AddOptionalParameter(nameof(submitted_by), submitted_by);

            var response = await httpClient.ExecuteAsync<Collection<VolumeHistory>>(request);
            return response ?? new Collection<VolumeHistory>();
        }

        public async Task<Collection<BookOrder>> GetBookOrders(string dam_id)
        {
            var request = new HttpRequest(ApiEndpoints.Library.BookOrder, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);

            var response = await httpClient.ExecuteAsync<Collection<BookOrder>>(request);
            return response ?? new Collection<BookOrder>();
        }

        public async Task<Collection<Book>> GetBooks(string dam_id)
        {
            var request = new HttpRequest(ApiEndpoints.Library.Book, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);

            var response = await httpClient.ExecuteAsync<Collection<Book>>(request);
            return response ?? new Collection<Book>();
        }

        public async Task<Dictionary<string, string>> GetBookNames(string language_code)
        {
            var request = new HttpRequest(ApiEndpoints.Library.BookName, baseQuery);
            request.Query.AddRequiredParameter(nameof(language_code), language_code);

            var response = await httpClient.ExecuteAsync<Collection<Dictionary<string, string>>>(request);
            return response?.FirstOrDefault() ?? new Dictionary<string, string>();
        }

        public async Task<Collection<Chapter>> GetChapters(string dam_id, string book_id = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.Chapter, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);
            request.Query.AddOptionalParameter(nameof(book_id), book_id);

            var response = await httpClient.ExecuteAsync<Collection<Chapter>>(request);
            return response ?? new Collection<Chapter>();
        }

        public async Task<Dictionary<string, Dictionary<int, int[]>>> GetVerseInfo(string dam_id, string book_id = null, int? chapter_id = null, int? verse_start = null, int? verse_end = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.VerseInfo, baseQuery);
            request.Query.AddRequiredParameter(nameof(dam_id), dam_id);
            request.Query.AddOptionalParameter(nameof(book_id), book_id);
            request.Query.AddOptionalParameter(nameof(chapter_id), chapter_id);
            request.Query.AddOptionalParameter(nameof(verse_start), verse_start);
            request.Query.AddOptionalParameter(nameof(verse_end), verse_end);

            var response = await httpClient.ExecuteAsync<Dictionary<string, Dictionary<int, int[]>>>(request);
            return response ?? new Dictionary<string, Dictionary<int, int[]>>();
        }

        public async Task<Dictionary<string, string>> GetNumbers(string language_code, int start, int end)
        {
            var request = new HttpRequest(ApiEndpoints.Library.Numbers, baseQuery);
            request.Query.AddRequiredParameter(nameof(language_code), language_code);
            request.Query.AddRequiredParameter(nameof(start), start);
            request.Query.AddRequiredParameter(nameof(end), end);

            var response = await httpClient.ExecuteAsync<Collection<Dictionary<string, string>>>(request);
            return response?.FirstOrDefault() ?? new Dictionary<string, string>();
        }

        public async Task<Collection<Metadata>> GetMetadata(string dam_id = null, int? organization_id = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.Metadata, baseQuery);
            request.Query.AddOptionalParameter(nameof(dam_id), dam_id);
            request.Query.AddOptionalParameter(nameof(organization_id), organization_id);

            var response = await httpClient.ExecuteAsync<Collection<Metadata>>(request);
            return response ?? new Collection<Metadata>();
        }

        public async Task<Collection<AssetLocation>> GetAssetLocations(string dam_id = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.Asset, baseQuery);
            request.Query.AddOptionalParameter(nameof(dam_id), dam_id);

            var response = await httpClient.ExecuteAsync<Collection<AssetLocation>>(request);
            return response ?? new Collection<AssetLocation>();
        }

        public async Task<Collection<Organization>> GetOrganizations(string name = null, int? id = null, bool? enabled = null)
        {
            var request = new HttpRequest(ApiEndpoints.Library.Organization, baseQuery);
            request.Query.AddOptionalParameter(nameof(name), name);
            request.Query.AddOptionalParameter(nameof(id), id);
            request.Query.AddOptionalParameter(nameof(enabled), !enabled.HasValue ? "either" : enabled.Value ? "true" : "false");

            var response = await httpClient.ExecuteAsync<Collection<Organization>>(request);
            return response ?? new Collection<Organization>();
        }
    }
}
