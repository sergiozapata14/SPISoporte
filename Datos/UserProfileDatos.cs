using Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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
                .Where(up => up.AccountNumber == accountNumber)
                .ToList();
        }
    }
}