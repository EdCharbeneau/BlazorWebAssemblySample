namespace BlazorSample.Client
{
    public interface IArticleService
    {
        Task<string[]> GetArticleTitles(int count);
    }
}
