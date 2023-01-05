﻿using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LightSpeed.Api.Client.Configuration
{
    public class ApiClientBase
    {
        private readonly IRestApiConfiguration _config;
        public string BaseUrl => _config.BaseUrl;
        public ApiClientBase(IRestApiConfiguration config)
        {
            _config = config;
        }
        public async Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
        {
            return await _config.CreateHttpRequestMessageAsync(cancellationToken);
        }
    }
}