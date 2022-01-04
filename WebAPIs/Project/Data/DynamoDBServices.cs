using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.DataModel;
using Project.Models;

namespace Project.Data
{
    public class DynamoDBServices
    {
        IAmazonDynamoDB dynamoDBClient { get; set; }

        public DynamoDBServices(IAmazonDynamoDB dynamoDBClient)
        {
            this.dynamoDBClient = dynamoDBClient;
        }

        // Get the list of plants from AWS DynamoDB
        public async Task<List<Plant>> GetPlantsAsync()
        {
            ScanFilter scanFilter = new ScanFilter();
            scanFilter.AddCondition("Id", ScanOperator.NotEqual, 0);

            ScanOperationConfig soc = new ScanOperationConfig()
            {
                Filter = scanFilter
            };
            DynamoDBContext context = new DynamoDBContext(dynamoDBClient);
            AsyncSearch<Plant> search = context.FromScanAsync<Plant>(soc, null);
            List<Plant> documentList = new List<Plant>();
            do
            {
                documentList = await search.GetNextSetAsync(default(System.Threading.CancellationToken));
            } while (!search.IsDone);

            return documentList;
        }

        // Update Last time the plant was watered
        public async Task<Plant> UpdatePlantStatus(string id)
        {
            DynamoDBContext context = new DynamoDBContext(dynamoDBClient);
            Plant plant = await context.LoadAsync<Plant>(id, default(System.Threading.CancellationToken));
            plant.Status = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss:tt");
            await context.SaveAsync(plant, default(System.Threading.CancellationToken));
            return plant;
        }
       
    }
}
