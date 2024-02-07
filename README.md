<h3>Интерфейсы</h3>

Цель:
В этом ДЗ вы научитесь явному вызову интерфейсов, их наследованию и реализации методов по умолчанию.

Описание/Пошаговая инструкция выполнения домашнего задания:

<ol>
<li>Создать интерфейс IRobot с публичным методами string GetInfo() и List GetComponents(), а также string GetRobotType() с дефолтной реализацией, возвращающей значение "I am a simple robot.".</li>
<li>Создать интерфейс IChargeable с методами void Charge() и string GetInfo().</li>
<li>Создать интерфейс IFlyingRobot как наследник IRobot с дефолтной реализацией GetRobotType(), возвращающей строку "I am a flying robot.".</li>
<li>Создать класс Quadcopter, наследующий IFlyingRobot и IChargeable. В нём создать список компонентов List _components = new List {"rotor1","rotor2","rotor3","rotor4"} и возвращать его из метода GetComponents().</li>
<li>Реализовать метод Charge() должен писать в консоль "Charging..." и через 3 секунды "Charged!". Ожидание в 3 секунды реализовать через Thread.Sleep(3000).</li>
<li>Реализовать все методы интерфейсов в классах. До этого пункта достаточно "throw new NotImplementedException();"</li>
</ol>
