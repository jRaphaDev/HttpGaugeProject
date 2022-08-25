using System;
using Gauge.CSharp.Lib.Attribute;
using RestSharp;
using FluentAssertions;
using Newtonsoft.Json;

namespace HttpGaugeProject
{
	public class HealthCheckStepImplementation {


		private RestResponse _restResponse;
	
		[Step("Should get the url <basePath>.")]
		public void ShouldGetTheUrl(string basePath)
		{
			var client = new RestClient(basePath);
			var request = new RestRequest("/health-check", Method.Get);
           
			_restResponse = client.Get(request);

		}
	
		[Step("The return must be <response>.")]
		public void TheReturnMustBe(string response)
		{

			_restResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);

			var _healthCheck = JsonConvert.DeserializeObject<HealthCheck>(_restResponse.Content);

			_healthCheck.status.Should().Be(response);

		}
	}
}
