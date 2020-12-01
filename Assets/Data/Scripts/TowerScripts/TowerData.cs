using UnityEngine;

namespace DragonFight
{
    [CreateAssetMenu(fileName = "DragonFight", menuName = "Tower", order = 0)]
    public class TowerData : ScriptableObject
    {
        [SerializeField] public TowerStruct _towerStruct;
    }
}