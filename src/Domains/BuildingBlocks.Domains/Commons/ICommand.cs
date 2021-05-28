using MediatR;

namespace BuildingBlocks.Domains.Commons
{
    public interface ICommand : ICommand<bool>
    {
    }
    public interface ICommand<out TCommand> : IRequest<TCommand>
    {
    }
}
