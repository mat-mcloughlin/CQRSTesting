namespace CQRSTesting.Domain
{
	using System;

	public class Journey
	{
		public int Id { get; set; }

		public int VehicleId { get; set; }

		public int DriverId { get; set; }

		public string FromLocation { get; set; }

		public string ToLocation { get; set; }

		public string Reason { get; set; }

		public int StartMileage { get; set; }

		public int EndMileage { get; set; }

		public Journey(int vehicleId, int driverId, string fromLocation, string toLocation, string reason, int startMileage, int endMileage)
		{
			IsMileageValid(startMileage, endMileage);

			this.VehicleId = vehicleId;
			this.DriverId = driverId;
			this.FromLocation = fromLocation;
			this.ToLocation = toLocation;
			this.Reason = reason;
			this.StartMileage = startMileage;
			this.EndMileage = endMileage;
		}

		private static void IsMileageValid(int startMileage, int endMileage)
		{
			if (endMileage < startMileage)
			{
				throw new InvalidOperationException("The vehicles end mileage can not be more than the start mileage");
			}
		}
	}
}
