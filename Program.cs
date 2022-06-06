using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace GraphQL.Client.Example
{
    public class Program
    {
        public static async Task Main()
        {
            using var graphQLClient = new GraphQLHttpClient("YOUR_URL", new NewtonsoftJsonSerializer());
            graphQLClient.HttpClient.DefaultRequestHeaders.Add("Authorization", $"Basic YOUR_KEY");
            
            var domainRequest = new GraphQLRequest
            {
                Query = @"
                query domainquery {
                    domain {
                        name id
                    }
                }"
                // Query = @"
			    // query PersonAndFilms($id: ID) {
			    //     person(id: $id) {
			    //         name
			    //         filmConnection {
			    //             films {
			    //                 title
			    //             }
			    //         }
			    //     }
			    // }",
                // OperationName = "PersonAndFilms",
                // Variables = new
                // {
                //     id = "cGVvcGxlOjE="
                // }
            };

            var graphQLResponse = await graphQLClient.SendQueryAsync<DomainResponse>(domainRequest);
            Console.WriteLine("raw response:");
            Console.WriteLine(JsonSerializer.Serialize(graphQLResponse, new JsonSerializerOptions { WriteIndented = true }));

            Console.WriteLine();
            Console.WriteLine($"Name: {graphQLResponse.Data.Domain.Name}");
            var id = string.Join(", ", graphQLResponse.Data.Domain.ID);
            Console.WriteLine($"ID: {id}");
        }
    }
}
