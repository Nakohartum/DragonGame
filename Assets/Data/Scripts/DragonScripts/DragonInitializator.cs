
using UnityEngine;

namespace DragonFight
{
    public class DragonInitializator
    {
        public DragonInitializator(GameManager gameManager, DragonData dragonData)
        {
            var dragon = Object.Instantiate(dragonData._dragonStruct._dragon,
                dragonData._dragonStruct._spawnPosition, Quaternion.identity);

            var dragonStruct = dragonData._dragonStruct;

            dragonStruct._dragon = dragon;
            
            var dragonModel = new DragonModel(dragonStruct);

            dragonModel._dragonStruct._rigidbody = dragonModel._dragonStruct._dragon.GetComponent<Rigidbody2D>();
            dragonModel._dragonStruct._rigidbody.freezeRotation = true;
            
            gameManager.AddUpdatable(new DragonController(dragonModel));
        }
    }
}