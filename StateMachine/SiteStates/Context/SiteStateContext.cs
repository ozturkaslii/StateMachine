using StateMachine.SiteStates.Abstract;
using StateMachine.SiteStates.Concrete;

namespace StateMachine.SiteStates.Context
{
    public class SiteStateContext
    {
        public ISiteState CurrentState;

        /// <summary>
        /// Default site state is set to Draft
        /// </summary>
        public SiteStateContext()
        {
            CurrentState = new DraftState(this);
        }

        public SiteStateContext(ISiteState currentState)
        {
            CurrentState = currentState;
        }

        public void Reject()
        {
            CurrentState.Reject();
        }

        public void SoldOut()
        {
            CurrentState.SoldOut();
        }

        public void Approve()
        {
            CurrentState.Approve();
        }
    }
}