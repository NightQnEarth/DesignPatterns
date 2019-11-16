using System;

namespace CopierStates.States
{
    public class ChoosingDocument : CopierState
    {
        public ChoosingDocument(Copier copier) : base(copier) { }

        protected override string WrongOperationMessage =>
            $"Wrong operation. Please, make a choice.{Environment.NewLine}";

        public override void ChooseDocument()
        {
            Copier.ResponseWriter($"Document chosen successfully.{Environment.NewLine}");
            Copier.CopierState = new PrintingDocument(Copier);
        }

        public override void ReturnChange()
        {
            Copier.CopierState = new WaitingForChange(Copier);
            Copier.ReturnChange();
        }
    }
}