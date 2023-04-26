using Microsoft.AspNetCore.Mvc;

namespace API_MODUL9_1302213121.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public static List<Movie> MovieList = new List<Movie>()
        {
            new Movie(){
                title = "The Lord of the Rings: The Return of the King",
                Director = "Peter Jackson",
                Stars = new[]{"Klijah Wood","Viggo Mortensen","Ian McKellen","Orlando Bloom" },
                Description = "Gandalf and aragorn lead  the world...."
            },
            new Movie(){
                title = "The Dark Knight",
                Director = "Cristoper Nolan",
                Stars = new[]{"Cristian Bale","Heath Ledger","Aaron Eckhart","Michael Caine" },
                Description = "When the manace known as the joker...."
            },
        };

        // GET: api
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return MovieList;
        }

        // GET api
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return MovieList[id];
        }

        // POST api
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            MovieList.Add(value);
        }

        // PUT api
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movie value)
        {
            MovieList[id] = value;
        }

        // DELETE api
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MovieList.RemoveAt(id);
        }
    }
};