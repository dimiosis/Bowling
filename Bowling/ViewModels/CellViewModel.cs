using Bowling.Models;
using Bowling.Services;
using GalaSoft.MvvmLight;

namespace Bowling.ViewModels
{
    internal class CellViewModel : ViewModelBase
    {
        public Cell Cell { get; set; }
        public CellViewModel(ICellService service)
        {
            Cell = new Cell();
            service.AddCell(Cell);
        }
    }
}