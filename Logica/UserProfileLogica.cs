using Datos;
using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class UserProfileLogica
    {
        private readonly UserProfileDatos _datos;

        public UserProfileLogica(UserProfileDatos datos)
        {
            _datos = datos;
        }

        public List<UserProfile> ObtenerPorAccountNumber(string accountNumber)
        {
            return _datos.ObtenerPorAccountNumber(accountNumber);
        }
    }
}