using System;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;

namespace Win.Fmp
{
    public interface IPersonService:ICrudAppService<PersonDto,Guid>
    {
        
    }
}