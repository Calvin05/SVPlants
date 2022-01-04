using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;

namespace Project.Controllers
{
    [Route("api/")]

    public class MainController : ControllerBase
    {
        
        private IAmazonDynamoDB dynamoDBClient;
        public MainController(IAmazonDynamoDB dynamoDBClient)
        {
            
            this.dynamoDBClient = dynamoDBClient;
        }

        // Get: api/plants - Get A list of Plants
        [HttpGet("plants")]
        public async Task<ActionResult<Plant>> GetPlants()
        {
            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            var result = await service.GetPlantsAsync();
            return Ok(result);
        }

        //Post: api/plant/id - Update The Time that Plant got water
        [HttpPost("plant/{id}")]
        public async Task<ActionResult> UpdateStatus(string id)
        {
            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
         
            Plant newPlant = await service.UpdatePlantStatus(id);
            return Ok(newPlant);
        }

    }

}