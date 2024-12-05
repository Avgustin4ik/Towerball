namespace Code.Scripts.Gameplay.Tower
{
    using Abstract;
    using UniRx;

    public abstract class TowerModel : IModel
    {
        public ReactiveProperty<float> Health { get; set; }
    }
}