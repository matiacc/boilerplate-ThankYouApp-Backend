﻿using NetCoreBoilerplate.Contracts;
using NetCoreBoilerplate.Entities;
using NetCoreBoilerplate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBoilerplate.Repository
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
        public MessageRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
