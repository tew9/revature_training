using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System;

namespace Digimon
{
    internal class Digimon
    {

    }
    class Program
    {
       static void Main(string[] args)
        {
            var p = new Program();
            p.Fight(null, null);
        }

        private void Fight(Digimon a, Digimon b){
          System.Console.WriteLine("{0} is fighting with {1}", a,b);
        }
    }
}
