using Gestion.Parc.Informatique.Data;
using Microsoft.EntityFrameworkCore;

namespace Gestion.Parc.Informatique.Service;
public class LookupService : IHostedService
{
    private readonly ISharedDataService _sharedData;
    public LookupService(ISharedDataService sharedData)
    {
        _sharedData = sharedData;
    }
    public Task StartAsync(CancellationToken cancellationToken)
    {
        _sharedData.LoadLookups();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("----> Shutting Down App ...");
        return Task.CompletedTask;
    }


}