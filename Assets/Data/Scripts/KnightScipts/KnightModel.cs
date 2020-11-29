using UnityEngine;

namespace DragonFight
{
    public class KnightModel
    {
        [SerializeField] public KnightStruct _knightStruct;

        public KnightModel(KnightStruct knightStruct)
        {
            _knightStruct = knightStruct;
        }
    }
}