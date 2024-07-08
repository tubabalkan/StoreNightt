using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreNightt.Application.Feature.CQRS.Results.CategoryResults
{
	public class GetCategoryByIdQueryResult
	{
		public int CtegoryId { get; set; }
		public string CtegoryName { get; set; }
	}
}
