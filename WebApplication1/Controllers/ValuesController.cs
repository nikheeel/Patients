using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using RestSharp;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            MakeRestCall();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


        public void MakeRestCall()
        {
            var client = new RestClient("http://localhost:63669/");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var serviceRequest = new Person()
            {
                Name = "ABC"
            };

            var request = new RestRequest("api/values/serviceget", Method.POST);
            request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(serviceRequest),
                ParameterType.RequestBody);
            //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

            // easily add HTTP Headers
            request.AddHeader("header", "value");

            // add files to upload (works with compatible verbs)
           // request.AddFile(path);

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            // or automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            //RestResponse<Person> response2 = client.Execute<Person>(request);
            //var name = response2.Data.Name;

            //// easy async support
            //client.ExecuteAsync(request, response2 => {
            //    Console.WriteLine(response2.Content);
            //});

            //// async with deserialization
            //var asyncHandle = client.ExecuteAsync<Person>(request, response1 => {
            //    Console.WriteLine(response1.Data.Name);
            //});

            //// abort the request on demand
            //asyncHandle.Abort();
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
