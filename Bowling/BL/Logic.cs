using Bowling.Models;
using System;
using System.Collections.Generic;

namespace Bowling.BL
{
    internal class Logic
    {
        private readonly int maxBowls = 10;
        private int index;
        private int rollNumber;
        private readonly Random rnd = new Random();
        private readonly List<Cell> cells = new List<Cell>();
        private int randomBowls => rnd.Next(0, maxBowls + 1 - rollNumber);
        private bool strikeSpare(int i) => cells[i].FirstRoll + cells[i].SecondRoll >= maxBowls;

        public void AddCell(Cell cell) => cells.Add(cell);
        public bool IsTheLastCell => index == maxBowls;
        public bool IsFirstCell => !IsTheLastCell && cells[index].FirstRoll == null;
        public bool IsSecondCell => !IsTheLastCell && cells[index].SecondRoll == null;
        public bool IsHaveBonusRoll => strikeSpare(maxBowls - 1);

        public void FirstRoll() => cells[index].FirstRoll = rollNumber = randomBowls;
        public void SecondRoll() { cells[index].SecondRoll = randomBowls; UpdateResults(); }
        public void BonusRoll() { index--; cells[index].ResultRoll += cells[index].BonusRoll = randomBowls; }

        private void UpdateResults()
        {
            if (index > 0)
            {
                if (strikeSpare(index))
                    UpdateResultBefore();
                UpdateResultAfter();
            }
            NextCell();
        }
        private void UpdateResultBefore() => cells[index - 1].ResultRoll += cells[index].FirstRoll;
        private void UpdateResultAfter() => cells[index].ResultRoll += cells[index - 1].ResultRoll;
        private void NextCell() { index++; rollNumber = 0; }
    }
}