using AdvancedStudies_Backend.Data;
using AdvancedStudies_Backend.Models.Domain;
using AdvancedStudies_Backend.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdvancedStudies_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CourseController(ApplicationContext context)
        {
            _context = context;
        }
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetCourses()
        {
            var courses = await _context.Course.ToListAsync();
            if (courses.Count == 0)
            {
                return NotFound("No courses have been created");
            }
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var course = await _context.Course.FindAsync(id);
            if (course == null) return NotFound();
            return course;
        }

        [HttpPost]
        public async Task<ActionResult> CreateCourse(CreateCourseDto createCourseDto)
        {
            Course course = new(
                createCourseDto.Title, createCourseDto.SubTitle,
                createCourseDto.Description, createCourseDto.Price,
                createCourseDto.ImageUrl, createCourseDto.WelcomeMessage,
                createCourseDto.CongratulationsMessage
            );
            await _context.AddAsync(course);

            var result = await _context.SaveChangesAsync() > 0;
            if (result) return Created("", createCourseDto);

            return BadRequest(new ProblemDetails { Title = "Problem creating new course" });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCourse(UpdateCourseDto updateCourseDto)
        {
            var course = await _context.Course.FindAsync(updateCourseDto.Id);

            if (course == null) return NotFound();

            course.Title = updateCourseDto.Title;
            course.Description = updateCourseDto.Description;
            course.Price = updateCourseDto.Price;
            course.ImageUrl = updateCourseDto.ImageUrl;

            var result = await _context.SaveChangesAsync() > 0;
            if (!result) return BadRequest(new ProblemDetails { Title = "Problem updating course" });

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Course.FindAsync(id);
            if (course == null) return NotFound();

            _context.Course.Remove(course);
            var result = await _context.SaveChangesAsync() > 0;

            if (result) return Ok();

            return BadRequest(new ProblemDetails { Title = "Problem deleting course" });
        }

        [HttpPut("publish/{urlSlug}")]
        public async Task<ActionResult> PublishCourse(string urlSlug)
        {
            var course = await _context.Course.FirstOrDefaultAsync(c => c.UrlSlug == urlSlug);

            if (course == null) return NotFound();

            course.PublishedAt = DateTime.Now;

            var result = await _context.SaveChangesAsync() > 0;
            if (!result) return BadRequest(new ProblemDetails { Title = "Problem publishing course" });

            return NoContent();
        }
    }
}
