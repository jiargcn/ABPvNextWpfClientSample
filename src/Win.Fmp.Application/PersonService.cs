using System;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Win.Fmp.Data;

namespace Win.Fmp
{
    public class PersonService : CrudAppService<Person,PersonDto,Guid>, IPersonService
    {
        private readonly IRepository<Person, Guid> _repository;
        public PersonService(IRepository<Person, Guid> repository) : base(repository)
        {
            _repository = repository;
        }

    }
}