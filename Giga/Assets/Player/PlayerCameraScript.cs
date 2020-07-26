using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CoreScripts;

namespace Player
{
    public class PlayerCameraScript : MonoBehaviour
    {
        //Target for which the camera will follow.
        [SerializeField] private Transform target;

        //Conrols how far away the camera is from the target.
        [SerializeField] private float cameraDistanceFromTarget = 5.0f;

        //Controls how close the camera can ever be to the target.
        [SerializeField] private float minDistanceFromTarget = 0.5f;

        //The height the camera is above the target.
        [SerializeField] private float cameraHeight = 1.0f;

        [SerializeField] private float distanceDampening = 10.0f;

        [SerializeField] private float rotationalDampening = 10.0f;

        //Transform of the camera.
        private Transform _myTransform;


        void Awake()
        {
            _myTransform = transform;
        }

        void Start()
        {
            if (target == null)
            {
                GameLogger.warn("No target provided to the PlayerCameraScript.");
                target = new GameObject().transform;
            }
        }

        void LateUpdate()
        {
            //Translate via lerp to newPosition.
            Vector3 newPosition = target.position + (target.rotation * new Vector3(0.0f, 0.0f, -cameraDistanceFromTarget));
            Vector3 currentPosition = Vector3.Lerp(_myTransform.position, newPosition, distanceDampening * Time.deltaTime);

            //Rotate via slerp to newRotation.
            Quaternion newRotation = Quaternion.LookRotation(target.position - _myTransform.position, target.up);
            Quaternion currentRotation = Quaternion.Slerp(_myTransform.rotation, newRotation, rotationalDampening * Time.deltaTime);

            _myTransform.SetPositionAndRotation(currentPosition, currentRotation);
        }

        private void warn(string message)
        {
            GameLogger.warn(message);
        }
    }
}

