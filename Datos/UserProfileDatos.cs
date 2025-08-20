using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace Datos
{
    public class UserProfileDatos
    {
        private readonly ConexionDB _context;

        public UserProfileDatos(ConexionDB context)
        {
            _context = context;
        }

        public List<UserProfile> ObtenerPorAccountNumber(string accountNumber)
        {
            return _context.UserProfiles
                           .Where(u => u.AccountNumber == accountNumber)
                           .ToList();
        }
    }
}