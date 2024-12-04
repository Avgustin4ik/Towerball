namespace Code.Scripts.Gameplay.Сrosshair
{
    using Abstract;
    using Unity.Mathematics;

    public abstract class CrosshairModel : IModel
    {
        public float2 Position { get; set; }
        public bool IsPositionFixed { get; set; }
    }
}