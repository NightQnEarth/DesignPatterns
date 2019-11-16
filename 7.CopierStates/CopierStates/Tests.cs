using System;
using System.IO;
using FluentAssertions;
using NUnit.Framework;

namespace CopierStates
{
    [TestFixture]
    public class Tests
    {
        private Copier copier;
        private StringWriter writer;

        [SetUp]
        public void SetUp()
        {
            writer = new StringWriter();
            copier = new Copier(writer.Write);
        }

        [Test]
        public void CopierBehaviorDemonstration()
        {
            var expectedCopierOutput = string.Join(Environment.NewLine,
                                                   "Payment successfully processed.",
                                                   "Device chosen successfully.",
                                                   "Wrong operation. Please, make a choice.",
                                                   "Document chosen successfully.",
                                                   "Wrong operation. Please, wait for a while copier is printing.",
                                                   "Document printed successfully.",
                                                   "Change returned successfully.",
                                                   $"Payment successfully processed.{Environment.NewLine}");
            copier.MakePayment();    // Goes to ChoosingDevice state.
            copier.ChooseDevice();   // Goes to ChoosingDocument state.
            copier.MakePayment();    // Wrong operation message throws.
            copier.ChooseDocument(); // Goes to PrintDocument state.
            copier.ChooseDevice();   // Wrong operation message throws.
            copier.PrintDocument();  // Goes to ChoosingDocument state.
            copier.ReturnChange();   // Goes to WaitingForChange state, returns change and immediately goes to WaitingForPayment state.
            copier.MakePayment();    // Goes back to WaitingForPayment state.

            writer.ToString().Should().Be(expectedCopierOutput);
        }
    }
}