
namespace Globomantics.Domain
{
    public abstract record Todo(
    Guid Id,
    string Title,
    DateTimeOffset createdDate,
    User createdBy,
    bool IsCompleted = false,
    bool IsDeleted = false
    )
    {
        public Todo? Parent { get; init; }
    }
}