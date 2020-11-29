using System;
using System.Collections.Generic;

namespace DragonFight
{
    public class Factory
    {
        private Dictionary<string,  KnightModel> knightFactory;
        public void Init(KnightData descriptions)
        {
            knightFactory = new Dictionary<string, KnightModel>()
            {
                {"Knight", new KnightModel(descriptions._knightStruct)},
                {"troll", new KnightModel(descriptions._knightStruct)}
            };

        }

        public KnightModel CreateMobModel(string nameMob)
        {
            return knightFactory[nameMob];
        }
    }
}