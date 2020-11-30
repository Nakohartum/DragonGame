using System;
using System.Collections;
using System.Collections.Generic;
using DragonFight;
using UnityEngine;
using Object = UnityEngine.Object;

namespace DragonFight
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private DragonData _dragonData;
        [SerializeField] private KnightData _knightData;
        private List<IUpdatable> _updatables = new List<IUpdatable>();
        private Factory _factory;
        

        private void Start()
        {
            new InitializatorController(this, _dragonData, _knightData);
            _factory = new Factory();
            _factory.Init(_knightData, this);
            StartCoroutine("TestCoroutine");

        }

        private void Update()
        {
            
            for (int i = 0; i < _updatables.Count; i++)
            {
                _updatables[i].UpdateTick();
                
            }
        }

        IEnumerator TestCoroutine()
        {
            while(true)
            {
                yield return new WaitForSeconds(5);
                _factory.Init(_knightData, this);
            }
        }
        
        public void AddUpdatable(IUpdatable _updatable)
        {
            _updatables.Add(_updatable);
        }
        
        
    }
}