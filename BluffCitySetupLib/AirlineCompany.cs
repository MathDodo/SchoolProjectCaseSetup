using Data;
using Setup.Data;
using System.Collections.Generic;

namespace Setup
{
    public abstract class AirlineCompany : MessageQueueAccessor
    {
        protected List<AirlineCompanyData> _flightsInformation;

        public string CompanyName { get; private set; }

        public AirlineCompany(string name)
        {
            CompanyName = name;
            _flightsInformation = new List<AirlineCompanyData>();
        }

        public void AddFlight(AirlineCompanyData flightData)
        {
            _flightsInformation.Add(flightData);
        }
    }
}