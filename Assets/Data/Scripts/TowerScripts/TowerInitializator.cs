using UnityEngine;

namespace DragonFight
{
    public class TowerInitializator
    {
        public TowerInitializator(GameManager gameManager, TowerData towerData)
        {
            var tower = Object.Instantiate(towerData._towerStruct._tower, towerData._towerStruct._spawnPosition,
                Quaternion.identity);

            var towerStruct = towerData._towerStruct;

            towerStruct._tower = tower;

            var towerModel = new TowerModel(towerStruct);

            gameManager.AddUpdatable(new TowerController(towerModel));
        }
    }
}