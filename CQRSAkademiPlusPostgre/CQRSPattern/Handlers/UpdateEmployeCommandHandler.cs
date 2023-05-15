using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class UpdateEmployeCommandHandler
    {
        private readonly Context _context;

        public UpdateEmployeCommandHandler(Context context)
        {
            _context = context;
        }
    }
}
