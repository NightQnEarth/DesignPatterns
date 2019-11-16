using System;

namespace CopierStates.States
{
    public class WaitingForPayment : CopierState
    {
        public WaitingForPayment(Copier copier) : base(copier) { }

        protected override string WrongOperationMessage =>
            $"Wrong operation. Please, make a payment.{Environment.NewLine}";

        public override void MakePayment()
        {
            Copier.ResponseWriter($"Payment successfully processed.{Environment.NewLine}");
            Copier.CopierState = new ChoosingDevice(Copier);
        }
    }
}