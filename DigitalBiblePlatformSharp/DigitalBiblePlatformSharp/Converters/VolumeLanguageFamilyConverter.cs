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
using System.Text;
using DigitalBiblePlatformSharp.Library;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DigitalBiblePlatformSharp.Converters
{
    public class VolumeLanguageFamilyConverter : JsonConverter<VolumeLanguageFamily>
    {
        public override bool CanWrite => false;

        public override VolumeLanguageFamily ReadJson(JsonReader reader, Type objectType, VolumeLanguageFamily existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var json = JObject.Load(reader);
            existingValue = existingValue ?? (VolumeLanguageFamily)serializer.ContractResolver.ResolveContract(objectType).DefaultCreator();
            serializer.Populate(json.CreateReader(), existingValue);

            existingValue.LanguageFamily = (LanguageFamily)serializer.ContractResolver.ResolveContract(typeof(LanguageFamily)).DefaultCreator();
            serializer.Populate(json.CreateReader(), existingValue.LanguageFamily);

            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, VolumeLanguageFamily value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
