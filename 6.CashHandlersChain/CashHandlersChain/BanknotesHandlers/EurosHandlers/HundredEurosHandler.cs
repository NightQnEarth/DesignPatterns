namespace CashHandlersChain.BanknotesHandlers.EurosHandlers
{
    public class HundredEurosHandler : EurosHandler
    {
        public HundredEurosHandler(BanknotesHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 100;
    }
}