namespace Allen_CashFlowManager
{
    class Employees : IPayable
    {

        private string _firstName, _lastName, _SSN;
        private decimal _blob;
        private Ledger.LedgerType _type;


        public decimal GetPayableAmount
        {
            get { return _blob; }
        }

        public Ledger.LedgerType GetLedgerType
        {
            get { return _type; }
        }
        public Ledger.LedgerType setLedgerType(Ledger.LedgerType type)
        {
            return _type = type;
        }


        public Employees(string FirstName, string LastName, string SSN)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _SSN = SSN;
        }



        public string getFirstname
        {
            get { return _firstName; }
        }

        public string getLastname
        {
            get { return _lastName; }
        }

        public string getSSN
        {
            get { return _SSN; }
        }



        public decimal setEarnings(decimal _earnings)
        {
            _blob = _earnings;
            return _blob;
        }
    }
}
