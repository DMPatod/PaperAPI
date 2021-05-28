using BuildingBlocks.Domains.Commons;
using System.Threading;
using System.Threading.Tasks;

namespace BuildingBlocks.Domains.DomainEvents
{
    public interface IDomainMessageHandler
    {
        Task PublishAsync<T>(T domainEvent, CancellationToken cancellationToken) where T : IDomainEvent;
        Task SendAsync(ICommand command, CancellationToken cancellationToken);
        Task<TResponse> SendAsync<TResponse>(ICommand<TResponse> command, CancellationToken cancellationToken);
    }
}
