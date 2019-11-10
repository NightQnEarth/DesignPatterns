namespace CashHandlersChain.BanknotesHandlers.RublesHandlers
{
    public class HundredRublesHandler : RublesHandler
    {
        public HundredRublesHandler(BanknotesHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 100;
    }
}