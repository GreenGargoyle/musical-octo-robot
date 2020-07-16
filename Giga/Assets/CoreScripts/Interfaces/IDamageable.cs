using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoreScripts
{
	public interface IDamageable<T>
	{
        void takeDamage(T damageTaken);
	}
}

