/*
 Git - это система контроля версий для файлов и кода.
Это распределенная система, которая позволяет работать с проектом совместно с другими людьми.
Git отслеживает изменения в файлах и позволяет возвращаться к предыдущим версиям,
если это необходимо.

ПКМ на вновь созданной папке -> 
git clone 

Создать Git Extenshn/

Git Init -
git init создает новый репозиторий в текущей директории. 
Он инициализирует пустой git-репозиторий и делает его готовым к приему ваших файлов.
После выполнения этой команды у вас будет локальный репозиторий,
который можно добавить в удаленный репозиторий с помощью git remote add.

git add
git add используется для добавления файлов в индекс. Это означает, что изменения,
которые вы сделали в файле, будут отслеживаться и коммититься при следующей команде git commit.
Вы можете использовать эту команду на отдельных файлах или на целой директории.
commit Fit  Множество коммитов

git commit -m
git commit -m сохраняет изменения в индексе в виде коммита. -m обозначает сообщение коммита,
которое вы можете указать после этой опции. Это сообщение будет отображаться в истории коммитов и
поможет вам и другим понять,
что было изменено в данном коммите.

git push origin
git push origin отправляет коммиты из вашего локального репозитория в удаленный репозиторий.
В данном случае origin - это название удаленного репозитория, которое обычно обозначает удаленный
репозиторий на GitHub. Эта команда необходима,
чтобы поделиться вашими изменениями с другими участниками проекта.

git pull
git pull используется для обновления вашего локального репозитория с удаленного репозитория.
Она объединяет изменения из удаленного репозитория в ваш локальный репозиторий и
применяет их к вашим файлам.


git merge используется для объединения двух веток в одну. Когда вы создаете новую ветку,
она содержит все изменения из основной ветки. Когда вы делаете изменения в новой ветке, 
они не влияют на основную ветку. Чтобы объединить изменения из новой ветки в основную ветку, 
вы можете использовать git merge.

Эта команда сравнивает две ветки и объединяет изменения из одной ветки в другую.
Например, если вы изменили файл в одной ветке, а кто-то другой изменил его в другой ветке,
git merge объединит эти изменения и создаст единую историю изменений.

Как работает git merge:
Сначала git merge сравнивает две ветки, чтобы определить, какие изменения были сделаны в каждой ветке.
Затем git merge создает merge commit, который содержит все изменения из обеих веток.
Наконец, git merge применяет эти изменения к целевой ветке.

c make - для программистов С++
Если вы говорите о команде make в C++, то она используется для автоматизации процесса компиляции проекта. 
make просматривает файл с правилами (обычно он называется Makefile), который описывает, какие файлы нужно скомпилировать и при каких условиях.
Затем make выполняет указанные действия для обновления проекта.

NET Core — это кросс-платформенная среда выполнения для разработки приложений и служб. 
Она позволяет создавать приложения, которые могут работать на разных операционных системах и устройствах,
таких как Windows, Linux и macOS. .NET Core также включает в себя набор инструментов для разработки, таких как компилятор,
отладчик и другие утилиты, которые помогают разработчикам создавать приложения.
 */


namespace _13_11_23_C_Sharp_Git
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Processor processor1 = new Processor("Processor1");
            //Processor processor2 = new Processor("Processor2");
            //GraphicsCard graphicsCard1 = new GraphicsCard("GraphicsCard1");
            //GraphicsCard graphicsCard2 = new GraphicsCard("GraphicsCard2");
            //Cooler<Processor> processorCooler1 = new Cooler<Processor>();
            //Cooler<Processor> processorCooler2 = new Cooler<Processor>();
            //Cooler<GraphicsCard> graphicsCardCooler1 = new Cooler<GraphicsCard>();
            //Cooler<GraphicsCard> graphicsCardCooler2 = new Cooler<GraphicsCard>();

            var system = new ComputerSystem();

            // Создаем компоненты компьютера
            var processor1 = new Processor("Intel Core i7", 50);
            var processor2 = new Processor("AMD Ryzen 5", 60);
            var graphicsCard1 = new GraphicsCard("NVIDIA GeForce GTX 1650", 70);
            var graphicsCard2 = new GraphicsCard("AMD Radeon RX 5700", 80);

            // Создаем охладители для компонентов
            var processorCooler1 = new Cooler<Processor>(processor1);
            var processorCooler2 = new Cooler<Processor>(processor2);
            var graphicsCardCooler1 = new Cooler<GraphicsCard>(graphicsCard1);
            var graphicsCardCooler2 = new Cooler<GraphicsCard>(graphicsCard2);
                        
            system.RegistraitComponent(processorCooler1);
            system.RegistraitComponent(processorCooler2);
            system.RegistraitComponent(graphicsCardCooler1);
            system.RegistraitComponent(graphicsCardCooler2);

            // Задаем начальные температуры компонентов
            processor1.Temperature = 50;
            processor2.Temperature = 60;
            graphicsCard1.Temperature = 70;
            graphicsCard2.Temperature = 80;

            // Задаем определенную температуру для контроля
            system.SetTemperatureForAllComponents(70);

            // Запускаем мониторинг температуры
            system.ShowTemperaturForAllComponents();

            // Выводим информацию о компоненте с наибольшей температурой
            //var getTemperatureMaxTemperature = system.GetTemperatureMaxTemperature();
            //Console.WriteLine($"Компонент с наибольшей температурой: {componentWithMaxTemperature.Name}, {componentWithMaxTemperature.Temperature}°C");
        }
    }
}