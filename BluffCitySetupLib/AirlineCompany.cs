using Data;

namespace Setup
{
    public abstract class AirlineCompany : MessageQueueAccessor
    {
        public string CompanyName { get; private set; }

        public AirlineCompany(string name)
        {
            CompanyName = name;
        }
    }
}