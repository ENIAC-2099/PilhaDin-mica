using System;

namespace PilhaDinâmica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaDinamica primiraPilha = new PilhaDinamica();
            primiraPilha.Push(8);
            primiraPilha.Push(10);
            primiraPilha.Push(40);
            primiraPilha.Push(85);
            primiraPilha.Push(103);


            primiraPilha.ListarPilha();

            primiraPilha.Pop();
            primiraPilha.Pop();
            
            primiraPilha.ListarPilha();



            Console.ReadLine();
        }
    }
}
