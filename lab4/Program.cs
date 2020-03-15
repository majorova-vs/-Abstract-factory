using System;

namespace lab4
{
    interface IButton
    {
        void Paint();
    }

    interface ICheckBox
    {
        void Paint();
    }
    /**
     * Абстрактная фабрика знает обо всех абстрактных типах
     * продуктов.
     */
    interface IGUIFactory {
        IButton CreateButton();
        ICheckBox CreateCheckbox();
    }
    class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("windows style button");
        }
    }

    class WinCheckbox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("windows style checkbox");
        }
    }

    class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("mac style button");
        }
    }

    class MacCheckbox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("mac style checkbox");
        }
    }
    class LinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("linux style button");
        }
    }

    class LinCheckbox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("linux style checkbox");
        }
    }

    /** Каждая конкретная фабрика знает и создаёт только продукты
    *своей вариации.
    */
    class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }
        public ICheckBox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
    class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }
        public ICheckBox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
    class LinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LinButton();
        }
        public ICheckBox CreateCheckbox()
        {
            return new LinCheckbox();
        }
    }

    class Application
    {
        private IGUIFactory Factory { get; set; }
        private IButton Button { get; set; }
        private ICheckBox CheckBox { get; set; }
        public Application(IGUIFactory factory)
        {
            this.Factory = factory;
        }
        public void CreateUI()
        {
            this.Button = Factory.CreateButton();
            this.CheckBox = Factory.CreateCheckbox();
        }

        public void Paint()
        {
            Button.Paint();
            CheckBox.Paint();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IGUIFactory factory;
            Console.WriteLine("Input an OS: ");
            string OS = Console.ReadLine();
            if (OS.ToUpper() == "WINDOWS")
            {
                factory = new WinFactory();
            }
            else if (OS.ToUpper() == "MACOS")
            {
                factory = new MacFactory();
            }
            else if (OS.ToUpper() == "LINUX")
            {
                factory = new LinFactory();
            }
            else throw new Exception("Uknown OS");

            Application application = new Application(factory);
            application.CreateUI();
            application.Paint();
        }
    }
}
