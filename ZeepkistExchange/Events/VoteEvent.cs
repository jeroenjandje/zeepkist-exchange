using System;

namespace ZeepkistExchange.events;

public class VoteEvent
{
    
    public event EventHandler Event;

    protected virtual void OnEvent()
    {
        Event?.Invoke(this, EventArgs.Empty);
    }
}