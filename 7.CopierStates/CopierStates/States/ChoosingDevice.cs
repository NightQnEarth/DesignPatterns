using System;

namespace CopierStates.States
{
    public class ChoosingDevice : CopierState
    {
        public ChoosingDevice(Copier copier) : base(copier) { }

        protected override string WrongOperationMessage =>
            $"Wrong operation. Please, make a choice.{Environment.NewLine}";

        public override void ChooseDevice()
        {
            Copier.ResponseWriter($"Device chosen successfully.{Environment.NewLine}");
            Copier.CopierState = new ChoosingDocument(Copier);
        }
    }
}