namespace CleanMinimalApi.Application.Reviews.Create;

using CleanMinimalApi.Domain.Reviews.Entities;
using MediatR;

public class CreateCommand : IRequest<Review>
{
    public Guid AuthorId { get; set; }
    public Guid MovieId { get; set; }
    public int Stars { get; set; }
}
