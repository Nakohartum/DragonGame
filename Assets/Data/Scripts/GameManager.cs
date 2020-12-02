using System;
using System.Collections;
using System.Collections.Generic;
using DragonFight;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace DragonFight
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private DragonData _dragonData;
        [SerializeField] private KnightData _knightData;
        [SerializeField] private TowerData _towerData;
        [SerializeField] private PlatformData platformData;
        private List<IUpdatable> _updatables = new List<IUpdatable>();
        
        private Factory _factory;

        private void Start()
        {
            new InitializatorController(this, _dragonData, _knightData);
            _factory = new Factory();
            _factory.Init(_knightData, this);

            StartCoroutine("TestCoroutine");
            StartCoroutine("TileSpawner");
            StartCoroutine("TowerSpawner");
        }

        private void Update()
        {
            
            for (int i = 0; i < _updatables.Count; i++)
            {
                _updatables[i].UpdateTick();
                
            }
        }

        IEnumerator TileSpawner()
        {
            while (true)
            {
                yield return new WaitForSeconds(2);
                _factory.Init(this, platformData);
            }
        }
        
        IEnumerator TowerSpawner()
        {
            while(true)
            {
                
                yield return new WaitForSeconds(Random.Range(6, 20));
                _factory.Init(this, _towerData);
            }
        }

        IEnumerator TestCoroutine()
        {
            while(true)
            {
                
                yield return new WaitForSeconds(6);
                _factory.Init(_knightData, this);
            }
        }
        
        public void AddUpdatable(IUpdatable _updatable)
        {
            _updatables.Add(_updatable);
        }

        public void PauseTime()
        {
            Time.timeScale = 0;
        }
        
        public void ResetTime()
        {
            Time.timeScale = 1;
        }
    }
}