using UnityEngine;

namespace DragonFight
{
    [CreateAssetMenu(fileName = "DragonFight", menuName = "Knights", order = 1)]
    public class KnightData : ScriptableObject
    {
        [SerializeField] public KnightStruct _knightStruct;
    }
}