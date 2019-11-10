using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CashHandlersChain.BanknotesHandlers.EurosHandlers
{
    public abstract class EurosHandler : BanknotesHandler
    {
        protected EurosHandler(BanknotesHandler nextHandler) : base(nextHandler) { }

        protected override Regex MoneyParser => new Regex(@"(?<Count>\d+)€");

        public override bool Validate(string banknote) => banknote == $"{Value}€" || base.Validate(banknote);

        protected override IEnumerable<IBanknote> GetCash(int sumToCashOut)
        {
            var countOfCurrentBanknotes = sumToCashOut / Value;

            return Enumerable.Repeat((IBanknote)new Banknote(CurrencyType.Euro, Value), countOfCurrentBanknotes)
                             .Concat(base.GetCash(sumToCashOut - countOfCurrentBanknotes * Value));
        }
    }
}