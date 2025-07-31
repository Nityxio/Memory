using UnityEngine;

namespace Source.ScriptableObjects
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Game/Player/Config")]
    public class PlayerConfig : ScriptableObject
    {
        public float sensitivity;
        public float speed;
    }
}