using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Brands.Queries.GetAllBrands
{
    public class GetAllBrandsQueryResponse
    {
        public string Name { get; set; }
        public bool isDeleted { get; set; }
    }
}
