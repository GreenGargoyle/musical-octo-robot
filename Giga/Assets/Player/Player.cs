using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour, CoreScripts.IDamageable<int>
    {
        [SerializeField] private float walkSpeed = 5.0f;
        [SerializeField] private float sprintSpeed = 10.0f;
        [SerializeField] private int currentHealth = 100;

        [SerializeField] private CoreScripts.HUD.HealthBar healthBar;

        private const string VERTICAL = "Vertical";
        private const string HORIZONTAL = "Horizontal";

        private Transform _myTransform;

        #region UnityMethods
        void Awake()
        {
            _myTransform = transform;
        }
        
        void Update()
        {
            float myCurrentSpeed = isSprinting() ? sprintSpeed : walkSpeed;

            float vertical = UnityEngine.Input.GetAxis(VERTICAL);
            float horizontal = UnityEngine.Input.GetAxis(HORIZONTAL);

            float x = horizontal * myCurrentSpeed * Time.deltaTime;
            float z = vertical * myCurrentSpeed * Time.deltaTime;
            Vector3 movement = new Vector3(x, 0, z);

            _myTransform.position += movement;
        }
        #endregion

        //From the IDamageable interface.
        public void takeDamage(int damage)
        {
            currentHealth -= damage;
            healthBar.setHealth(currentHealth);
        }

        //Checks if the sprint button is being pressed/held.
        public bool isSprinting()
        {
            return UnityEngine.Input.GetButton(CoreScripts.Input.ButtonNames.SPRINT_BUTTON);
        }
    }
}

