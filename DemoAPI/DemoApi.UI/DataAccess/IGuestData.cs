using DemoApi.UI.Models;
using Refit;

namespace DemoApi.UI.DataAccess
{
    public interface IGuestData
    {
        [Get("/Guests")]
        Task<List<Guest>> GetGuests();

        [Get("/Guests/{id}")]
        Task<Guest> GetGuestById(int id);

        [Post("/Guests")]
        Task CreateGuest([Body] Guest guest);

        [Put("/Guests/{id}")]
        Task UpdateGuest([Body] Guest guest, int id);

        [Delete("/Guests/{id}")]
        Task DeleteGuest(int id);
    }
}
