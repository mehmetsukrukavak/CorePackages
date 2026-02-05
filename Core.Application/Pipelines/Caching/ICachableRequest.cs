namespace Core.Application.Pipelines.Caching;

public interface ICachableRequest
{
    string CacheKey { get; set; }
    bool BypassCache { get; set; }
    TimeSpan? SlidingExpiration { get; set; }
    
    string? CacheGroupKey { get; }
}