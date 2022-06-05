using BroadageSportsBackend.Api.Helpers;
using BroadageSportsBackend.Core.Entity2;
using BroadageSportsBackend.Core.Pagination;
using BroadageSportsBackend.Service.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace BroadageSportsBackend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoccerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<SoccerController> _logger;

        public SoccerController(IUnitOfWork unitOfWork, ILogger<SoccerController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task< IActionResult> GetTournamentList([FromQuery] PagingParams pagingParams)
        {

            try
            {
                List<Expression<Func<TournamentList, bool>>> expressions = new List<Expression<Func<TournamentList, bool>>>();
                if (pagingParams.Searchtext != null)
                {
                    Expression<Func<TournamentList, bool>> condition = tournamentList => (

                    tournamentList.globalName.ToLower().Contains(pagingParams.Searchtext.ToLower()) ||
                    tournamentList.mediumName.ToLower().Contains(pagingParams.Searchtext.ToLower())




                    );
                    expressions.Add(condition);
                }

                int dataCount = _unitOfWork.TournamentlistRepository.GetAllTableCount(expressions);

                var list =await _unitOfWork.TournamentlistRepository.GetTournamentWithCountryAndParticipantType();

                Response.AddPagination(pagingParams.PageNumber, pagingParams.PageSize, dataCount, dataCount / pagingParams.PageSize, pagingParams.Searchtext, pagingParams.Orderby, pagingParams.OrderbyAsc);
                return Ok(list);
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }

            
        }
    }
}
