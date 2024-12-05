namespace Code.Scripts.Gameplay.Tower
{
    using Abstract;
    using UniRx;
    using Unity.Mathematics;
    public class TowerMono : MonoObject<TowerPresenter>
    {
        public override void Initialize(TowerPresenter presenter)
        {
            presenter.IsDead.Where(x =>x == true)
                .Subscribe(_ => Kill())
                .AddTo(this);
            base.Initialize(presenter);
        }

        private void Kill()
        {
            Destroy(gameObject);
        }

        public void TakeDamage(float damage)
        {
            AnimateTakingDamage();
            Presenter.ApplyDamage(damage);
        }

        #region visualization
        private void AnimateTakingDamage()
        {
            throw new System.NotImplementedException();
        }
        private void AnimateShooting()
        {
            throw new System.NotImplementedException();
        }
        
        public void TurnTowerTo(float2 direction)
        {
            throw new System.NotImplementedException();
        }
        
        public void TurnTowerTo(UnityEngine.Vector3 targetPosition)
        {
            throw new System.NotImplementedException();
        }
        
        #endregion
        public void Shoot(float2 direction)
        {
            AnimateShooting();
            Presenter.Shoot(direction);
        }
        public void Shoot(UnityEngine.Vector3 targetPosition)
        {
            AnimateShooting();
            Presenter.Shoot(targetPosition);
        }
    }
}