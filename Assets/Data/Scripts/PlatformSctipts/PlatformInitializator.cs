
using UnityEngine;

namespace DragonFight
{
    public class PlatformInitializator
    {
        public PlatformInitializator(GameManager gameManager, PlatformData towerData)
        {
            var tower = Object.Instantiate(towerData._towerStruct._tower, towerData._towerStruct._spawnPosition,
                Quaternion.identity);

            var towerStruct = towerData._towerStruct;

            towerStruct._tower = tower;

            var towerModel = new PlatformModel(towerStruct);

            gameManager.AddUpdatable(new PlatformContoller(towerModel));
        }
    }
}