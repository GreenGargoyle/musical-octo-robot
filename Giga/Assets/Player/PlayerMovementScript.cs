using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerMovementScript : MonoBehaviour
    {
        [SerializeField] private float speed = 10.0f;
        [SerializeField] private float rotationSpeed = 100.0f;

        private const string VERTICAL = "Vertical";
        private const string HORIZONTAL = "Horizontal";

        private Transform _myTransform;


        void Awake()
        {
            _myTransform = transform;
        }
        
        void Update()
        {
            float translation = Input.GetAxis(VERTICAL) * speed * Time.deltaTime;
            float rotation = Input.GetAxis(HORIZONTAL) * rotationSpeed * Time.deltaTime;

            Vector3 currentPosition = _myTransform.position;
            Quaternion currentRotation = _myTransform.rotation;

            Vector3 inputPosition = Vector3.forward * translation;
            Quaternion inputRotation = Quaternion.Euler(Vector3.up * rotation);

            Vector3 newPosition = currentPosition + (currentRotation * inputPosition);
            Quaternion newRotation = currentRotation * inputRotation;

            _myTransform.SetPositionAndRotation(newPosition, newRotation);
        }
    }
}

