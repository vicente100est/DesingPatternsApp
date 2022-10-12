using DesignPatterns.Repository.Interface;
using DesignPatternsAsp.Models.ViewModels;

namespace DesignPatternsAsp.Strategies
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork);
    }
}
