using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyCourse.Model.Models;
public class BookAuthorConfig:IEntityTypeConfiguration<BookAuthor> {
    public void Configure(EntityTypeBuilder<BookAuthor> builder) {
        builder.HasKey(ba => new { ba.BookId, ba.AuthorId });
    }
}