using StateMachine.Enums;
using StateMachine.ProductStates.Abstract;
using StateMachine.ProductStates.Context;
using System;

namespace StateMachine.ProductStates.Concrete
{
    public class ActiveState : IProductState
    {
        private ProductStateContext _productStateContext;

        public ActiveState(ProductStateContext productStateContext)
        {
            _productStateContext = productStateContext;
        }

        public void SoldOut()
        {
            _productStateContext.CurrentState = new PassiveState(_productStateContext);
            Console.WriteLine("Product State - " + Enum.GetName(ProductState.Passive.GetType(), ProductState.Passive));
        }

        public void Approve()
        {
            throw new InvalidOperationException("Active product can't be approved.");
        }
    }
}