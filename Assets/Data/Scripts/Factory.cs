using System.Collections.Generic;

namespace DragonFight
{
    public class Factory
    {
        private Dictionary<string, KnightInitializator> mobFactory;
        
        public void Init(KnightData descriptions, GameManager manager)
        {
            mobFactory = new Dictionary<string, KnightInitializator>()
            {
                {"ogre", new KnightInitializator(manager, descriptions)},
                
            };

        }

        public KnightInitializator CreateMobModel(string nameMob)
        {
            return mobFactory[nameMob];
        }
    }
}