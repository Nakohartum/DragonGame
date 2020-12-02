﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonFight
{
    [Serializable]

    public struct PlatformStruct
    {
        public GameObject _tower;
        public Vector3 _spawnPosition;
        public float _speed;
    }
}