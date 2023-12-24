using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>,IProducerService
    {

        public ProducersService(AppDbContext context) : base(context)
        {
            
        }
    }
}
