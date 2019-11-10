namespace CashHandlersChain.BanknotesHandlers.EurosHandlers
{
    public class TenEurosHandler : EurosHandler
    {
        public TenEurosHandler(BanknotesHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 10;
    }
}