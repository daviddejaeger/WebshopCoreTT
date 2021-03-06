﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebshopCoreTT.Models.Domain;

namespace WebshopCoreTT.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _context;

        public DataInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InitializeData()
        {
            _context.Database.EnsureDeleted();
            if (_context.Database.EnsureCreated())
            {
                Category rubber = new Category
                {
                    Name = "Rubber"
                };
                Category houtje = new Category
                {
                    Name = "Houtje"
                };
                rubber.Products = new List<Product>();
                houtje.Products = new List<Product>();

                Rubber product1 = new Rubber
                {
                    Name = "Stiga Mantra S",
                    Price = 30.90,
                    Manufacturer = "Stiga",
                    Description = "De nieuwe STIGA Mantra is ontwikkeld met behulp van de nieuwste Japanse rubber" +
                    " - technologie en biedt de perfecte balans tussen synthetisch en natuur rubber.",
                    OnSale = false,
                    IsNew = true,
                    ImagePath = "/images/Stiga-Mantra-S.jpg"
                };
                Rubber product4 = new Rubber
                {
                    Name = "Stiga Mantra S",
                    Price = 30.90,
                    Manufacturer = "Stiga",
                    Description = "De nieuwe STIGA Mantra is ontwikkeld met behulp van de nieuwste Japanse rubber" +
                    " - technologie en biedt de perfecte balans tussen synthetisch en natuur rubber.",
                    OnSale = false,
                    IsNew = true,
                    ImagePath = "/images/Stiga-Mantra-S.jpg"
                };
                Rubber product5 = new Rubber
                {
                    Name = "Stiga Mantra S",
                    Price = 30.90,
                    Manufacturer = "Stiga",
                    Description = "De nieuwe STIGA Mantra is ontwikkeld met behulp van de nieuwste Japanse rubber" +
                    " - technologie en biedt de perfecte balans tussen synthetisch en natuur rubber.",
                    OnSale = false,
                    IsNew = true,
                    ImagePath = "/images/Stiga-Mantra-S.jpg"
                };
                Rubber product6 = new Rubber
                {
                    Name = "Stiga Mantra S",
                    Price = 30.90,
                    Manufacturer = "Stiga",
                    Description = "De nieuwe STIGA Mantra is ontwikkeld met behulp van de nieuwste Japanse rubber" +
                    " - technologie en biedt de perfecte balans tussen synthetisch en natuur rubber.",
                    OnSale = false,
                    IsNew = true,
                    ImagePath = "/images/Stiga-Mantra-S.jpg"
                };
                Rubber product7 = new Rubber
                {
                    Name = "Stiga Mantra S",
                    Price = 30.90,
                    Manufacturer = "Stiga",
                    Description = "De nieuwe STIGA Mantra is ontwikkeld met behulp van de nieuwste Japanse rubber" +
                    " - technologie en biedt de perfecte balans tussen synthetisch en natuur rubber.",
                    OnSale = false,
                    IsNew = true,
                    ImagePath = "/images/Stiga-Mantra-S.jpg"
                };
                Rubber product2 = new Rubber
                {
                    Name = "Nittaku Magic Carbon",
                    Price = 32.90,
                    SalesPrice = 28.90,
                    Manufacturer = "Nittaku",
                    Description = "De Carbo rubber heeft een uitzonderlijk katapult-effect en meer snelheid dan de klassieke rubbers," +
                    " met een enorme klank bij het raken van de bal. Het STIGA Air - Capsule systeem(ACS) kende een wereldwijd succes," +
                    "met 5 beroemde rubbers: Magna, Innova Premium, Innova, Innova Ultra Light en Radical. Alle onderlagen van deze " +
                    "rubbers hebben de ACS technologie, wat zorgt voor snelheid en veerkracht, voor een heel lichte rubber, met een " +
                    "uitzonderlijke controle.Vandaag heeft de Research &Development afdeling van STIGA de oplossing gevonden om de " +
                    "toplaag nog te verbeteren. De Mega tension technologie die de toplaag van de rubber verbetert, in combinate met de" +
                    "verbeterde onderlaag met de ACS, zorgt voor de snelste rubbers met de beste controle." +
                    "Air Capsule System(ACS) : De ACS technologie maakt het mogelijk om een enorme snelheid te combineren met een" +
                    "maximale veerkracht, zonder verlies van controle, bij een ultra - lichte rubber." +
                    "Mega Tension : De Mega Tension technologie verhoogt de veerkracht zonder het gewicht van de rubber te veranderen," +
                    "dankzij een sneller herstel van de rubber.",
                    OnSale = true,
                    IsNew = false,
                    ImagePath = "/images/Nittaku-magic-carbon.jpg"
                };
                Rubber product8 = new Rubber
                {
                    Name = "Nittaku Magic Carbon",
                    Price = 32.90,
                    SalesPrice = 28.90,
                    Manufacturer = "Nittaku",
                    Description = "De Carbo rubber heeft een uitzonderlijk katapult-effect en meer snelheid dan de klassieke rubbers," +
                    " met een enorme klank bij het raken van de bal. Het STIGA Air - Capsule systeem(ACS) kende een wereldwijd succes," +
                    "met 5 beroemde rubbers: Magna, Innova Premium, Innova, Innova Ultra Light en Radical. Alle onderlagen van deze " +
                    "rubbers hebben de ACS technologie, wat zorgt voor snelheid en veerkracht, voor een heel lichte rubber, met een " +
                    "uitzonderlijke controle.Vandaag heeft de Research &Development afdeling van STIGA de oplossing gevonden om de " +
                    "toplaag nog te verbeteren. De Mega tension technologie die de toplaag van de rubber verbetert, in combinate met de" +
                    "verbeterde onderlaag met de ACS, zorgt voor de snelste rubbers met de beste controle." +
                    "Air Capsule System(ACS) : De ACS technologie maakt het mogelijk om een enorme snelheid te combineren met een" +
                    "maximale veerkracht, zonder verlies van controle, bij een ultra - lichte rubber." +
                    "Mega Tension : De Mega Tension technologie verhoogt de veerkracht zonder het gewicht van de rubber te veranderen," +
                    "dankzij een sneller herstel van de rubber.",
                    OnSale = true,
                    IsNew = false,
                    ImagePath = "/images/Nittaku-magic-carbon.jpg"
                };
                Rubber product9 = new Rubber
                {
                    Name = "Nittaku Magic Carbon",
                    Price = 32.90,
                    SalesPrice = 28.90,
                    Manufacturer = "Nittaku",
                    Description = "De Carbo rubber heeft een uitzonderlijk katapult-effect en meer snelheid dan de klassieke rubbers," +
                    " met een enorme klank bij het raken van de bal. Het STIGA Air - Capsule systeem(ACS) kende een wereldwijd succes," +
                    "met 5 beroemde rubbers: Magna, Innova Premium, Innova, Innova Ultra Light en Radical. Alle onderlagen van deze " +
                    "rubbers hebben de ACS technologie, wat zorgt voor snelheid en veerkracht, voor een heel lichte rubber, met een " +
                    "uitzonderlijke controle.Vandaag heeft de Research &Development afdeling van STIGA de oplossing gevonden om de " +
                    "toplaag nog te verbeteren. De Mega tension technologie die de toplaag van de rubber verbetert, in combinate met de" +
                    "verbeterde onderlaag met de ACS, zorgt voor de snelste rubbers met de beste controle." +
                    "Air Capsule System(ACS) : De ACS technologie maakt het mogelijk om een enorme snelheid te combineren met een" +
                    "maximale veerkracht, zonder verlies van controle, bij een ultra - lichte rubber." +
                    "Mega Tension : De Mega Tension technologie verhoogt de veerkracht zonder het gewicht van de rubber te veranderen," +
                    "dankzij een sneller herstel van de rubber.",
                    OnSale = true,
                    IsNew = false,
                    ImagePath = "/images/Nittaku-magic-carbon.jpg"
                };
                Rubber product10 = new Rubber
                {
                    Name = "Nittaku Magic Carbon",
                    Price = 32.90,
                    SalesPrice = 28.90,
                    Manufacturer = "Nittaku",
                    Description = "De Carbo rubber heeft een uitzonderlijk katapult-effect en meer snelheid dan de klassieke rubbers," +
                    " met een enorme klank bij het raken van de bal. Het STIGA Air - Capsule systeem(ACS) kende een wereldwijd succes," +
                    "met 5 beroemde rubbers: Magna, Innova Premium, Innova, Innova Ultra Light en Radical. Alle onderlagen van deze " +
                    "rubbers hebben de ACS technologie, wat zorgt voor snelheid en veerkracht, voor een heel lichte rubber, met een " +
                    "uitzonderlijke controle.Vandaag heeft de Research &Development afdeling van STIGA de oplossing gevonden om de " +
                    "toplaag nog te verbeteren. De Mega tension technologie die de toplaag van de rubber verbetert, in combinate met de" +
                    "verbeterde onderlaag met de ACS, zorgt voor de snelste rubbers met de beste controle." +
                    "Air Capsule System(ACS) : De ACS technologie maakt het mogelijk om een enorme snelheid te combineren met een" +
                    "maximale veerkracht, zonder verlies van controle, bij een ultra - lichte rubber." +
                    "Mega Tension : De Mega Tension technologie verhoogt de veerkracht zonder het gewicht van de rubber te veranderen," +
                    "dankzij een sneller herstel van de rubber.",
                    OnSale = true,
                    IsNew = false,
                    ImagePath = "/images/Nittaku-magic-carbon.jpg"
                };
                Rubber product11 = new Rubber
                {
                    Name = "Nittaku Magic Carbon",
                    Price = 32.90,
                    SalesPrice = 28.90,
                    Manufacturer = "Nittaku",
                    Description = "De Carbo rubber heeft een uitzonderlijk katapult-effect en meer snelheid dan de klassieke rubbers," +
                    " met een enorme klank bij het raken van de bal. Het STIGA Air - Capsule systeem(ACS) kende een wereldwijd succes," +
                    "met 5 beroemde rubbers: Magna, Innova Premium, Innova, Innova Ultra Light en Radical. Alle onderlagen van deze " +
                    "rubbers hebben de ACS technologie, wat zorgt voor snelheid en veerkracht, voor een heel lichte rubber, met een " +
                    "uitzonderlijke controle.Vandaag heeft de Research &Development afdeling van STIGA de oplossing gevonden om de " +
                    "toplaag nog te verbeteren. De Mega tension technologie die de toplaag van de rubber verbetert, in combinate met de" +
                    "verbeterde onderlaag met de ACS, zorgt voor de snelste rubbers met de beste controle." +
                    "Air Capsule System(ACS) : De ACS technologie maakt het mogelijk om een enorme snelheid te combineren met een" +
                    "maximale veerkracht, zonder verlies van controle, bij een ultra - lichte rubber." +
                    "Mega Tension : De Mega Tension technologie verhoogt de veerkracht zonder het gewicht van de rubber te veranderen," +
                    "dankzij een sneller herstel van de rubber.",
                    OnSale = true,
                    IsNew = false,
                    ImagePath = "/images/Nittaku-magic-carbon.jpg"
                };
                Rubber product12 = new Rubber
                {
                    Name = "Nittaku Magic Carbon",
                    Price = 32.90,
                    SalesPrice = 28.90,
                    Manufacturer = "Nittaku",
                    Description = "De Carbo rubber heeft een uitzonderlijk katapult-effect en meer snelheid dan de klassieke rubbers," +
                    " met een enorme klank bij het raken van de bal. Het STIGA Air - Capsule systeem(ACS) kende een wereldwijd succes," +
                    "met 5 beroemde rubbers: Magna, Innova Premium, Innova, Innova Ultra Light en Radical. Alle onderlagen van deze " +
                    "rubbers hebben de ACS technologie, wat zorgt voor snelheid en veerkracht, voor een heel lichte rubber, met een " +
                    "uitzonderlijke controle.Vandaag heeft de Research &Development afdeling van STIGA de oplossing gevonden om de " +
                    "toplaag nog te verbeteren. De Mega tension technologie die de toplaag van de rubber verbetert, in combinate met de" +
                    "verbeterde onderlaag met de ACS, zorgt voor de snelste rubbers met de beste controle." +
                    "Air Capsule System(ACS) : De ACS technologie maakt het mogelijk om een enorme snelheid te combineren met een" +
                    "maximale veerkracht, zonder verlies van controle, bij een ultra - lichte rubber." +
                    "Mega Tension : De Mega Tension technologie verhoogt de veerkracht zonder het gewicht van de rubber te veranderen," +
                    "dankzij een sneller herstel van de rubber.",
                    OnSale = true,
                    IsNew = false,
                    ImagePath = "/images/Nittaku-magic-carbon.jpg"
                };
                Houtje product3 = new Houtje
                {
                    Name = "Stiga Arctic Wood",
                    Price = 89.90,
                    Manufacturer = "Stiga",
                    Description = "Het Arctic hout is wat je bekomt als je natuur en wetenschap combineert. Een hout dat geboren is in " +
                    "de natuur en ontworpen met onze know-how en onze ervaring. Voor dit hout hebben we een buitenlaag gevonden van een" +
                    " zeldzame boom die groeit in de koude en diepe wouden van de Arctische cirkel. Door toevoeging van onze gerenommeerde " +
                    "VPS technologie als tweede laag, wat zorgt voor stabiliteit en demping van de trillingen, hebben we met deze Arctic " +
                    "een onvergelijkbaar hout met unieke eigenschappen gecreëerd.",
                    OnSale = false,
                    IsNew = false,
                    ImagePath = "/images/stiga-artic-wood.jpg"
                };
                Houtje product13 = new Houtje
                {
                    Name = "Stiga Arctic Wood",
                    Price = 89.90,
                    SalesPrice = 79.90,
                    Manufacturer = "Stiga",
                    Description = "Het Arctic hout is wat je bekomt als je natuur en wetenschap combineert. Een hout dat geboren is in " +
                    "de natuur en ontworpen met onze know-how en onze ervaring. Voor dit hout hebben we een buitenlaag gevonden van een" +
                    " zeldzame boom die groeit in de koude en diepe wouden van de Arctische cirkel. Door toevoeging van onze gerenommeerde " +
                    "VPS technologie als tweede laag, wat zorgt voor stabiliteit en demping van de trillingen, hebben we met deze Arctic " +
                    "een onvergelijkbaar hout met unieke eigenschappen gecreëerd.",
                    OnSale = true,
                    IsNew = false,
                    ImagePath = "/images/stiga-artic-wood.jpg"
                };
                Houtje product14 = new Houtje
                {
                    Name = "Stiga Arctic Wood",
                    Price = 89.90,
                    Manufacturer = "Stiga",
                    Description = "Het Arctic hout is wat je bekomt als je natuur en wetenschap combineert. Een hout dat geboren is in " +
                    "de natuur en ontworpen met onze know-how en onze ervaring. Voor dit hout hebben we een buitenlaag gevonden van een" +
                    " zeldzame boom die groeit in de koude en diepe wouden van de Arctische cirkel. Door toevoeging van onze gerenommeerde " +
                    "VPS technologie als tweede laag, wat zorgt voor stabiliteit en demping van de trillingen, hebben we met deze Arctic " +
                    "een onvergelijkbaar hout met unieke eigenschappen gecreëerd.",
                    OnSale = false,
                    IsNew = true,
                    ImagePath = "/images/stiga-artic-wood.jpg"
                };
                Houtje product15 = new Houtje
                {
                    Name = "Stiga Arctic Wood",
                    Price = 89.90,
                    Manufacturer = "Stiga",
                    Description = "Het Arctic hout is wat je bekomt als je natuur en wetenschap combineert. Een hout dat geboren is in " +
                    "de natuur en ontworpen met onze know-how en onze ervaring. Voor dit hout hebben we een buitenlaag gevonden van een" +
                    " zeldzame boom die groeit in de koude en diepe wouden van de Arctische cirkel. Door toevoeging van onze gerenommeerde " +
                    "VPS technologie als tweede laag, wat zorgt voor stabiliteit en demping van de trillingen, hebben we met deze Arctic " +
                    "een onvergelijkbaar hout met unieke eigenschappen gecreëerd.",
                    OnSale = false,
                    IsNew = false,
                    ImagePath = "/images/stiga-artic-wood.jpg"
                };
                rubber.Products.Add(product1);
                rubber.Products.Add(product2);
                rubber.Products.Add(product4);
                rubber.Products.Add(product5);
                rubber.Products.Add(product6);
                rubber.Products.Add(product7);
                rubber.Products.Add(product8);
                rubber.Products.Add(product9);
                rubber.Products.Add(product10);
                rubber.Products.Add(product11);
                rubber.Products.Add(product12);
                houtje.Products.Add(product3);
                houtje.Products.Add(product13);
                houtje.Products.Add(product14);
                houtje.Products.Add(product15);
                _context.Categories.Add(rubber);
                _context.Categories.Add(houtje);
                _context.SaveChanges();
            }
        }
    }
}
