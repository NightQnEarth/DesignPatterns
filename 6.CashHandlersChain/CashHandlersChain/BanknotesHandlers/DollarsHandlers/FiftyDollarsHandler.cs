namespace CashHandlersChain.BanknotesHandlers.DollarsHandlers
{
    public class FiftyDollarsHandler : DollarsHandler
    {
        protected override int Value => 50;

        public FiftyDollarsHandler(BanknotesHandler nextHandler) : base(nextHandler) { }
    }
}