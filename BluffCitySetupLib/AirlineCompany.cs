using Data;
using Setup.Data;
using System.Collections.Generic;

namespace Setup
{
    public abstract class AirlineCompany : MessageQueueAccessor
    {
        protected List<AirlineCompanyData> _flightsInformation;

        public string CompanyName { get; private set; }

        public int Count { get { return _flightsInformation.Count; } }

        public AirlineCompanyData this[int index]
        {
            get
            {
                return _flightsInformation[index];
            }
        }

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