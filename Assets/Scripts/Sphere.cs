using UnityEngine;

namespace Assets.Scripts
{
    public class Sphere : GameObject
    {
        public Sphere EnemySphere;

        void Start ()
        {
		    Debug.Log($"Starting health on {name} is: {Health}");
        }
	
        void Update ()
        {
            if (Health > 0 && EnemySphere.Health <= 0)
            {
                Debug.Log($"{name}: I'm Winner!");
            }
            else if (Health > 0)
            {
                EnemySphere.DoDamage(Damage);
                transform.Translate(0.1f, 0, 0);
            }
            else
            {
                Debug.Log($"{name}: I'm Dead!");
                Destroy(gameObject);
            }
        }

        public override void DoDamage(int damage)
        {
            if (Health > 0)
            {
                Health -= damage;
            }
        }
    }
}
