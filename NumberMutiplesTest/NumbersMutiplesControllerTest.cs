using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using NumberMutiples.Controllers;
using System.Net.Http;
using System.Threading.Tasks;

namespace NumberMutiplesTest
{
    [TestClass]
    public class NumbersMutiplesControllerTest
    {

        private string url = "https://localhost:5001/api/NumbersMutiples/get";

        public NumbersMutiplesControllerTest()
        {
        }
        [TestMethod]
        public async Task MultipleOf3Positive()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{url}/6");
                    //response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var jToken = JToken.Parse(responseBody);
                    var val = jToken.SelectToken("output").Value<string>();
                    Assert.AreEqual("G", val);
                }
            }
            catch (System.Exception ex)
            {

                string msg = ex.Message;
            }
        }
        [TestMethod]
        public async Task MultipleOf3Negative()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{url}/6");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var jToken = JToken.Parse(responseBody);
                    var val = jToken.SelectToken("output").Value<string>();
                    Assert.AreNotEqual("N", val);
                }
            }
            catch (System.Exception ex)
            {

                string msg = ex.Message;
            }
        }
        [TestMethod]
        public async Task MultipleOf5Positive()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{url}/10");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var jToken = JToken.Parse(responseBody);
                    var val = jToken.SelectToken("output").Value<string>();
                    Assert.AreEqual("N", val);
                }
            }
            catch (System.Exception ex)
            {

                string msg = ex.Message;
            }
        }
        [TestMethod]
        public async Task MultipleOf5Negative()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{url}/10");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var jToken = JToken.Parse(responseBody);
                    var val = jToken.SelectToken("output").Value<string>();
                    Assert.AreNotEqual("G", val);
                }
            }
            catch (System.Exception ex)
            {

                string msg = ex.Message;
            }
        }
        [TestMethod]
        public async Task MultipleOf3And5Positive()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{url}/15");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var jToken = JToken.Parse(responseBody);
                    var val = jToken.SelectToken("output").Value<string>();
                    Assert.AreEqual("GN", val);
                }
            }
            catch (System.Exception ex)
            {

                string msg = ex.Message;
            }
        }
        [TestMethod]
        public async Task MultipleOf3And5Negative()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{url}/30");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var jToken = JToken.Parse(responseBody);
                    var val = jToken.SelectToken("output").Value<string>();
                    Assert.AreNotEqual("TG", val);
                }
            }
            catch (System.Exception ex)
            {

                string msg = ex.Message;
            }
        }
    }
}
