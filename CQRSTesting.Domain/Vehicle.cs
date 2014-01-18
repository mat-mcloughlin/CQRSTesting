namespace CQRSTesting.Domain
{
	using System;
	using System.Collections.Generic;

	public class Vehicle
	{
		public int Id { get; set; }

		public string Registration { get; set; }

		public string Description { get; set; }

		public ICollection<Journey> Journeys { get; set;}

		public Vehicle() { }

		private Vehicle(string registration, string description)
		{
			this.Registration = registration;
			this.Description = description;
		}

		public static Vehicle Create(string registration, string description)
		{
			return new Vehicle(registration, description);
		}

		public void Update(string registration, string description)
		{
			this.IsVehicleCreated();

			this.Registration = registration;
			this.Description = description;
		}

		public void LogNewJournery(int driverId, string fromLocation, string toLocation, string reason, int startMileage, int endMileage)
		{
			Journeys.Add(new Journey(this.Id, driverId, fromLocation, toLocation, reason, startMileage, endMileage));
		}

		private void IsVehicleCreated()
		{
			if (Id == 0)
			{
				throw new InvalidOperationException("The vehicle is not created and can not be updated");   
			}
		}
	}
}
