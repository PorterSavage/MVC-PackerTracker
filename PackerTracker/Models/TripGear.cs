using System.Collections.Generic;

namespace PackerTracker.Models
{
    public class TripGear
    {
        private string _destination;
        private string _clothes;
        private string _food;
        private int _money;

        public TripGear(string destination, string clothes, string food, int money)
        {
            _destination = destination;
            _clothes = clothes;
            _food = food;
            _money = money;
        }

        public string GetDestination()
        {
            return _destination;
        }

        public void SetDestination(string newDestination)
        {
            _destination = newDestination;
        }

        public string GetClothes()
        {
            return _clothes;
        }

        public void SetClothes(string newClothes)
        {
            _clothes = newClothes;
        }

        public string GetFood()
        {
            return _food;
        }

        public void SetFood(string newFood)
        {
            _food = newFood;
        }

        public int GetMoney()
        {
            return _money;
        }

        public void SetMoney(int newMoney)
        {
            _money = newMoney;
        }
    }
}