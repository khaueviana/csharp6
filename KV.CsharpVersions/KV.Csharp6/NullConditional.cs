﻿using System;
using System.IO;
using System.Linq;

namespace KV.Csharp6
{
    public static class NullConditional
    {
        public static void Execute()
        {
            DirectoryInfo diretorio = new DirectoryInfo("C://teste");

            Console.WriteLine("Diretório: " + (diretorio?.FullName ?? "Não definido"));

            Console.WriteLine("Primeiro subdiretório: " + (diretorio?.GetDirectories().FirstOrDefault()?.FullName ?? "Não encontrado"));
        }
    }
}
