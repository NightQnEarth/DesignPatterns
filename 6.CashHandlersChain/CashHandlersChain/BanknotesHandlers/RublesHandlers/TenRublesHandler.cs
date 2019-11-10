namespace CashHandlersChain.BanknotesHandlers.RublesHandlers
{
    public class TenRublesHandler : RublesHandler
    {
        public TenRublesHandler(BanknotesHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 10;
    }
}