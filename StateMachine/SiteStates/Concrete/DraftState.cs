using System;
using StateMachine.Enums;
using StateMachine.SiteStates.Abstract;
using StateMachine.SiteStates.Context;

namespace StateMachine.SiteStates.Concrete
{
    public class DraftState : ISiteState
    {
        private SiteStateContext _siteStatusContext;

        public DraftState(SiteStateContext siteStatusContext)
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
            Console.WriteLine("Site State - " + Enum.GetName(SiteState.Approved.GetType(), SiteState.Approved));
            _siteStatusContext.CurrentState = new ApprovedState(_siteStatusContext);
        }
    }
}