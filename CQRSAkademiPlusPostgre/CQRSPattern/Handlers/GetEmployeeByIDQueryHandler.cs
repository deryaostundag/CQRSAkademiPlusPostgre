using CQRSAkademiPlusPostgre.CQRSPattern.Queries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetEmployeeByIDQueryHandler
    {
        private readonly Context _context;

        public GetEmployeeByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetEmployeeIDQueryResult Handle(GetEmployeeByIDQuery query)
        {
            var values = _context.Employees.Find(query.Id);
            return new GetEmployeeIDQueryResult
            {
                EmployeeCity = values.EmployeeCity,
                EmployeeID = values.EmployeeID,
                EmployeeName = values.EmployeeName,
                EmployeeSurname = values.EmployeeSurname
            };
        }
    }
}
