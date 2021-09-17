using Bowling.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bowling.ViewModels
{
    internal class ViewModelLocator
    {
        private readonly IServiceProvider provider = new ServiceCollection()
            .AddTransient<CellViewModel>()
            .AddSingleton<MainViewModel>()
            .AddSingleton<BowlingService>()
            .AddSingleton<ICellService>(p => p.GetRequiredService<BowlingService>())
            .AddSingleton<IUiControlService>(p => p.GetRequiredService<BowlingService>())
            .BuildServiceProvider();

        public CellViewModel Cell => provider.GetRequiredService<CellViewModel>();
        public MainViewModel Main => provider.GetRequiredService<MainViewModel>();
    }
}