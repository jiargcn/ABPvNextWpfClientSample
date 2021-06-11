using System;
using Volo.Abp.Application.Dtos;

namespace Win.Fmp
{
    public class PersonDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}