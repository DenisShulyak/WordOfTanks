using System;

namespace MyClassLib
{
    public class Tank
    {
        private string _tankName;
        private int _lvlAmmunitionTank;
        private int _lvlArmor;
        private int _lvlMobility;

      
        public Tank(string tankName)
        {
            Random rand = new Random();
            int pauseTime = 10; // Без этого , все вызываемые танки имеют одинаковые характеристи(маневренность,броня..)
            _tankName = tankName;
            System.Threading.Thread.Sleep(pauseTime);
            _lvlAmmunitionTank = rand.Next(0, 100);
            System.Threading.Thread.Sleep(pauseTime);
            _lvlArmor = rand.Next(0, 100);
            System.Threading.Thread.Sleep(pauseTime);
            _lvlMobility = rand.Next(0, 100);
            System.Threading.Thread.Sleep(pauseTime);

        }
        public string TankName
        {
            get { return _tankName; }
            set { _tankName = value; }
        }

        public int LvlAmmunitionTank
        {
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



        public static string operator *(Tank obj1, Tank obj2)
        {
            int obj1Points = 0, obj2Points =0;


            if (obj1._lvlAmmunitionTank > obj2._lvlAmmunitionTank)
            {
                obj1Points++;
            }
            else if(obj1._lvlAmmunitionTank < obj2._lvlAmmunitionTank)
            {
                obj2Points++;
            }
            if(obj1._lvlArmor > obj2._lvlArmor){
                obj1Points++;
            }
            else if(obj1._lvlArmor < obj2._lvlArmor)
            {
                obj2Points++;
            }
            if(obj1._lvlMobility > obj2._lvlMobility)
            {
                obj1Points++;
            }
            else if(obj1._lvlMobility < obj2._lvlMobility)
            {
                obj2Points++;
            }

            if(obj1Points > obj2Points)
            {
                return obj1._tankName;
            }
            else if(obj2Points > obj1Points)
            {
                return obj2._tankName;
            }
            else
            {
                return "Ничья";
            }
        }
    }
}
