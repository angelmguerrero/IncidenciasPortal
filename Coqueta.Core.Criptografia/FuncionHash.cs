using System;
using System.Configuration.Assemblies;
using System.Security.Cryptography;
using System.Text;

namespace Coqueta.Core.Criptografia
{
    public static class FuncionHash
    {
        #region Métodos Públicos

        public static string GenerarHash()
        {
            return GenerarHash(AssemblyHashAlgorithm.SHA1, Guid.NewGuid().ToString());
        }

        public static string GenerarSHA1(string cadena)
        {
            return GenerarHash(AssemblyHashAlgorithm.SHA1, cadena);
        }

        public static string GenerarHash(AssemblyHashAlgorithm algoritmo, string cadena)
        {
            HashAlgorithm algoritmoHash = HashAlgorithm.Create(algoritmo.ToString());
            try
            {
                byte[] buffer = algoritmoHash.ComputeHash(UTF7Encoding.UTF7.GetBytes(cadena));
                return BitConverter.ToString(buffer, 0).ToUpperInvariant().Replace("-", string.Empty);
            }
            finally
            {
                if (algoritmoHash != null)
                {
                    algoritmoHash.Clear();
                }
            }
        }

        #endregion
    }
}
