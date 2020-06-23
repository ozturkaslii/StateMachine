using StateMachine.ProductStates.Abstract;
using StateMachine.ProductStates.Concrete;
using StateMachine.SiteStates.Context;

namespace StateMachine.ProductStates.Context
{
    public class ProductStateContext
    {
        public IProductState CurrentState;

        /// <summary>
        /// Default product state is set to Passive
        /// </summary>
        public ProductStateContext()
        {
            CurrentState = new PassiveState(this);    
        }

        public ProductStateContext(SiteStateContext siteStatus)
        {
            CurrentState = new PassiveState(this, siteStatus);
        }
        public void SoldOut()
        {
            CurrentState.SoldOut();
        }

        /// <summary>
        /// Product can be in Active State if Site State is in Approved State.
        /// </summary>
        public void Approve()
        {
            CurrentState.Approve();
        }
    }
}