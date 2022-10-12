using DesignPatterns.Models.Data;
using DesignPatterns.Repository.Interface;
using DesignPatternsAsp.Models.ViewModels;
using System;

namespace DesignPatternsAsp.Strategies
{
    public class BeerWithBrandStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.BeerName = beerVM.Name;
            beer.BeerStyle = beerVM.Style;

            var brand = new Brand();
            brand.BrandName = beerVM.OtherBrand;
            brand.BrandId = Guid.NewGuid();
            beer.BrandId = brand.BrandId;

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);

            unitOfWork.Save();
        }
    }
}
