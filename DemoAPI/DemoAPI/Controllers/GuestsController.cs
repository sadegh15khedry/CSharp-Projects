using DemoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers;
[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class GuestsController : Controller
{
    private static List<Guest> Guests = new List<Guest>()
    {
        new Guest()
        {
            Id = 1,
            FirstName="akvar",
            LastName ="asghari"
        },
        new Guest()
        {
            Id = 2,
            FirstName="a",
            LastName ="i"
        },
        new Guest()
        {
            Id = 3,
            FirstName="kevin",
            LastName ="Jackson"
        }
    };

    // GET: GuestsController
    /// <summary>
    /// returns All Guests
    /// </summary>
    /// <returns>
    /// returns All Guests
    /// </returns>
    /// <remarks>
    /// sample request 
    /// Get /api/Guests
    /// </remarks>
    [HttpGet]
    [Route("api/Guests")]
    public List<Guest> GetGuests()
    {
        return Guests.ToList();
    }


    // GET: GuestsController
    /// <summary>
    /// returns a guest based on GuestId
    /// </summary>
    /// <returns>
    /// returns a guest based on GuestId
    /// </returns>
    /// <remarks>
    /// sample request :
    /// Get /api/Guests/1
    /// </remarks>
    /// <response code="200">
    /// Returns guest with matching id
    /// </response>
    /// <response code="404">
    /// Not Found
    /// </response>
    /// <response code="401">
    /// not allowed to access this guest.
    /// </response>
    [Route("api/Guests/{id}")]
    [HttpGet]
    // GET: GuestsController/Guests/5
    public Guest GetGuestById(int id)
    {
        return Guests.FirstOrDefault(s => s.Id == id);
    }



    // POST: GuestsController/Create
    [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult CreateGuest(Guest guest)
    {
        Guests.Add(guest);
        return StatusCode(200);
    }


    // POST: GuestsController/Edit/5
    [HttpPut]
    [ValidateAntiForgeryToken]
    public ActionResult UpdateGuest(int id, Guest guest)
    {
        Guests.Remove(Guests.Where(s => s.Id == id).FirstOrDefault());
        Guests.Add(guest);
        return StatusCode(200);

    }


    // POST: GuestsController/Delete/5
    [HttpDelete]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteGuest(int id)
    {
        Guests.Remove(Guests.Where(s => s.Id == id).FirstOrDefault());
        return StatusCode(200);
    }
}
