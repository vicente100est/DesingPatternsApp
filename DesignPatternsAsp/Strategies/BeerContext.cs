using DesignPatterns.Repository.Interface;
using DesignPatternsAsp.Models.ViewModels;

namespace DesignPatternsAsp.Strategies
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;
        public IBeerStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }

        public BeerContext(IBeerStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void Add(FormBeerViewModel beerVW, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerVW, unitOfWork);
        }
    }
}
