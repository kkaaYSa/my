using Microsoft.AspNetCore.Mvc;
using my.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    private readonly AppDbContext _context;

    public BlogController(AppDbContext context)
    {
        _context = context;
    }

    // Burada metodlarımız olacak
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        // Veritabanından gönderilen ID ile yazıyı bul
        var post = await _context.BlogPosts.FindAsync(id);

        // Eğer yoksa 404 döndür
        if (post == null)
            return NotFound();

        // Eğer varsa 200 OK ile JSON olarak gönder
        return Ok(post);
    }

[HttpPost]
public async Task<IActionResult> Add(BlogPost newPost)
{
    _context.BlogPosts.Add(newPost);          // Yeni yazıyı ekle
    await _context.SaveChangesAsync();        // Veritabanına kaydet
    return CreatedAtAction(nameof(GetById),   // HTTP 201 döndür
        new { id = newPost.Id }, newPost);
}


}
