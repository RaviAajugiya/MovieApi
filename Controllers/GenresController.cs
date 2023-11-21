using MovieApi.Services;

namespace MovieApi.Controllers
{
    public class GenresController
    {
        private readonly IRepository repository;

        public GenresController(IRepository repository)
        {
            this.repository = repository;
        }
    }
}
