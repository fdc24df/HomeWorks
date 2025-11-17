using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14
{
    public interface IChair { void SitOn(); string Style { get; } }
    public interface ISofa { void LieOn(); string Style { get; } }
    public interface ICoffeeTable { void PlaceCoffee(); string Style { get; } }

    
    public class ArtDecoChair : IChair { public string Style => "Art Deco"; public void SitOn() => Console.WriteLine("   → Sitting on a luxurious Art Deco chair"); }
    public class ArtDecoSofa : ISofa { public string Style => "Art Deco"; public void LieOn() => Console.WriteLine("   → Lying on a glamorous Art Deco sofa"); }
    public class ArtDecoCoffeeTable : ICoffeeTable { public string Style => "Art Deco"; public void PlaceCoffee() => Console.WriteLine("   → Placing coffee on a mirrored Art Deco table"); }

   
    public class VictorianChair : IChair { public string Style => "Victorian"; public void SitOn() => Console.WriteLine("   → Sitting on a royal Victorian armchair"); }
    public class VictorianSofa : ISofa { public string Style => "Victorian"; public void LieOn() => Console.WriteLine("   → Lying on a plush Victorian sofa"); }
    public class VictorianCoffeeTable : ICoffeeTable { public string Style => "Victorian"; public void PlaceCoffee() => Console.WriteLine("   → Placing coffee on a carved Victorian table"); }

    
    public class ModernChair : IChair { public string Style => "Modern"; public void SitOn() => Console.WriteLine("   → Sitting on a minimalist Modern chair"); }
    public class ModernSofa : ISofa { public string Style => "Modern"; public void LieOn() => Console.WriteLine("   → Lying on a sleek Modern sofa"); }
    public class ModernCoffeeTable : ICoffeeTable { public string Style => "Modern"; public void PlaceCoffee() => Console.WriteLine("   → Placing coffee on a clean Modern table"); }

    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }

    public class ArtDecoFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ArtDecoChair();
        public ISofa CreateSofa() => new ArtDecoSofa();
        public ICoffeeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();
    }

    public class VictorianFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VictorianChair();
        public ISofa CreateSofa() => new VictorianSofa();
        public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();
    }

    public class ModernFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();
        public ISofa CreateSofa() => new ModernSofa();
        public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();
    }
}
