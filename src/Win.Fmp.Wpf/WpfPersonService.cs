using System;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Win.Fmp.Wpf
{
    public class WpfPersonService : IWpfPersonService
    {
        private readonly IPersonService _personService;

        public WpfPersonService(IPersonService personService)
        {
            _personService = personService;
        }

        public string GetPersons()
        {
            var sb = new StringBuilder();
            var input = new PagedAndSortedResultRequestDto
            {
                SkipCount = 0,
                MaxResultCount = 100,
                Sorting = "",
            };
            var persons = _personService?.GetListAsync(input);
            if (persons == null || persons.Result == null) return "null";
            foreach (var person in persons?.Result.Items)
            {
                var str = $"{person.Name} {person.Age}";
                sb.AppendLine(str);
                Console.WriteLine(str);
            }

            return sb.ToString();
        }
    }
}