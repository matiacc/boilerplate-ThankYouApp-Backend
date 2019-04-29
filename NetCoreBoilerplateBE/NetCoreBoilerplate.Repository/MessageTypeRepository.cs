using NetCoreBoilerplate.Contracts;
using NetCoreBoilerplate.Entities;
using NetCoreBoilerplate.Entities.Models;

namespace NetCoreBoilerplate.Repository
{
    public class MessageTypeRepository : RepositoryBase<MessageType>, IMessageTypeRepository
    {
        public MessageTypeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}