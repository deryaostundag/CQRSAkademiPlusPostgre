using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class RemoveEmployeCommandHandler
    {
        private readonly Context _context;

        public RemoveEmployeCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveEmployeeCommand command)
        {
            var values = _context.Employees.Find(command.Id);
            _context.Employees.Remove(values);
            _context.SaveChanges();
        }
    }
}
