using BaseGovPtNet;
using BaseGovPtNet.Entities;
using System.Text.Encodings.Web;
using System.Text.Json;

var Client = new Client();

Console.WriteLine("===========================================================================================");
Console.WriteLine("await Client.ListAsync<Contract, ContractFilter>(1, adjucatariaid=\"505931192\" => 21)");
Console.WriteLine("===========================================================================================");
var filter = new Dictionary<ContractFilter, string>() { { ContractFilter.adjudicanteid, "21" } };
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.ListAsync<ContractSummary, ContractFilter>(1, filter, 3),
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);
Console.WriteLine();

Console.WriteLine("===========================================================================================");
Console.WriteLine("await Client.GetByIdAsync<Contract>(9501257)");
Console.WriteLine("===========================================================================================");
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.GetByIdAsync<Contract>(9501257),
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);
Console.WriteLine();

//Console.WriteLine("===========================================================================================");
//Console.WriteLine("await Client.ListAsync<Entity>(1, 5)");
//Console.WriteLine("===========================================================================================");
//Console.WriteLine(
//    JsonSerializer.Serialize(
//        await Client.ListAsync<Entity>(1, 3),
//        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
//    )
//);
Console.WriteLine();

//Console.WriteLine("===========================================================================================");
//Console.WriteLine("await Client.GetById<Asset>(6343702)");
//Console.WriteLine("===========================================================================================");
//Console.WriteLine(
//    JsonSerializer.Serialize(
//        await Client.GetByIdAsync<Asset>(6343702),
//        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
//    )
//);
Console.WriteLine();

//Console.WriteLine("===========================================================================================");
//Console.WriteLine("await Client.ListAsync<Entity, EntityFilter>(1, \"505931192\" )"); 
//Console.WriteLine("===========================================================================================");
//var filter = new Dictionary<EntityFilter, string>() { { EntityFilter.texto, "505931192" } };
//Console.WriteLine(
//    JsonSerializer.Serialize(
//        await Client.ListAsync<Entity, EntityFilter>(1, filter),
//        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
//    )
//);
Console.WriteLine();

Console.WriteLine("Done.");
