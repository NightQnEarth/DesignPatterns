using System.Collections.Generic;
using CashHandlersChain.BanknotesHandlers;
using CashHandlersChain.BanknotesHandlers.DollarsHandlers;
using CashHandlersChain.BanknotesHandlers.EurosHandlers;
using CashHandlersChain.BanknotesHandlers.RublesHandlers;

namespace CashHandlersChain
{
    public class CashDispenser
    {
        private readonly BanknotesHandler handler;

        public CashDispenser()
        {
            handler = new TenRublesHandler(null);
            handler = new FiftyRublesHandler(handler);
            handler = new HundredRublesHandler(handler);
            handler = new TenEurosHandler(handler);
            handler = new FiftyEurosHandler(handler);
            handler = new HundredEurosHandler(handler);
            handler = new TenDollarsHandler(handler);
            handler = new FiftyDollarsHandler(handler);
            handler = new HundredDollarsHandler(handler);
        }

        public bool Validate(string banknote) => handler.Validate(banknote);
        public IEnumerable<IBanknote> GetCash(string sumToCashOut) => handler.GetCash(sumToCashOut);
    }
}