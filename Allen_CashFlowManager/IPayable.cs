namespace Allen_CashFlowManager
{

    interface IPayable
    {
        public decimal GetPayableAmount { get; }

        public Ledger.LedgerType GetLedgerType { get; }


    }






}
