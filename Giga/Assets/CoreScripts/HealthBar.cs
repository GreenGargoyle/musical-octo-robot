﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HUD
{
	public class HealthBar : MonoBehaviour
	{
        [SerializeField] private Slider slider;
        [SerializeField] private Gradient gradient;
        [SerializeField] private Image fill;

        public void setHealth(int health)
        {
            slider.value = health;

            fill.color = gradient.Evaluate(slider.normalizedValue);
        }

        public void setMaxHealth(int health)
        {
            slider.maxValue = health;
            slider.value = health;

            fill.color = gradient.Evaluate(1.0f);
        }
 
		#region PrivateMethods
		#endregion
	}
}
