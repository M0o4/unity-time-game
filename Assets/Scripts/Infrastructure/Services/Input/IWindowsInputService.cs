namespace Infrastructure.Services.Input
{
    public interface IWindowsInputService : IInputService
    {
        string name { get; set; }
    }
}