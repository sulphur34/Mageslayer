using System;

namespace Server.GameSystem
{
    public interface ITurnInformer
    {
        event Action TurnOver;
    }
}