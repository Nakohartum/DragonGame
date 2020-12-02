using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace DragonFight
{
    public class PlatformContoller : IUpdatable
    {
        #region Fields

        private PlatformModel _towerModel;
        private PlatformStruct _towerAccessor;

        public event Action OnChange;
        private PlatformView _towerView;

        #endregion

        #region Methods

        public PlatformContoller(PlatformModel towerModel)
        {
            _towerModel = towerModel;
            _towerAccessor = _towerModel._towerStruct;
            _towerView = _towerAccessor._tower.GetComponent<PlatformView>();
            
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
            
            _towerView.OnDie -= Die;
            Object.Destroy(_towerAccessor._tower);
        }

        #endregion


    }
}