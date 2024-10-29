namespace Server
{
    public interface IActionPerformer
    {
        void Perform(ActionTypes actionType);
    }
}