using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.Creational_Patterns.Abstract_Factory_Patterns
{
    public class AbstractFactoryPattern
    {
        public void MainMethod()
        {
            // Use windows UI
            UIFactory uIFactory = new WindowsFactory();
            // changed windows to MacOS
            //UIFactory uIFactory = new MacOSFactory();
            Application app = new Application(uIFactory);
            app.RenderUI();

        }
    }

    interface IButton
    {
        void Render();
    }
    interface IScrollBar
    {
        void Scroll();
    }

    // Widnows UI
    class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering windows button");
        }
    }

    class WindowsScrollBar : IScrollBar
    {
        public void Scroll ()
        {
            Console.WriteLine("Scrolling windows bar");
        }
    }

    // MacOs UI

    class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering MacOS button");
        }
    }

    class MacOSScrollBar : IScrollBar
    {
        public void Scroll()
        {
            Console.WriteLine("Scrolling MacOS bar");
        }
    }

    // Abstract factory interface
     interface UIFactory
    {
        IButton CreateButton();
        IScrollBar CreateScroll();
    }

    // Windows Factory

    class WindowsFactory : UIFactory
    {
        public IButton CreateButton()
        {
           return new WindowsButton();
        }

        public IScrollBar CreateScroll()
        {
            return new WindowsScrollBar();
        }
    }

    // MacOs Factory
    class MacOSFactory : UIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public IScrollBar CreateScroll()
        {
            return new MacOSScrollBar();
        }
    }


    // client code
    class Application
    {
        private IButton button;
        private IScrollBar scrollBar;
        public Application(UIFactory uiFactory)
        {
            button = uiFactory.CreateButton();
            scrollBar = uiFactory.CreateScroll();
        }

        public void RenderUI()
        {
            button.Render();
            scrollBar.Scroll();
        }
    }

    


}
