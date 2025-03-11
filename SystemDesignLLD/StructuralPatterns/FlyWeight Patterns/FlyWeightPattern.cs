using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.StructuralPatterns.FlyWeight_Patterns
{
    public class FlyWeightPattern
    {
        public  void MainMethod()
        {
            // 5 Red Bullet Objects
            for (int i = 0; i < 5; i++)
            {
                Bullet bullet = new Bullet("Red", i * 10, i * 12, 5);
            }
            // 5 Green Bullet Objects
            for (int i = 0; i < 5; i++)
            {
                Bullet bullet = new Bullet("Green", i * 10, i * 12, 5);
            }

        }
    }
    //Flyweight Class
    public class BulletType
    {
        private string color; //Intrinsic Property

        public BulletType(string color)
        {
            this.color = color;
            Console.WriteLine("Creating bulletType with color " + color);
        }
    }

    class Bullet
    {
        private BulletType type; // Intrinsic property shared by all bullets
        private int x, y;      // Extrinsic properties unique to each bullet
        private int velocity;

        public Bullet(string color, int x, int y, int velocity)
        {
            this.type = BulletTypeFactory.getBulletType(color);
            this.x = x;
            this.y = y;
            this.velocity = velocity;
            Console.WriteLine("Creating bullet at (" + x + ", " + y + ") with velocity " + velocity);
        }
        public void display()
        {
            Console.WriteLine("Bullet at (" + x + ", " + y + ") moving at velocity " + velocity);
        }
    }

    public class BulletTypeFactory
    {
        private static readonly Dictionary<string, BulletType> bulletTypes = new Dictionary<string, BulletType>();

        public static BulletType getBulletType(String color)
        {
            if (!bulletTypes.ContainsKey(color))
            {
                bulletTypes.Add(color, new BulletType(color));
            }
            return bulletTypes[color];
        }
    }

}
