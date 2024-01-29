namespace Globomantics.Domain
{
    public record Feature(
        string Title, 
        string Description, 
        string Component,
        int Priority, 
        User createdBy,
        User AssignedTo): TodoTask(Title, DateTimeOffset.MinValue,createdBy);
}
