namespace UnityEngine.PostProcessing
{
    public sealed class MinAttributes : PropertyAttribute
    {
        public readonly float min;

        public MinAttributes(float min)
        {
            this.min = min;
        }
    }
}
