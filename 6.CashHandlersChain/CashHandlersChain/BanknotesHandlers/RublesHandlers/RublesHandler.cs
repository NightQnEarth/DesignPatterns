using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CashHandlersChain.BanknotesHandlers.RublesHandlers
{
    public abstract class RublesHandler : BanknotesHandler
    {
        protected RublesHandler(BanknotesHandler nextHandler) : base(nextHandler) { }

        protected override Regex MoneyParser => new Regex(@"(?<Count>\d+)₽");

        public override bool Validate(string banknote) => banknote == $"{Value}₽" || base.Validate(banknote);

        protected override IEnumerable<IBanknote> GetCash(int sumToCashOut)
        {
            var countOfCurrentBanknotes = sumToCashOut / Value;

            return Enumerable.Repeat((IBanknote)new Banknote(CurrencyType.Ruble, Value), countOfCurrentBanknotes)
                             .Concat(base.GetCash(sumToCashOut - countOfCurrentBanknotes * Value));
        }
    }
}