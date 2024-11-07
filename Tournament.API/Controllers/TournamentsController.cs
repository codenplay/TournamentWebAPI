using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tournament.Model.Entities;

namespace Tournament.API.Controllers
{
    [Route("api/tournaments")]
    [ApiController]
    public class TournamentsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IList<Tournaments>> Get()
        {
            var tournaments = GenerateMockTournaments();
            return tournaments.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Tournaments> GetTournamentsById(Guid id)
        {
            var tournaments = GenerateMockTournaments();
            var tournament = tournaments.FirstOrDefault(x => x.Id == id);

            if (tournament == null)
            {
                return new NotFoundResult();
            }

            return tournament;
        }

        private List<Tournaments> GenerateMockTournaments() 
        { 
            return new List<Tournaments> { 
                new Tournaments(new Guid("b3d3452e-6933-49f7-9ce2-5b671c6f7aff"),"Super","A","ABC"),
                new Tournaments(new Guid("b3d3453e-6933-49f7-9ce2-5b671c6f7aff"),"Premier","AA","AUST"),
                new Tournaments(new Guid("b3d3454e-6933-49f7-9ce2-5b671c6f7aff"),"Gold","B","MNC"),
                new Tournaments(new Guid("b3d3455e-6933-49f7-9ce2-5b671c6f7aff"),"Silver","C","XYZ"),
            };
        }
    }
}
