namespace CopierStates.States
{
    public abstract class CopierState
    {
        protected CopierState(Copier copier) => Copier = copier;

        protected abstract string WrongOperationMessage { get; }
        protected Copier Copier { get; }

        public virtual void MakePayment() => Copier.ResponseWriter(WrongOperationMessage);
        public virtual void ChooseDevice() => Copier.ResponseWriter(WrongOperationMessage);
        public virtual void ChooseDocument() => Copier.ResponseWriter(WrongOperationMessage);
        public virtual void PrintDocument() => Copier.ResponseWriter(WrongOperationMessage);
        public virtual void ReturnChange() => Copier.ResponseWriter(WrongOperationMessage);
    }
}