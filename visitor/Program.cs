using System;
using System.Collections.Generic;

namespace visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<IElement> elements = new List<IElement>();
            elements.Add(new Led(Color.RED));
            elements.Add(new Led(Color.RED));
            elements.Add(new Led(Color.GREEN));
            elements.Add(new Led(Color.BLUE));
            elements.Add(new Led(Color.BLUE));
            elements.Add(new Ramp("Rampe1", true, 10));
            elements.Add(new Ramp("Rampe2", false, 4));
            elements.Add(new Ramp("Rampe3", true, 2));
            elements.Add(new Target('A'));
            elements.Add(new Target('B'));
            elements.Add(new Target('C'));
            elements.Add(new Target('D'));
            elements.Add(new Target('E'));
            ReportVisitor reportVisitor = new ReportVisitor();
            PointVisitor pointVisitor = new PointVisitor();
            ResetVisitor resetVisitor = new ResetVisitor();
            elements.ForEach(e => e.Accept(reportVisitor));
            elements.ForEach(e => e.Accept(pointVisitor));
            elements.ForEach(e => e.Accept(resetVisitor));
            elements.ForEach(e => e.Accept(reportVisitor));
            
        }
    }
}