using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    public abstract class Owner
    {
        public string _owner;
        public string _animalThatIsOwned;

        public Owner(string owner)
        {
            _owner = owner;
        }



        public void TransferOwnership(string owner)
        {
            _owner = owner;
        }


        public void ChangeAnimalOwned(string animal)
        {
            _animalThatIsOwned = animal;
        }

    }
}
