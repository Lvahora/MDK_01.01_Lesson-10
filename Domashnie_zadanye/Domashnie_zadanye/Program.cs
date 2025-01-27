using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public interface ISelectable
    {
        void OnSelect();
    }
    public interface IUpdatable
    {
        void Refresh();
    }
    class Screen : ISelectable, IUpdatable
    {

        public void OnSelect()
        {
            Console.WriteLine("На экран было нажато");
        }

        public void Refresh()
        {
            Console.WriteLine("Обновился экран");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.OnSelect();
            screen.Refresh();

            Console.ReadKey();
        }
    }
}