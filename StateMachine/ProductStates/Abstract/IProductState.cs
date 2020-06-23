namespace StateMachine.ProductStates.Abstract
{
    public interface IProductState
    {
        void SoldOut();
        void Approve();
    }
}