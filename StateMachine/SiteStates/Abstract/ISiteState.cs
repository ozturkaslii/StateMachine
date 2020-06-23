namespace StateMachine.SiteStates.Abstract
{
    public interface ISiteState
    {
        void Reject();
        void SoldOut();
        void Approve();
    }
}