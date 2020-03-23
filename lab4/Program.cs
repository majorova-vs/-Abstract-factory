using System;

namespace lab4
{
    /// <summary>
    /// Настройка вида кнопок/ярлыков
    /// </summary>
    interface IButton
    {
        void Paint();
    }
    /// <summary>
    /// Настройка вида чекбоксов
    /// </summary>
    interface ICheckBox
    {
        void Paint();
    }
    /// <summary>
    /// Выбор временной зоны
    /// </summary>
    interface ITimeZone
    {
        void Set();
    }
    /// <summary>
    /// Выбор языка
    /// </summary>
    interface ILanguage
    {
        void Set();
    }
    /// <summary>
    /// Выбор региона
    /// </summary>
    interface IRegion
    {
        void Set();
    }
    /// <summary>
    /// Задание клавиш переключения раскладки клавиатуры 
    /// </summary>
    interface ISwkeyblay
    {
        void Set();
    }
    /// <summary>
    /// Создание пользователя
    /// </summary>
    interface IUser
    {
        void Create();
    }
    /// <summary>
    /// Настройка внешних устройств 
    /// </summary>
    interface IDevice
    {
        void Set();
    }
    /// <summary>
    /// Настройка жёсткого диска (разбивание на разделы)
    /// </summary>
    interface IHardDisk
    {
        void Setup();
    }
    /// <summary>
    /// Абстрактная фабрика знает обо всех абстрактных типах
    /// настроек.
    /// </summary>
    interface IGUIFactory {
        IButton CreateButton();
        ICheckBox CreateCheckbox();
        ITimeZone SetTimeZone();
        ILanguage SetLanguage();
        IRegion SetRegion();
        ISwkeyblay SetSwKeyL();
        IUser CreateUser();
        IDevice SetDevice();
        IHardDisk SetupHardDisk();

    }
    /// <summary>
    /// Жёсткий диск Виндоус
    /// </summary>
    class WinHardDisk : IHardDisk
    {
        public void Setup() { }
    }
    /// <summary>
    /// Внешние девайсы
    /// </summary>
    class WinDevice : IDevice
    {
        public void Set() { }
    }
    /// <summary>
    /// Новый пользователь 
    /// </summary>
    class WinUser : IUser
    {
        public void Create() { Console.WriteLine("User is created"); }
    }
    /// <summary>
    /// Задание клавиш переключения раскладки клавиатуры 
    /// </summary>
    class WinSwKeybl : ISwkeyblay
    {
        public void Set() { }
    }
    /// <summary>
    /// Выбор языка
    /// </summary>
    class WinLanguage : ILanguage
    {
        public void Set()
        {
            Console.WriteLine("Language selected");
        }
    }
    /// <summary>
    /// Выбор региона
    /// </summary>
    class WinRegion : IRegion
    {
        public void Set() {}
    }
    /// <summary>
    /// Выбор временной зоны
    /// </summary>
    class WinTimeZone : ITimeZone
    {
        public void Set()
        {
            Console.WriteLine("Windows time zone setting");
        }
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

