namespace Code.Scripts.Gameplay.Tower
{
    using Abstract;
    using UniRx;
    using Unity.Mathematics;
    using UnityEngine;
    public abstract class TowerPresenter : Presenter<TowerModel>, ITower
    {
        public ReactiveProperty<bool> IsDead { get; } = new ReactiveProperty<bool>(false);

        protected TowerPresenter(TowerModel model) : base(model)
        {
            model.Health.Select(x => x <= 0)
                .Subscribe(_ => Die());
        }
        
        public void ApplyDamage(float damage) => Model.Health.Value -= damage;

        private void Die()
        {
            //notify monobeheviour
            IsDead.Value = true;
            //await monoBehaviour.Destroy();
            Destroy();
        }

        private void Destroy()
        {
            throw new System.NotImplementedException();
        }

        public void Shoot(float2 direction)
        {
            //заспавни пулю и передай ей направление
            throw new System.NotImplementedException();
        }

        public void Shoot(Vector3 targetPosition)
        {
            //заспавни пулю и передай ей направление
            throw new System.NotImplementedException();
        }
    }
}