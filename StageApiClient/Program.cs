using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace StageApiClient
{
	class Program
	{
		static void Main(string[] args)
		{
			CallApi();
		}

		private static async void CallApi()
		{
			var uriString = "https://api.scramstage.com/v1.0/agent/4a132d85-ca8a-4b68-bc8e-5925e05c48e7/participant";
			Uri stageUri = new System.Uri(uriString);
			var height = new ParticipantHeight
			{
				Feet = 6,
				Inches = 1
			};
			var weight = new ParticipantWeight
			{
				Pounds = 111
			};

			var participant = new PostParticipant
			{
				CaseNumber = "123321",
				CourtId = "1a32d0f9-f532-4faf-97a5-7fba8374ac58",
				DateOfBirth = "06/28/1982",
				Ethnicity = "Caucasian",
				ExpectedStartDate = DateTime.Now.Date.ToString(),
				ExpectedEndDate = DateTime.Now.Date.AddDays(40).ToString(),
				FileNumber = "654654",
				FirstName = "CODE1",
				MiddleName = "API",
				LastName = "TEST",
				Gender = "Male",
				Weight = weight,
				Height = height,
				IdNumber = "1234564565",
				JudgeId = "07a842a0-dbec-48a5-9886-382d63a7ec84",
				MonitoringType = new string[] { "CAM" },
				Occupation = "Worker",
				Offense = "DUI",
				ParticipantType = "Parole",
				TimeZone = "Mountain Standard Time"
			};

			using (var client = new HttpClient())
			{
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("AMS_Token", "keyForApiTestProvider");
				var response = client.PostAsJsonAsync(uriString, participant).Result;

				if (response.IsSuccessStatusCode)
				{
					Console.WriteLine("Success" + response.Headers.Location);
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine("fail");
					Console.ReadLine();
				}

			}
		}
	}
}
