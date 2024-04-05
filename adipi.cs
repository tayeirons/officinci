public async Task PerformDelayedActionAsync(CancellationToken cancellationToken)
{
    try
    {
        // Wait for 10 seconds asynchronously, allowing for task cancellation
        await Task.Delay(TimeSpan.FromSeconds(10), cancellationToken);
    }
    catch (TaskCanceledException)
    {
        // Handle the task cancellation here if needed
        Console.WriteLine("The delay was canceled.");
    }
    catch (Exception ex)
    {
        // Handle any other exceptions that may occur
        Console.WriteLine($"An exception occurred: {ex.Message}");
    }
}
