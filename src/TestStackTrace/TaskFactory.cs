namespace TestStackTrace;

public class TaskFactory
{
    private const string forbiddenUrl = @"https://api.github.com/users/Elfocrash";

    private HttpClient httpClient { get; } = new();

    public async Task<string> GetStringWithAsync()
        => await httpClient.GetStringAsync(forbiddenUrl);

    public Task<string> GetStringWithoutAsync()
        => httpClient.GetStringAsync(forbiddenUrl);
}