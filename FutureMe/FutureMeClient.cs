using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FutureMe
{
    public class FutureMeClient
    {
        public HttpClient UserClient { get; init; } = new()
        {
            BaseAddress = new Uri("https://futuremeuserapi.azurewebsites.net")
        };

        public HttpClient LetterAndFeedbackClient { get; init; } = new()
        {
            BaseAddress = new Uri("https://futuremebackenddatabase.azurewebsites.net")
        };

        public FutureMeClient()
        {
            UserClient.DefaultRequestHeaders.Add("ApiKey", "Jeg5dSHhmNd6GueSDbe754PPDUFn9SUbwhz4Zwjgplhcute");
        }
    }
}
