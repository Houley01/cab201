using System;
using System.Collections.Generic;

namespace Inheritance_of_SuperHeroes {
    public class Super_Human : SuperHero {
        private int sumOfPowers;
        private List<SuperPower> powerSet = new List<SuperPower>();

        public Super_Human(string name, string secretId, List<SuperPower> myPowers) : base(name, secretId)
        {
            foreach (SuperPower power in myPowers) {
                powerSet.Add(power);
            }

        }

        public override bool HasPower(SuperPower whatPower)
        {
            bool x = false;

            x = powerSet.Contains(whatPower);

            return x;
        }

        public override int TotalPower() {
            sumOfPowers = 0;

            foreach (int powerCount in powerSet)
            {
                sumOfPowers += powerCount;
            }

            return sumOfPowers;
        }

        public void AddSuperPower(SuperPower newPower) {
            powerSet.Add(newPower);
        }

        public void LoseSinglePower(SuperPower power) {
            powerSet.Remove(power);
        }

        public void LoseAllSuperPowers() {
            powerSet.Clear();
        }
    }
}
