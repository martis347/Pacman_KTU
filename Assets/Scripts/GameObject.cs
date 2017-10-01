using UnityEngine;

namespace Assets.Scripts
{
    public abstract class GameObject : MonoBehaviour
    {
        public int Health;
        public int Damage;
        public abstract void DoDamage(int damage);
    }
}