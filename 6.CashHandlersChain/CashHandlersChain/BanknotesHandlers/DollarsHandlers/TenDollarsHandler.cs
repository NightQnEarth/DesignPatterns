namespace CashHandlersChain.BanknotesHandlers.DollarsHandlers
{
    public class TenDollarsHandler : DollarsHandler
    {
        protected override int Value => 10;

        public TenDollarsHandler(BanknotesHandler nextHandler) : base(nextHandler) { }
    }
}