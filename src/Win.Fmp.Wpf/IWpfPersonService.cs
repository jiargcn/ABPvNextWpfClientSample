using Volo.Abp.DependencyInjection;

namespace Win.Fmp.Wpf
{
    public interface IWpfPersonService : ITransientDependency
    {
        string GetPersons();
    }
}