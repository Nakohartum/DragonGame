using UnityEngine;

namespace DragonFight
{
    
    [CreateAssetMenu(fileName = "DragonFight", menuName = "Dragon", order = 0)]
    public class DragonData : ScriptableObject
    {
        [SerializeField] public DragonStruct _dragonStruct;
    }
}