    class MacHardDisk : IHardDisk
    {
        public void Setup() { }
    }
    class MacDevice : IDevice
    {
        public void Set() { }
    }
    class MacUser : IUser
    {
        public void Create() { Console.WriteLine("User is created"); }
    }
    class MacSwKeybl : ISwkeyblay
    {
        public void Set() { }
    }
    class MacLanguage : ILanguage
    {
        public void Set()
        {
            Console.WriteLine("Language selected");
        }
    }
    class MacRegion : IRegion
    {
        public void Set() { }
    }
    class MacTimeZone : ITimeZone
    {
        public void Set()
        {
            Console.WriteLine("MacOS time zone setting");
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

    class LinHardDisk : IHardDisk
    {
        public void Setup() { }
    }
    class LinDevice : IDevice
    {
        public void Set() { }
    }
    class LinUser : IUser
    {
        public void Create() { Console.WriteLine("User is created"); }
    }
    class LinSwKeybl : ISwkeyblay
    {
        public void Set() { }
    }
    class LinLanguage : ILanguage
    {
        public void Set()
        {
            Console.WriteLine("Language selected");
        }
    }
    class LinRegion : IRegion
    {
        public void Set() { }
    }
    class LinTimeZone : ITimeZone
    {
        public void Set()
        {
            Console.WriteLine("Linux time zone setting");
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

    /// <summary>
    /// Каждая конкретная фабрика знает и создаёт только настройки
    /// своей вариации.
    /// </summary> 

    /// <summary>
    /// Фабрика Windows
    /// </summary> 
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
        public ILanguage SetLanguage()
        {
            return new WinLanguage();
        }
        public ITimeZone SetTimeZone()
        {
            return new WinTimeZone();
        }
        public IRegion SetRegion()
        {
            return new WinRegion();
        }
        public ISwkeyblay SetSwKeyL()
        {
            return new WinSwKeybl();
        }
        public IUser CreateUser()
        {
            return new WinUser();
        }
        public IDevice SetDevice()
        {
            return new WinDevice();
        }
        public IHardDisk SetupHardDisk()
        {
            return new WinHardDisk();
        }
    }

    /// <summary>
    /// Фабрика MacOS
    /// </summary> 
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
        public ILanguage SetLanguage()
        {
            return new MacLanguage();
        }
        public ITimeZone SetTimeZone()
        {
            return new MacTimeZone();
        }
        public IRegion SetRegion()
        {
            return new MacRegion();
        }
        public ISwkeyblay SetSwKeyL()
        {
            return new MacSwKeybl();
        }
        public IUser CreateUser()
        {
            return new MacUser();
        }
        public IDevice SetDevice()
        {
            return new MacDevice();
        }
        public IHardDisk SetupHardDisk()
        {
            return new MacHardDisk();
        }
    }

    /// <summary>
    /// Фабрика Linux
    /// </summary> 
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
        public ILanguage SetLanguage()
        {
            return new LinLanguage();
        }
        public ITimeZone SetTimeZone()
        {
            return new LinTimeZone();
        }
        public IRegion SetRegion()
        {
            return new LinRegion();
        }
        public ISwkeyblay SetSwKeyL()
        {
            return new LinSwKeybl();
        }
        public IUser CreateUser()
        {
            return new LinUser();
        }
        public IDevice SetDevice()
        {
            return new LinDevice();
        }
        public IHardDisk SetupHardDisk()
        {
            return new LinHardDisk();
        }
    }

    /// <summary>
    /// Часть приложения, отвечающая за настройку параметров системы
    /// </summary> 
    class Application
    {
        private IGUIFactory Factory { get; set; }
        private IButton Button { get; set; }
        private ICheckBox CheckBox { get; set; }
        private ILanguage Language { get; set; }
        private ITimeZone TimeZone { get; set; }
        private IRegion Region { get; set; }
        private ISwkeyblay Swkeyblay { get; set; }
        private IUser User { get; set; }
        private IDevice Device { get; set; }
        private IHardDisk HardDisk { get; set; }
        public Application(IGUIFactory factory)
        {
            this.Factory = factory;
        }
        public void CreateUI()
        {
            this.Button = Factory.CreateButton();
            this.CheckBox = Factory.CreateCheckbox();
        }

        public void RegionSetting()
        {
            this.Region = Factory.SetRegion();
            Region.Set();
            this.TimeZone = Factory.SetTimeZone();
            TimeZone.Set();
            this.Language = Factory.SetLanguage();
            Language.Set();
        }

        public void CreateUser()
        {
            this.User = Factory.CreateUser();
            User.Create();
        }

        public void DeviceSetting()
        {
            this.Device = Factory.SetDevice();
            this.HardDisk = Factory.SetupHardDisk();
            this.Swkeyblay = Factory.SetSwKeyL();
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
            application.CreateUser();
            application.RegionSetting();
            application.DeviceSetting();
            application.CreateUI();
            application.Paint();
        }
    }
}
