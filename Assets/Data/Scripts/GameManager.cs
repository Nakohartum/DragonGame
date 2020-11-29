﻿using System;
using System.Collections.Generic;
using DragonFight;
using UnityEngine;

namespace DragonFight
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private DragonData _dragonData;
        [SerializeField] private KnightData _knightData;
        private List<IUpdatable> _updatables = new List<IUpdatable>();
        

        private void Start()
        {
            new InitializatorController(this, _dragonData, _knightData);
        }

        private void Update()
        {
            for (int i = 0; i < _updatables.Count; i++)
            {
                _updatables[i].UpdateTick();
                
            }
        }

        public void AddUpdatable(IUpdatable _updatable)
        {
            _updatables.Add(_updatable);
        }
    }
}