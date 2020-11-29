using DragonFight;

namespace DragonFight
{
    public class InitializatorController
    {
        public InitializatorController(GameManager gameManager, DragonData dragonData, KnightData knightData)
        {
            new DragonInitializator(gameManager, dragonData);
            new KnightInitializator(gameManager, knightData);
            new KnightInitializator(gameManager, knightData);
            new KnightInitializator(gameManager, knightData);
            new KnightInitializator(gameManager, knightData);
        }
    }
}