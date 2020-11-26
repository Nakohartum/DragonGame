using DragonFight;

namespace Data.Scripts
{
    public class InitializatorController
    {
        public InitializatorController(GameManager gameManager, DragonData dragonData)
        {
            new DragonInitializator(gameManager, dragonData);
        }
    }
}