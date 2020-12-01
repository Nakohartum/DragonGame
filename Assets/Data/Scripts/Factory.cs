using System.Collections.Generic;

namespace DragonFight
{
    public class Factory
    {
        private Dictionary<string, KnightInitializator> mobFactory;
        private Dictionary<string, TowerInitializator> towerFactory;
        
        public void Init(KnightData descriptions, GameManager manager)
        {
            mobFactory = new Dictionary<string, KnightInitializator>()
            {
                {"ogre", new KnightInitializator(manager, descriptions)},
                
            };
            
        }
        
        public void Init(GameManager manager, TowerData towerData)
        {
            
            towerFactory = new Dictionary<string, TowerInitializator>()
            {
                {"tower", new TowerInitializator(manager, towerData)},
                
            };
        }

        public KnightInitializator CreateMobModel(string nameMob)
        {
            return mobFactory[nameMob];
        }
        
        public TowerInitializator CreateTower(string nameMob)
        {
            return towerFactory[nameMob];
        }
    }
}