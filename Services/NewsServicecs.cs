namespace SampleGrapQL
{
    public class NewsService
    {
        public async Task<List<NewsArticle>> GetNewsAsync()
        {
            // Simulate fetching data from an external news API
            return await Task.FromResult(new List<NewsArticle>
            { 
                new NewsArticle { Title = "News 1", Content = "Content 1", PublishedAt = DateTime.Now },
                new NewsArticle { Title = "News 2", Content = "Content 2", PublishedAt = DateTime.Now }
            });
        }
    }
}
