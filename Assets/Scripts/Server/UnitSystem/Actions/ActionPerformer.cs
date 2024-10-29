using System;
using System.Collections.Generic;
using System.Linq;
using Server.Utils;

namespace Server
{
    public class ActionPerformer : IActionPerformer
    {
        private readonly Dictionary<ActionTypes,IAction> _actions = new ();

        public void AddAction(ActionTypes actionType, IAction action)
        {
            _actions.Add(actionType, action);
        }

        public void Perform(ActionTypes actionType)
        {
            _actions[actionType].Initiate();
        }
    }
}