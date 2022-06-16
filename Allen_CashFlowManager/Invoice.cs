namespace Allen_CashFlowManager
{
    class Invoice : IPayable
    {
        private string _PartsNumber, _PartsDescription;
        private int _Quantity, _Invoice1, _Invoice2;
        private decimal _Price, _calculatedPrice;


        public Invoice(string PartsNumber, string PartsDescription, int Quantity, decimal Price, int Invoice1, int Invoice2)
        {
            _PartsDescription = PartsDescription;
            _PartsNumber = PartsNumber;
            _Price = Price;
            _Quantity = Quantity;
            _Invoice1 = Invoice1;
            _Invoice2 = Invoice2;
            _calculatedPrice = Price * Quantity;

        }
        public decimal GetPayableAmount
        {
            get { return _calculatedPrice; }
        }

        public Ledger.LedgerType GetLedgerType
        {
            get { return Ledger.LedgerType.Invoice; }
        }

        public override string ToString()
        {
            return "Invoice: " + _Invoice1 + " - " + _Invoice2 +
                    "\n Quantity: " + _Quantity +
                    "\n Parts Number: " + _PartsNumber +
                    "\n Parts Description: " + _PartsDescription +
                    "\n Price: " + _calculatedPrice;

        }
    }
}
