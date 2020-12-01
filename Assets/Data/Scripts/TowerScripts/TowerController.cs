using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace DragonFight
{
    public class TowerController : IUpdatable
    {
        #region Fields

        private TowerModel _towerModel;
        private TowerStruct _towerAccessor;

        public event Action OnChange;
        private TowerView _towerView;

        #endregion

        #region Methods

        public TowerController(TowerModel towerModel)
        {
            _towerModel = towerModel;
            _towerAccessor = _towerModel._towerStruct;
            _towerView = _towerAccessor._tower.GetComponent<TowerView>();
            OnChange += _towerView.Changed;
            _towerView.OnDie += Die;
        }

        public void UpdateTick()
        {
            if (_towerAccessor._tower != null)
            {
                _towerAccessor._tower.transform.position += new Vector3(_towerAccessor._speed * -1, 0,0) * 
                                                            Time.deltaTime;

                OnChange?.Invoke();
            }


        }

        public void Die()
        {
            OnChange -= _towerView.Changed;
            _towerView.OnDie -= Die;
            Object.Destroy(_towerAccessor._tower);
        }

        #endregion


    }
}