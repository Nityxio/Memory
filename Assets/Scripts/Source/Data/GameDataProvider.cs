using Source.Constants;
using Source.ScriptableObjects;
using UnityEngine;

namespace Source.Data
{
    public static class GameDataProvider
    {
        private static PlayerConfig _playerConfig;

        public static PlayerConfig Player
        {
            get
            {
                if (_playerConfig == null)
                {
                    _playerConfig = Resources.Load<PlayerConfig>(ScriptableObjectsConstants.PlayerConfig);
                    if (_playerConfig == null)
                        Debug.LogError("PlayerConfig.asset not found in Resources");
                }

                return _playerConfig;
            }
        }
    }
}