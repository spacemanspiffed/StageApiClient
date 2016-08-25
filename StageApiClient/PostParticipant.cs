using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StageApiClient
{
	public class PostParticipant
	{
		public string[] MonitoringType { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string IdNumber { get; set; }
		public string DateOfBirth { get; set; }
		public ParticipantHeight Height { get; set; }
		public ParticipantWeight Weight { get; set; }
		public string Gender { get; set; }
		public string CaseNumber { get; set; }
		public string FileNumber { get; set; }
		public string ExpectedStartDate { get; set; }
		public string ExpectedEndDate { get; set; }
		public string TimeZone { get; set; }
		public string CourtId { get; set; }
		public string JudgeId { get; set; }
		public string Offense { get; set; }
		public string Occupation { get; set; }
		public string ParticipantType { get; set; }
		public string Ethnicity { get; set; }
	}

	public class ParticipantHeight
	{
		public int? Feet { get; set; }
		public int? Inches { get; set; }
		public int? Centimeters { get; set; }
	}

	public class ParticipantWeight
	{
		public int? Pounds { get; set; }
		public int? Kilograms { get; set; }
	}

}
