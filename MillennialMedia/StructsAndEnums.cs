using System;

namespace MillennialMedia
{
	public enum  MMEducation  {
		Unknown = 0,
		None = 1,
		HighSchool = 2,
		SomeCollege = 3,
		Bachelors = 4,
		Masters = 5,
		Doctorate = 6
	}

	public enum MMGender {
		Unknown = 0,
		Male = 1,
		Female = 2
	}

	public enum MMEthnicity {
		Unknown = 0,
		MiddleEastern = 1,
		Asian = 2,
		Black = 3,
		Hispanic = 4,
		Indian = 5,
		NativeAmerican = 6,
		PacificIslander = 7,
		White = 8,
		Other = 9
	}

	public enum  MMMaritalStatus {
		Unknown = 0,
		Single = 1,
		Married = 2,
		Divorced = 3,
		Engaged = 4
	}

	public enum  MMSexualOrientation {
		Unknown = 0,
		Gay = 1,
		Straight = 2,
		Bisexual = 3,
		Transgender = 4
	}

	public enum ErrorCode {
		UnknownError = 0,
		ServerError = -500,
		Unavailable = -503,
		Disabled = -9999999
	}

	public enum MMLogLevel {
		Off = 0,
		Info = 1,
		Debug = 2,
		Error = 4,
		Fatal = 8
	}
}

