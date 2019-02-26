using Data;
using Setup.Data;
using System.Collections.Generic;

namespace BluffCitySetupLib
{
    public abstract class AirportInformationCenter : MessageQueueAccessor
    {
        protected List<AirportInformationCenterData> _centerData;

        public AirportInformationCenter()
        {
            _centerData = new List<AirportInformationCenterData>();
        }

        public void AddCenterData(AirportInformationCenterData data)
        {
            _centerData.Add(data);
        }
    }
}