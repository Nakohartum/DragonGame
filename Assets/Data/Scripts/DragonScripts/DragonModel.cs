using UnityEngine;

namespace DragonFight
{
    public class DragonModel
    {
        [SerializeField] public DragonStruct _dragonStruct;

        public DragonModel(DragonStruct dragonStruct)
        {
            _dragonStruct = dragonStruct;
        }
    }
}