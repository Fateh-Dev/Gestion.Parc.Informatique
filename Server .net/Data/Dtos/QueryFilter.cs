namespace Gestion.Parc.Informatique.Data;

public class PagedQueryFilter
{
    public int Page { get; set; }
    public int PageSize { get; set; }
}

public class PagedStructureFilter : PagedQueryFilter
{
    public string? Display { get; set; }
    public Guid? ParentStructureId { get; set; }
}

public class PagedResultDto<T>
{
    public int TotalCount { get; set; }
    public List<T> Items { get; set; }
}