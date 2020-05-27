﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OOADLABB2
{
    public class ConsoleViewer : IViewer
    {
        private readonly IAstronautService astrounatService;

        public ConsoleViewer(IAstronautService astrounautService)
        {
            this.astrounatService = astrounautService;
        }

        public void Load()
        {
            printCurrentAstronauts(astrounatService.GetAstronauts().ToList());
        }

        public void printCurrentAstronauts(List<Astronauts> CurrentAstronauts)
        {
            Console.WriteLine("Number of persons in space: {0}", CurrentAstronauts.Count);
            foreach (var astronaut in CurrentAstronauts)
            {
                Console.WriteLine("Name: {0}, Craft: {1}", astronaut.name, astronaut.craft);
            }
        }
    }
}