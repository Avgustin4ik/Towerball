namespace Code.Scripts.Gameplay.Сrosshair
{
    using Unity.Mathematics;

    public interface ICrosshair
    {
        void Move(float2 position);
        bool IsPositionFixed { get; }
        float2 Position { get; }
        void FixPosition(bool isFixed);
    }
}