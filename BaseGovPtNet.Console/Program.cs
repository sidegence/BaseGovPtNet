using BaseGovPtNet;
using BaseGovPtNet.Entities;
using System.Text.Encodings.Web;
using System.Text.Json;

var Client = new Client();

Console.WriteLine("await Client.ListAsync<ContractSummary>(1, 3, false)");
Console.WriteLine("===========================================================================================");
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.ListAsync<ContractSummary>(1, 3, false),
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);

Console.WriteLine("await Client.GetByIdAsync<Contract>(9180146)");
Console.WriteLine("===========================================================================================");
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.GetByIdAsync<Contract>(9180146),
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);

Console.WriteLine("await Client.ListAsync<Entity>(1, 3)");
Console.WriteLine("===========================================================================================");
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.ListAsync<Entity>(1, 3),
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);

Console.WriteLine("await Client.GetById<Asset>(6343702)");
Console.WriteLine("===========================================================================================");
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.GetByIdAsync<Asset>(6343702),
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);
