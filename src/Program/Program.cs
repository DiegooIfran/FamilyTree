using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            SumVisitor visitor = new SumVisitor();
            n1.Accept(visitor);
            Console.WriteLine($"Suma de nodos: {visitor.Sum}");
            
            Person p1 = new Person(73, "Pedro");
            Person p2 = new Person(41, "Claudia");
            Person p3 = new Person(37, "Juan");
            Person p4 = new Person(10, "Pedro Junior");
            Person p5 = new Person(7, "Juana");
            Person p6 = new Person(9, "Ana");
            Person p7 = new Person(4, "Martina");

            p1.AddChildren(p2);
            p1.AddChildren(p3);

            p2.AddChildren(p4);
            p2.AddChildren(p5);

            p3.AddChildren(p6);
            p3.AddChildren(p7);

            // visitar el árbol aquí
            SumVisitor visitorp = new SumVisitor();
            p1.Accept(visitorp);
            Console.WriteLine($"Suma de edades: {visitorp.Sum}");
        }
    }
}
