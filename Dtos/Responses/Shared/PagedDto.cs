using ApiCoreAdoNetCrudPagination.Models;

namespace ApiCoreAdoNetCrudPagination.Dtos.Responses.Shared
{
    public abstract class PagedDto : SuccessResponse
    {
        public PageMeta PageMeta { get; set; }
    }
}