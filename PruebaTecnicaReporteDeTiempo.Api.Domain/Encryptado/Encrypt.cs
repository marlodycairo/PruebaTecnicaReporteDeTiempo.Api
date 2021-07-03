﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Domain.Encryptado
{
    public class Encrypt
    {
        public static string ObtenerSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();

            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] stream;

            StringBuilder sb = new StringBuilder();

            stream = sha256.ComputeHash(encoding.GetBytes(str));

            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:x2}", stream[i]);

            return sb.ToString();
        }
    }
}
