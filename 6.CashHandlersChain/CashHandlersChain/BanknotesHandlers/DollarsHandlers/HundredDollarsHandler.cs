namespace CashHandlersChain.BanknotesHandlers.DollarsHandlers
{
    public class HundredDollarsHandler : DollarsHandler
    {
        protected override int Value => 100;

        public HundredDollarsHandler(BanknotesHandler nextHandler) : base(nextHandler) { }
    }
}