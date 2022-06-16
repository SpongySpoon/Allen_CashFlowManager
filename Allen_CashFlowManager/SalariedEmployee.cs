namespace Allen_CashFlowManager
{
    class SalariedEmployee : Employees
    {
        private decimal _earnings;

        public SalariedEmployee(string FirstName, string LastName, string SSN, decimal weeklySalary) : base(FirstName, LastName, SSN)
        {
            _earnings = weeklySalary;
            base.setEarnings(_earnings);
            base.setLedgerType(Ledger.LedgerType.Salaried);

        }

        public override string ToString()
        {
            return "Salaried employee " +
                    "\n Name: " + getFirstname + " " + getLastname +
                    "\n SSN: " + getSSN +
                    "\n Weekly pay: " + _earnings;

        }




    }
}
