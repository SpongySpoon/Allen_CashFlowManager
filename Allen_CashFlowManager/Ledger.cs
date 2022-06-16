namespace Allen_CashFlowManager
{
    internal class Ledger
    {
        private decimal _hourlyPayable = 0, _invoiceTotal = 0, _salaryTotal = 0 ;
       
        public enum LedgerType
        {
            Hourly,
            Salaried,
            Invoice

        }

        public decimal sethourlyTotal(decimal hourlyPayable)
        {
            _hourlyPayable += hourlyPayable;
            return _hourlyPayable;
        }

        public decimal gethourlyTotal
        {
            get { return _hourlyPayable; }
        }

        public decimal setInvoiceTotal(decimal invoiceTotal)
        {
            _invoiceTotal += invoiceTotal;
            return _invoiceTotal;
        }
        public decimal getinvoiceTotal
        {
            get { return _invoiceTotal; }
        }

        public decimal setSalaryTotal(decimal salaryTotal)
        {
            _salaryTotal += salaryTotal;
            return _salaryTotal;
        }

        public decimal getSalaryTotal
        {
            get { return _salaryTotal; }
        }

        public decimal getTotalamount
        {
            get { return _hourlyPayable + _invoiceTotal + _salaryTotal;
    }
        }

    }
}
