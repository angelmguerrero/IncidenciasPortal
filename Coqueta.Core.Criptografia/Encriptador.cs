using System;
using System.Configuration.Assemblies;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Coqueta.Core.Criptografia
{
    public sealed class Encriptador : IDisposable
    {
        #region Campos

        private RijndaelManaged algoritmoEncripcion;

        #endregion

        #region Constructores

        public Encriptador(string palabraClave, string semilla, AssemblyHashAlgorithm algoritmoHash, int numeroIteraciones)
        {
            this.inicializar(palabraClave, semilla, algoritmoHash, numeroIteraciones);
        }

        private Encriptador()
        {
            this.inicializar();
        }

        #endregion

        #region Métodos Públicos Estáticos 

        public static string Cifrar(string cadena)
        {
            if (cadena != string.Empty)
            {
                Encriptador encriptador = null;
                try
                {
                    encriptador = new Encriptador();
                    return encriptador.CifrarCadena(cadena);
                }
                finally
                {
                    if (encriptador != null)
                    {
                        encriptador.Dispose();
                    }
                }
            }

            return string.Empty;
        }

        public static string Descifrar(string cadenaCifrada)
        {
            Encriptador encriptador = null;
            try
            {
                encriptador = new Encriptador();
                return encriptador.DescifrarCadena(cadenaCifrada);
            }
            finally
            {
                if (encriptador != null)
                {
                    encriptador.Dispose();
                }
            }
        }

        #endregion

        #region Métodos Públicos

        public string CifrarCadena(string cadena)
        {
            if (cadena != string.Empty)
            {
                ICryptoTransform encriptador;
                byte[] buffer;

                try
                {
                    encriptador = this.algoritmoEncripcion.CreateEncryptor();
                    buffer = Encoding.UTF8.GetBytes(cadena);
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encriptador, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(buffer, 0, buffer.Length);
                            cryptoStream.FlushFinalBlock();
                            buffer = memoryStream.ToArray();
                        }
                    }

                    return Convert.ToBase64String(buffer);
                }
                finally
                {
                    encriptador = null;
                    buffer = null;
                }
            }

            return string.Empty;
        }

        public string DescifrarCadena(string cadenaCifrada)
        {
            ICryptoTransform decriptador;
            byte[] bufferCadenaCifrada;
            byte[] bufferCadenaDescifrada;
            int longitudCadenaDescifrada;

            try
            {
                if (cadenaCifrada != null && cadenaCifrada != string.Empty)
                {
                    decriptador = this.algoritmoEncripcion.CreateDecryptor();
                    bufferCadenaCifrada = Convert.FromBase64String(cadenaCifrada);

                    using (MemoryStream memoryStream = new MemoryStream(bufferCadenaCifrada))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decriptador, CryptoStreamMode.Read))
                        {
                            bufferCadenaDescifrada = new byte[bufferCadenaCifrada.Length];
                            longitudCadenaDescifrada = cryptoStream.Read(bufferCadenaDescifrada, 0, bufferCadenaDescifrada.Length);
                        }
                    }

                    return Encoding.UTF8.GetString(bufferCadenaDescifrada, 0, longitudCadenaDescifrada);
                }

                return string.Empty;
            }
            finally
            {
                decriptador = null;
                bufferCadenaCifrada = null;
                bufferCadenaDescifrada = null;
            }
        }

        public void Dispose()
        {
            if (this.algoritmoEncripcion != null)
            {
                this.algoritmoEncripcion.Clear();
            }

            GC.SuppressFinalize(this);
        }

        #endregion

        #region Métodos Privados

        private void inicializar(string palabraClave, string semilla, AssemblyHashAlgorithm algoritmoHash, int numeroIteraciones)
        {
            byte[] bufferSemilla = Encoding.UTF8.GetBytes(semilla);

            PasswordDeriveBytes password = new PasswordDeriveBytes(palabraClave, bufferSemilla) { HashName = algoritmoHash.ToString(), IterationCount = numeroIteraciones };
            byte[] bufferKey = password.GetBytes(32);
            byte[] bufferIV = password.GetBytes(16);

            this.algoritmoEncripcion = new RijndaelManaged();
            this.algoritmoEncripcion.Mode = CipherMode.CBC;
            this.algoritmoEncripcion.Key = bufferKey;
            this.algoritmoEncripcion.IV = bufferIV;
        }

        private void inicializar()
        {
            this.inicializar("COQUETA", "PORTAL", AssemblyHashAlgorithm.SHA1, 5);
        }

        #endregion
    }
}
