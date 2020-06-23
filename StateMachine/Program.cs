using StateMachine.ProductStates.Context;
using StateMachine.SiteStates.Context;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var siteStateContext = new SiteStateContext(); //set to Draft State
            siteStateContext.Approve(); //from Draft to Approved State
            //context.SoldOut(); 

            var productStatuscontext = new ProductStateContext(siteStateContext); //set to Passive State
            productStatuscontext.Approve(); //from Passive to Active State

            //Sold the product
            siteStateContext.SoldOut();
            productStatuscontext.SoldOut();
        }
    }
}
