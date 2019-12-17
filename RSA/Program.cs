﻿using System;
using Type.BigInteger;

namespace Crypto.RSA
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var operand1 = new BigInteger("3");
            var operand2 = new BigInteger("7");
            var actual = operand1.ModOfPower(operand2, new BigInteger("5"));
            var expect = new BigInteger("2");

            Console.WriteLine();
            Console.WriteLine($"    [OPRND1]     {operand1} | Length: {operand1.Length} | Clusters: {operand1.ClustersLength}");
            Console.WriteLine($"    [OPRND2]     {operand2} | Length: {operand2.Length} | Clusters: {operand2.ClustersLength}");
            Console.WriteLine($"    [Actual]     {actual} | Length: {actual.Length} | Clusters: {actual.ClustersLength}");
            Console.WriteLine($"    [Expect]     {expect} | Length: {expect.Length} | Clusters: {expect.ClustersLength}");
            Console.WriteLine($"    [Status]     {actual.Equals(expect)}");
            Console.WriteLine();


        }
    }
}