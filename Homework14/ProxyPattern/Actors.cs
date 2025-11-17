using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface MainActorTasks
    {
        public void SimpleScene();
    }
    public interface StuntmanTanks
    {
        public void HardScene();
    }
    public class MainActor : MainActorTasks
    {
        public void SimpleScene()
        {
            Console.WriteLine("Main Actor plays Simple Scene.");
        }

    }
    public class Stuntman : StuntmanTanks
    {
        public void HardScene()
        {
            Console.WriteLine("stuntman plays Hard and dangerous scene");
        }
    }
}
