using Source.Constants;
using Source.Data;
using UnityEngine;

namespace Source.Controllers.Camera
{
    public class FirstPersonLook : MonoBehaviour
    {
        [SerializeField] private Transform playerBody;

        private float _xRotation;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            var mouseSensitivity = GameDataProvider.Player.sensitivity;

            var mouseX = Input.GetAxis(PlayerLookConstants.HorizontalLook) * mouseSensitivity * Time.deltaTime;
            var mouseY = Input.GetAxis(PlayerLookConstants.VerticalLook) * mouseSensitivity * Time.deltaTime;

            Debug.Log("mouseX: " + mouseX);

            _xRotation -= mouseY;
            _xRotation = Mathf.Clamp(_xRotation, -90, 90f);

            transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);

            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}