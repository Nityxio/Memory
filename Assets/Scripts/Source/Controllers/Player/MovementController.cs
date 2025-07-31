using Source.Constants;
using Source.Data;
using UnityEngine;

namespace Source.Controllers.Player
{
    public class MovementController : MonoBehaviour
    {
        private Rigidbody _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();

            if (_rb == null)
                Debug.LogError("Rigidbody not found, add he on player");
        }

        private void FixedUpdate()
        {
            var moveX = Input.GetAxis(PlayerMovementConstants.HorizontalMovement);
            var moveZ = Input.GetAxis(PlayerMovementConstants.VerticalMovement);

            var speed = GameDataProvider.Player.speed;

            var move = transform.right * moveX + transform.forward * moveZ;
            move = move.normalized * speed;

            _rb.MovePosition(transform.position + move * Time.fixedDeltaTime);
        }
    }
}