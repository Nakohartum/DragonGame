using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonFight
{
    [Serializable]
    public struct DragonStruct
    {
        public Sprite _dragonSkin;
        public GameObject _dragon;
        public float _speed;
        public float _force;
        public Rigidbody2D _rigidbody;
        public Vector3 _spawnPosition;
    }
}

