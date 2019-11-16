using System;
using CopierStates.States;

namespace CopierStates
{
    public class Copier
    {
        public Copier(Action<string> responseWriter)
        {
            ResponseWriter = responseWriter;
            CopierState = new WaitingForPayment(this);
        }

        internal CopierState CopierState { private get; set; }
        internal Action<string> ResponseWriter { get; }

        public void MakePayment() => CopierState.MakePayment();

        public void ChooseDevice() => CopierState.ChooseDevice();

        public void ChooseDocument() => CopierState.ChooseDocument();

        public void PrintDocument() => CopierState.PrintDocument();

        public void ReturnChange() => CopierState.ReturnChange();
    }
}