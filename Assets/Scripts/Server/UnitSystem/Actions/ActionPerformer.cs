using System.Collections.Generic;
using System.Linq;
using Server.Utils;

namespace Server
{
    public class ActionPerformer
    {
        private readonly List<IAction> _actions;

        public ActionPerformer(List<IAction> actions)
        {
            _actions = actions;
        }

        public void Perform()
        {
            _actions.ElementAt(Randomizer.GetRandomNumber(_actions.Count)).Initiate();
        }
    }
}