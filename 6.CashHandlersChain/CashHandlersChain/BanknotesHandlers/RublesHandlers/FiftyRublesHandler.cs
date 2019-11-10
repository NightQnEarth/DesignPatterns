namespace CashHandlersChain.BanknotesHandlers.RublesHandlers
{
    public class FiftyRublesHandler : RublesHandler
    {
        public FiftyRublesHandler(BanknotesHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 50;
    }
}