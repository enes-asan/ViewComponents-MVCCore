using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using ViewComponents.Entites;

namespace ViewComponents
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public StringValues CategoryId { get; internal set; }
    }
}