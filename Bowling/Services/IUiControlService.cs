using System;

namespace Bowling.Services
{
    internal interface IUiControlService
    {
        Action DisableRoll { get; set; }
        void InvokeRollAction();
    }
}