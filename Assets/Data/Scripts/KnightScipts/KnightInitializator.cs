using UnityEngine;

namespace DragonFight
{
    
    public class KnightInitializator
    {
        private int randomFlip = Random.Range(0, 1);
        public KnightInitializator(GameManager gameManager, KnightData knightData)
        {
            

            var knight = Object.Instantiate(knightData._knightStruct._knight, knightData._knightStruct._spawn,
                Quaternion.identity);

            
           
            
            var knightStruct = knightData._knightStruct;

            knightStruct._knight = knight;
            
            var knightModel = new KnightModel(knightStruct);
            knightModel._knightStruct._spriteRenderer =
                knightModel._knightStruct._knight.GetComponent<SpriteRenderer>();

            if (randomFlip == 1)
            {
                knightModel._knightStruct._spriteRenderer.flipX = true;
            }
            else
            {
                knightModel._knightStruct._spriteRenderer.flipX = false;
            }
            
            gameManager.AddUpdatable(new KnightController(knightModel));
        }
    }
}