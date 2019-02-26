using System;

namespace Setup.Data
{
    [Serializable]
    public struct AirportInfoCenterRequest
    {
        public string FlightNumber { get; set; }

        public AirportInfoCenterRequest(string flightNumber)
        {
            FlightNumber = flightNumber;
        }
    }
}