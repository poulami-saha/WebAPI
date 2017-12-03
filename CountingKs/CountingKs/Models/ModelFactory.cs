using CountingKs.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;

namespace CountingKs.Models
{
    public class ModelFactory
    {
        public ModelFactory(HttpRequestMessage request)
        {
            _urlHelper = new UrlHelper(request);
        }

        public UrlHelper _urlHelper;

        public FoodModel Create(Food food)
        {
            return new FoodModel
            {
                // Url = string.Format("http://localhost:8901/api/nutrition/foods/{id}", food.Id),
                Url = _urlHelper.Link("Food", new { foodid = food.Id }),
                Description = food.Description,
                Measures = food.Measures.Select(m => Create(m))
            };
        }

        public MeasureModel Create(Measure m)
        {
        return new MeasureModel
        {
            Url = _urlHelper.Link("Measures",new {foodid = m.Food.Id,id = m.Id }),
                Description = m.Description,
                Calories = m.Calories
            };
        }
    }
}