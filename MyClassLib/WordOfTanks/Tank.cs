using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLib.WordOfTanks
{
    class Tank
    {
        Random rand = new Random();
        private string _tankName;
        private int _lvlAmmunitionTank;
        private int _lvlArmor;
        private int _lvlMobility;

        public Tank()
            {
            _lvlAmmunitionTank = rand.Next(0,100);
            _lvlArmor = rand.Next(0, 100);
            _lvlMobility = rand.Next(0, 100);

        }
        public Tank(string tankName)
        {
            _tankName = tankName;
            _lvlAmmunitionTank = rand.Next(0, 100);
            _lvlArmor = rand.Next(0, 100);
            _lvlMobility = rand.Next(0, 100);

        }
        public string TankName
        {
            get { return _tankName; }
            set { _tankName = value; }
        }

        public int LvlAmmunitionTank {
            get { return _lvlAmmunitionTank; }
            set { _lvlAmmunitionTank = value; }
        }
        public int LvlArmor
        {
            get { return _lvlArmor; }
            set { _lvlArmor = value; }
        }
        public int LvlMobility
        {
            get { return _lvlMobility; }
            set { _lvlMobility = value; }
        }

        

        public static Tank operator *(Tank obj1, Tank obj2)
        {
            Tank obj3 = new Tank();
            obj3._lvlAmmunitionTank = obj1._lvlAmmunitionTank * obj2._lvlAmmunitionTank;
            return obj3;
        }

    }
}
