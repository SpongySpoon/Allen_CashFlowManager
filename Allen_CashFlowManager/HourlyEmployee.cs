namespace Allen_CashFlowManager
{
    class HourlyEmployee : Employees
    {
        private decimal _earnings, _hourlyPay, _overtimePay, _totalovertimePay, _allowance;
        private int _hoursWorked, _overtime;


        public HourlyEmployee(string FirstName, string LastName, string SSN, decimal hourlyPay, int hoursWorked) : base(FirstName, LastName, SSN)
        {
            _hourlyPay = hourlyPay;
            _hoursWorked = hoursWorked;



            if (_hoursWorked >= 40)
            {
                _earnings = _hourlyPay * _hoursWorked;
            }
            else if (_hoursWorked < 40)
            {
                _hoursWorked = 40;
                _overtime = hoursWorked - 40;
                _overtimePay = _hourlyPay * 1.5m;
                _totalovertimePay = _overtime * _overtimePay;
                _allowance = _hourlyPay * _hoursWorked;
                _earnings = _totalovertimePay + _allowance;
            }



            base.setEarnings(_earnings);
            base.setLedgerType(Ledger.LedgerType.Hourly);
        }
        public override string ToString()
        {
            return "Hourly employee: " +
                    "\n Name: " + getFirstname + " " + getLastname +
                    "\n SSN: " + getSSN +
                    "\n Hourly pay: "+ _hourlyPay +
                    "\n Hours worked: " + _hoursWorked +
                    "\n Weekly pay: " + _earnings;

        }



    }
}
