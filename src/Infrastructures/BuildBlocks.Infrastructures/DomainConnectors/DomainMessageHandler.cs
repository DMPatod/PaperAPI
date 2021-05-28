using BuildingBlocks.Domains.Commons;
using BuildingBlocks.Domains.DomainEvents;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace BuildingBlocks.Infrastructures.DomainConnectors
{
    public class DomainMessageHandler : IDomainMessageHandler
    {
        private readonly IMediator mediator;
        public DomainMessageHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public Task PublishAsync<T>(T domainEvent, CancellationToken cancellationToken)
            where T : IDomainEvent
        {
            return mediator.Publish(domainEvent, cancellationToken);
        }

        public Task SendAsync(ICommand command, CancellationToken cancellationToken)
        {
            return mediator.Send(command, cancellationToken);
        }

        public Task<TResponse> SendAsync<TResponse>(ICommand<TResponse> command, CancellationToken cancellationToken)
        {
            return mediator.Send(command, cancellationToken);
        }
    }
    public static class DomainMessageDIExtension
    {
        public static IServiceCollection AddDomainMessageHandler(this IServiceCollection services, params Assembly[] assemblies)
        {
            services.AddMediatR(assemblies);
            services.TryAddTransient<IDomainMessageHandler, DomainMessageHandler>();
            return services;
        }
    }
}
