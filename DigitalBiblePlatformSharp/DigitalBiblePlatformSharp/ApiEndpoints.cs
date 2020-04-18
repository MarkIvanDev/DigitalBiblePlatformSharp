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

namespace DigitalBiblePlatformSharp
{
    public static class ApiEndpoints
    {
        public static string Base => "https://dbt.io/";

        public static class Library
        {
            public static string Language => "library/language";

            public static string Version => "library/version";

            public static string Volume => "library/volume";

            public static string VolumeLanguage => "library/volumelanguage";

            public static string VolumeLanguageFamily => "library/volumelanguagefamily";

            public static string VolumeOrganization => "library/volumeorganization";

            public static string VolumeHistory => "library/volumehistory";

            public static string BookOrder => "library/bookorder";

            public static string Book => "library/book";

            public static string BookName => "library/bookname";

            public static string Chapter => "library/chapter";

            public static string VerseInfo => "library/verseinfo";

            public static string Numbers => "library/numbers";

            public static string Metadata => "library/metadata";

            public static string Asset => "library/asset";

            public static string Organization => "library/organization";

            public static string JesusFilm => "library/jesusfilm";
        }

        public static class Audio
        {
            public static string Location => "audio/location";

            public static string Path => "audio/path";

            public static string VerseStart => "audio/versestart";
        }

        public static class Text
        {
            public static string Font => "text/font";

            public static string Verse => "text/verse";

            public static string Search => "text/search";

            public static string SearchGroup => "text/searchgroup";
        }

        public static class Video
        {
            public static string Location => "video/videolocation";

            public static string Path => "video/videopath";
        }

        public static class Country
        {
            public static string Language => "country/countrylang";
        }

        public static class Program
        {
            public static string Details => "programs/program";

            public static string List => "programs/list";
        }
    }
}
