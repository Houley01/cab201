using System;
using System.Collections.Generic;
namespace Inheritance_of_SuperHeroes {
    public class Enhanced_Human : SuperHero {
        private int sumOfPowers;
        private bool enhanced = false;
        private List<SuperPower> powerSet = new List<SuperPower>();
        private List<SuperPower> myPowers = new List<SuperPower>();

        public Enhanced_Human(string name, string secretId, List<SuperPower> myPowers) : base(name, secretId) {
            foreach (SuperPower power in myPowers)
            {
                this.myPowers.Add(power);
            }
        }

        public override void SwitchIdentity() {
            base.SwitchIdentity();
            if (enhanced == false) {
                enhanced = true;

                foreach (SuperPower power in myPowers)
                {
                    powerSet.Add(power);
                }
            }
            else {
                enhanced = false;

                powerSet.Clear();
            }
        }

        public override bool HasPower(SuperPower whatPower) {
            bool x = false;

            x = powerSet.Contains(whatPower);

            return x;
        }

        public override int TotalPower() {
            sumOfPowers = 0;

            if (enhanced == true) {
                foreach (int powerCount in powerSet)
                {
                    sumOfPowers += powerCount;
                }
            }

            return sumOfPowers;
        }
    }
}