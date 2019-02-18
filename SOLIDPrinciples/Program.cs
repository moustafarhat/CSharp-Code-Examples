using System;
using System.Collections.Generic;
using Solid.OpenClosed;
using SOLIDPrinciples.DependencyInversion;
using SOLIDPrinciples.InterfaceSegregation;
using SOLIDPrinciples.Liskov;
using SOLIDPrinciples.SingleResponsibility;

namespace SOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID Principles:");

            var principles = new List<IPrinciple>()
            {
                new Srp(),
                new Ocp(),
                new Lsp(),
                new Isp(),
                new Dip()
            };
            principles.ForEach(type =>
            {
                Console.WriteLine($"- {type.Principle()}");
            });
            Console.Read();
        }
    }
}
