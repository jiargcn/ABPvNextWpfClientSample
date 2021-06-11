using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace Win.Fmp.HttpApi.Client.ConsoleTestApp
{
    public class ClientDemoService : ITransientDependency
    {
        private readonly IProfileAppService _profileAppService;

        private readonly IPersonService _personService;

        public ClientDemoService(IProfileAppService profileAppService, IPersonService personService)
        {
            _profileAppService = profileAppService;
            _personService = personService;
        }

        public async Task RunAsync()
        {
            var output = await _profileAppService.GetAsync();
            Console.WriteLine($"UserName : {output.UserName}");
            Console.WriteLine($"Email    : {output.Email}");
            Console.WriteLine($"Name     : {output.Name}");
            Console.WriteLine($"Surname  : {output.Surname}");

            var input = new PagedAndSortedResultRequestDto
            {
                SkipCount = 0,
                    MaxResultCount = 100,
                    Sorting = "",
            };
            var persons =await _personService.GetListAsync(input);
            foreach (var person in persons.Items)
            {
                Console.WriteLine(person.Name+" "+person.Age);
            }


        }
    }
}