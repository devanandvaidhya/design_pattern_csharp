using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.StructuralPatterns.Decorator_Patterns
{
    public class DecoratorPattern
    {
        public void MainMethod()
        {
            //BasePizza basePizza = new ExtraChees (new SimplePiza());
            //BasePizza basePizza =  new Mashroom(new ExtraChees (new SimplePiza()));
            BasePizza basePizza = new Mashroom(new ExtraChees(new VegdelightPiza()));
            Console.WriteLine(basePizza.Cost());
            Console.WriteLine(basePizza.Description());
        }
    }

    public abstract class BasePizza
    {
        public abstract int Cost();
        public abstract string Description();
    }

    public class SimplePiza : BasePizza
    {
        public override int Cost()
        {
            return 200;
        }

        public override string Description()
        {
            return "Simple Pizza";
        }


    }

    public class VegdelightPiza : BasePizza
    {
        public override int Cost()
        {
            return 120;
        }
        public override string Description()
        {
            return "Vegdelight Pizza";
        }
    }

    public class MargheritaPizza : BasePizza
    {
        public override int Cost()
        {
            return 100;
        }
        public override string Description()
        {
            return "Margherita Pizza";
        }
    }

    //  decorate the class for pizza

    public abstract class PizzaDecorator : BasePizza
    {


    }


    public class ExtraChees : PizzaDecorator
    {
        BasePizza basePizza;
        public ExtraChees(BasePizza basePizza)
        {
            this.basePizza = basePizza;
        }

        public override int Cost()
        {
            return basePizza.Cost() + 50;
        }
        public override string Description()
        {
            return basePizza.Description() + " , ExtraChees Pizza";
        }
    }


    public class Mashroom : PizzaDecorator
    {
        BasePizza basePizza;
        public Mashroom(BasePizza basePizza)
        {
            this.basePizza = basePizza;
        }

        public override int Cost()
        {
            return basePizza.Cost() + 150;
        }

        public override string Description()
        {
            return basePizza.Description()+ " , Mashroom Pizza";
        }
    }
}
