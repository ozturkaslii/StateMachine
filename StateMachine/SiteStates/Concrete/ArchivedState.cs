using System;
using StateMachine.SiteStates.Abstract;
using StateMachine.SiteStates.Context;

namespace StateMachine.SiteStates.Concrete
{
    public class ArchivedState : ISiteState
    {
        private SiteStateContext _siteStatusContext;

        public ArchivedState(SiteStateContext siteStatusContext)
        {
            _siteStatusContext = siteStatusContext;
        }

        public void Reject()
        {
            throw new InvalidOperationException("Archived product can't be rejected.");
        }

        public void SoldOut()
        {
            throw new InvalidOperationException("Archived product can't be sold.");
        }

        public void Approve()
        {
            throw new InvalidOperationException("Archived product can't be approved.");
        }
    }
}