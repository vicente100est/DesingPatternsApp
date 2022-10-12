using DesignPatterns.Models.Data;
using DesignPatterns.Repository.Interface;
using DesignPatternsAsp.Models.ViewModels;
using System;

namespace DesignPatternsAsp.Strategies
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.BeerName = beerVM.Name;
            beer.BeerStyle = beerVM.Style;
            beer.BrandId = (Guid)beer.BrandId;

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
