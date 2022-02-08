using Refit;
using RefitExample.Dto;
using RefitExample.Models;
using RefitExample.Results;
using System.Threading.Tasks;

namespace RefitExample.Repositories.Interfaces
{
	public interface ICarRepository
	{
		[Get("/v1/cars")]
		Task<CarDTO> ReturnCar();

		[Post("/v1/cars")]
		Task<Result> InsertCar(CarModel car);
	}
}