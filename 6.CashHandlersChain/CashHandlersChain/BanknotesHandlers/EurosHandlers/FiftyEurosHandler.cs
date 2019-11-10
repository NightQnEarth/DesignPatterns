namespace CashHandlersChain.BanknotesHandlers.EurosHandlers
{
    public class FiftyEurosHandler : EurosHandler
    {
        public FiftyEurosHandler(BanknotesHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 50;
    }
}