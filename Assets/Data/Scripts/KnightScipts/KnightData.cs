using UnityEngine;

namespace DragonFight
{
    [CreateAssetMenu(fileName = "Knight", menuName = "Knights", order = 1)]
    public class KnightData : ScriptableObject
    {
        [SerializeField] public KnightStruct _knightStruct;
    }
}