using UnityEngine;

namespace DragonFight
{
    [CreateAssetMenu(fileName = "Platform", menuName = "Platform", order = 0)]
    public class PlatformData : ScriptableObject
    {
        [SerializeField] public PlatformStruct _towerStruct;
    }
}