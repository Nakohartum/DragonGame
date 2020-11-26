using UnityEngine;

namespace DragonFight
{
    [CreateAssetMenu(fileName = "Dragon", menuName = "DragonFight", order = 0)]
    public class DragonData : ScriptableObject
    {
        [SerializeField] public DragonStruct _dragonStruct;
    }
}