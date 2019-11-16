using System;

namespace CopierStates.States
{
    public class PrintingDocument : CopierState
    {
        public PrintingDocument(Copier copier) : base(copier) { }

        protected override string WrongOperationMessage =>
            $"Wrong operation. Please, wait for a while copier is printing.{Environment.NewLine}";

        public override void PrintDocument()
        {
            Copier.ResponseWriter($"Document printed successfully.{Environment.NewLine}");
            Copier.CopierState = new ChoosingDocument(Copier);
        }
    }
}