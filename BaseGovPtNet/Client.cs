using BaseGovPtNet.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;

namespace BaseGovPtNet
{
    public class Client : IDisposable
    {
        const string Url = @"http://www.base.gov.pt/base2/rest";
        static readonly HttpClient _client = new HttpClient();
        static readonly Dictionary<Type, string> _TypeSubUrlMap = new Dictionary<Type, string>()
        {
            { typeof(Asset), "bensmoveis" },
            { typeof(Entity), "entidades" },
            { typeof(Contract), "contratos" },
            { typeof(ContractSummary), "contratos" },
        };

        public Client()
        {
        }
        public void Dispose()
        {
            _client.Dispose();
        }

        public async Task<T?> GetByIdAsync<T>(
            int id, 
            CancellationToken cancellationToken = default
        )
        {
            var url = $"{Url}/{_TypeSubUrlMap[typeof(T)]}/{id}";
            var rsp = await _client.GetStringAsync(url, cancellationToken);

            return JsonConvert.DeserializeObject<T>(rsp);
        }

        public async Task<IEnumerable<TOut>?> ListAsync<TOut, TFilter>(
            int pageNumber, 
            IEnumerable<KeyValuePair<TFilter,string>> filter, 
            int pageSize = 10, 
            CancellationToken cancellationToken = default
        ) 
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("range", $"items={(pageNumber - 1) * pageSize}-{pageNumber * pageSize - 1}");

            var url = $"{Url}/{_TypeSubUrlMap[typeof(TOut)]}?{(filter.Any() ? string.Join("&", filter.Select(_=>_.Key + "=" + _.Value)):"")}&sort(-id)";
            var rsp = await _client.GetStringAsync(url, cancellationToken);

            return JsonConvert.DeserializeObject<IEnumerable<TOut>>(rsp);
        }
    }
}