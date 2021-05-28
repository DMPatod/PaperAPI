using MediatR;

namespace BuildingBlocks.Domains.Commons
{
    public interface ICommandHandler<in TCommand> : ICommandHandler<ICommand, bool>
        where TCommand : ICommand
    {
    }
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
    {
    }
}
