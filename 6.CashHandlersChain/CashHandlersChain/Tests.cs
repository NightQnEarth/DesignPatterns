using System;
using FluentAssertions;
using NUnit.Framework;

namespace CashHandlersChain
{
    [TestFixture]
    class Tests
    {
        private readonly CashDispenser cashDispenser = new CashDispenser();

        [Test]
        public void Validate_ReturnsTrue([Values(10, 50, 100)] int nominal,
                                         [Values("$", "₽", "€")] string currency) =>
            cashDispenser.Validate($"{nominal}{currency}").Should().BeTrue();

        [TestCase("666$", TestName = "OnWrongNominal")]
        [TestCase("100#", TestName = "OnWrongCurrency")]
        public void Validate_ReturnsFalse(string banknote) => cashDispenser.Validate(banknote).Should().BeFalse();

        [Test]
        public void GetCash_ReturnsCash()
        {
            cashDispenser.GetCash("350$").Should().Equal(new Banknote(CurrencyType.Dollar, 100),
                                                         new Banknote(CurrencyType.Dollar, 100),
                                                         new Banknote(CurrencyType.Dollar, 100),
                                                         new Banknote(CurrencyType.Dollar, 50));

            cashDispenser.GetCash("40₽").Should().HaveCount(4).And.OnlyContain(
                banknote => banknote.Currency == CurrencyType.Ruble && banknote.Value == 10);

            cashDispenser.GetCash("160€").Should().OnlyContain(banknote => banknote.Currency == CurrencyType.Euro).And
                         .OnlyHaveUniqueItems();
        }

        [Test]
        public void GetCash_OnIncorrectSum_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => cashDispenser.GetCash("11$"));
            Assert.Throws<ArgumentException>(() => cashDispenser.GetCash("1005₽"));
            Assert.Throws<ArgumentException>(() => cashDispenser.GetCash("0€"));
        }

        [Test]
        public void GetCash_OnInvalidFormat_ThrowFormatException()
        {
            Assert.Throws<FormatException>(() => cashDispenser.GetCash("100#"));
            Assert.Throws<FormatException>(() => cashDispenser.GetCash("23q$"));
            Assert.Throws<FormatException>(() => cashDispenser.GetCash("Hello, world!"));
        }
    }
}