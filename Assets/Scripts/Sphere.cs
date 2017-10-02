using UnityEngine;

namespace Assets.Scripts
{
    public class Sphere : GameObject
    {
        public Sphere EnemySphere;

        void Start ()
        {
        }
	
        void Update ()
        {
            if (Health > 0 && EnemySphere.Health <= 0)
            {
            }
            else if (Health > 0)
            {
                EnemySphere.DoDamage(Damage);
                transform.Translate(0.1f, 0, 0);
            }
            else
            {
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
