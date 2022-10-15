using BaseGovPtNet.Entities;
using System.Net.Http.Json;
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
            { typeof(ContractSummary), "contratos" },
            { typeof(Contract), "contratos" },
        };

        public Client()
        {
        }
        public void Dispose()
        {
            _client.Dispose();
        }

        public async Task<T?> GetByIdAsync<T>(int id, CancellationToken cancellationToken = default)
        {
            var url = $"{Url}/{_TypeSubUrlMap[typeof(T)]}/{id}";
            return await _client.GetFromJsonAsync<T>(url, cancellationToken);
        }

        public async Task<IEnumerable<T>?> ListAsync<T>(int pageNumber, int pageSize = 10, bool ascending = true, CancellationToken cancellationToken = default)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("range", $"items={(pageNumber - 1) * pageSize}-{pageNumber * pageSize - 1}");
            var url = $"{Url}/{_TypeSubUrlMap[typeof(T)]}?sort({(ascending ? "+" : "-")}id)";
            return await _client.GetFromJsonAsync<IEnumerable<T>>(url, cancellationToken);
        }

    }
}