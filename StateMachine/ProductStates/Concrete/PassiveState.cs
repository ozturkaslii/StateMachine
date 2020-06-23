using System;
using StateMachine.Enums;
using StateMachine.ProductStates.Abstract;
using StateMachine.ProductStates.Context;
using StateMachine.SiteStates.Concrete;
using StateMachine.SiteStates.Context;

namespace StateMachine.ProductStates.Concrete
{
    public class PassiveState: IProductState
    {
        private ProductStateContext _productStateContext;
        private SiteStateContext _siteStatusContext;

        public PassiveState(ProductStateContext productStateContext, SiteStateContext siteStatusContext = null)
        {
            _productStateContext = productStateContext;
            _siteStatusContext = siteStatusContext;
        }

        public void SoldOut()
        {
            throw new InvalidOperationException("Passive product can't be sold out.");
        }


        /*
         * Normally, state machines should be independent so that it can be manageable and maintainable.
         * However, sometimes, your business requirements dictate that different states should depend on each other.
         */

        public void Approve()
        {
            var currentSiteStatus = _siteStatusContext?.CurrentState;
            if (currentSiteStatus is ApprovedState)
            {
                _productStateContext.CurrentState = new ActiveState(_productStateContext);
                Console.WriteLine("Product State - " + Enum.GetName(ProductState.Active.GetType(), ProductState.Active));
            }
            else
            {
                Console.WriteLine("Product can't be in Active State until Site State is in Approved State.");
            }
        }
    }
}