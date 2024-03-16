using System;

namespace Assets.Scripts.Model.Unit
{
    public interface IMover 
    {
        event Action Moving;
        event Action Carrying;
    }
}
