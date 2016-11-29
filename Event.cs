namespace VoronoiUI
{
    public struct Event
    {
        public readonly double X;
        public readonly double Y;
        public readonly EventType Type;

        public Event(double x, double y, EventType type)
        {
            X = x;
            Y = y;
            Type = type;
        }
    }
}