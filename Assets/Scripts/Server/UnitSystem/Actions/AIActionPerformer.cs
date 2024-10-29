using System;
using Server.Utils;

namespace Server
{
    public class AIActionPerformer : ActionPerformer
    {
        public ActionTypes GetAction()
        {
            var values = (ActionTypes[])Enum.GetValues(typeof(ActionTypes));
            return values[Randomizer.GetRandomNumber(values.Length)];
        }
    }
}