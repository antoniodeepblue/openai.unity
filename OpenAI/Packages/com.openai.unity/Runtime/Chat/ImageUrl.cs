// Licensed under the MIT License. See LICENSE in the project root for license information.

using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace OpenAI.Chat
{
    [Preserve]
    public sealed class ImageUrl
    {
        [Preserve]
        [JsonConstructor]
        public ImageUrl(string url)
        {
            Url = url;
        }

        [Preserve]
        [JsonProperty("url")]
        public string Url { get; private set; }
    }
}
