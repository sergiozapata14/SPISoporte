using System.Collections.Generic;
using Datos;
using Entidades;

namespace Logica
{
    public class UserProfileLogica
    {
        private readonly UserProfileDatos _datos;

        public UserProfileLogica(UserProfileDatos datos)
        {
            _datos = datos;
        }

        public List<UserProfile> BuscarPorAccountNumber(string accountNumber)
        {
            return _datos.ObtenerPorAccountNumber(accountNumber);
        }
    }
}