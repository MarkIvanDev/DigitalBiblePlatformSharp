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
using System.Globalization;
using System.Text;
using Newtonsoft.Json;

namespace DigitalBiblePlatformSharp.Converters
{
    public class DateConverter : JsonConverter<DateTimeOffset?>
    {
        public DateConverter() : this(null)
        {
        }

        public DateConverter(string format)
        {
            Format = format;
        }

        public override bool CanWrite => false;

        public string Format { get; }

        public override DateTimeOffset? ReadJson(JsonReader reader, Type objectType, DateTimeOffset? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if(string.IsNullOrEmpty(Format))
            {
                if (DateTimeOffset.TryParse(reader.Value?.ToString(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out var dto))
                {
                    return dto;
                }
            }
            else
            {
                if (DateTimeOffset.TryParseExact(reader.Value?.ToString(), Format, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out var dto))
                {
                    return dto;
                }
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, DateTimeOffset? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
