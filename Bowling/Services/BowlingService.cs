using Bowling.BL;
using Bowling.Models;
using System;
using System.Collections.Generic;

namespace Bowling.Services
{
    internal class BowlingService : ICellService, IUiControlService
    {
        private readonly Logic logic = new Logic();
        public Action DisableRoll { get; set; }
        public void AddCell(Cell cell) => logic.AddCell(cell);
        public void InvokeRollAction()
        {
            if (logic.IsHaveBonusRoll)
                BonusRoll();
            else if (logic.IsFirstCell)
                logic.FirstRoll();
            else if (logic.IsSecondCell)
                logic.SecondRoll();

            if (logic.IsTheLastCell && !logic.IsHaveBonusRoll)
                DisableRoll?.Invoke();
        }
        private void BonusRoll()
        {
            logic.BonusRoll();
            DisableRoll?.Invoke();
        }
    }
}