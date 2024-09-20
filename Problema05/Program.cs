using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video(100,"Video Tiktok", 15, 100,3.5);
            Video.listar(video1);
            Console.WriteLine("---- AUMENTO DE EN 5.50 AL PRECIO DEL VIDEO ----\n");
            video1.PrecioSoles += 5.50;
            Video.listar(video1);
            Console.ReadKey();
        }
    }
}
