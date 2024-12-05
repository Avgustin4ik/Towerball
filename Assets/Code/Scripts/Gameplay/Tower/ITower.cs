namespace Code.Scripts.Gameplay.Tower
{
    using Unity.Mathematics;
    using UnityEngine;

    public interface ITower
    {
        public void ApplyDamage(float damage);
        public void Shoot(float2 direction);
        public void Shoot(Vector3 targetPosition);
    }
}