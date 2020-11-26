using System;

namespace Solid2
{
    interface IDrivable
    {
        void Drive(long miles);
    }

    class Car : IDrivable
    {
        public void Drive(long miles)
        {
            Console.WriteLine("I am driven to {0} miles away ...", miles);
        }
    }

    class FlyingCar : IDrivable
    {
        private bool _isRocketLaunched;

        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Launch the rocket first or this flying car can not get driven.");
            }
            else
            {
                Console.WriteLine("I am flying to {0} miles away ...", miles);
            }
        }
        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }

    class SpaceShip : IDrivable
    {
        private bool _isRocketLaunched;

        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Spaceship can't leave Earth if its rocket is not launched !");
            }
            else
            {
                Console.WriteLine("The spaceship is going {0} miles away", miles);
            }
        }
        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    }
}
