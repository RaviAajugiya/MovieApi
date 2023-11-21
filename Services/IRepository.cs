using System.Collections.Generic;
using MovieApi.Entities;

namespace MovieApi.Services
{
    public interface IRepository
    {
        List<Genre> GetAllGenres();

    }
}
