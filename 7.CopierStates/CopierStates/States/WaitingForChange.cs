using System;

namespace CopierStates.States
{
    public class WaitingForChange : CopierState
    {
        public WaitingForChange(Copier copier) : base(copier) { }

        protected override string WrongOperationMessage =>
            $"Wrong operation. Please, wait for a while copier is returning change.{Environment.NewLine}";

        public override void ReturnChange()
        {
            Copier.ResponseWriter($"Change returned successfully.{Environment.NewLine}");
            Copier.CopierState = new WaitingForPayment(Copier);
        }
    }
}