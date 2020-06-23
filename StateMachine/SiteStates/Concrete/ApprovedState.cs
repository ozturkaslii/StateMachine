using System;
using StateMachine.Enums;
using StateMachine.SiteStates.Abstract;
using StateMachine.SiteStates.Context;

namespace StateMachine.SiteStates.Concrete
{
    public class ApprovedState : ISiteState
    {
        private readonly SiteStateContext _siteStatusContext;

        public ApprovedState(SiteStateContext siteStatusContext)
        {
            _siteStatusContext = siteStatusContext;
        }

        public void Reject()
        {
            Console.WriteLine("Site State - " + Enum.GetName(SiteState.Archived.GetType(), SiteState.Archived));
            _siteStatusContext.CurrentState = new ArchivedState(_siteStatusContext);
        }

        public void SoldOut()
        {
            Console.WriteLine("Site State - " + Enum.GetName(SiteState.Archived.GetType(), SiteState.Archived));
            _siteStatusContext.CurrentState = new ArchivedState(_siteStatusContext);
        }

        public void Approve()
        {
            throw new InvalidOperationException("This product has already been approved.");
        }
    }
}