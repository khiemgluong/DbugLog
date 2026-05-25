public partial struct Channel
{
    public static class Environment
    {
        public static readonly Channel Prop = new Channel(1u << 4);
        public static readonly Channel Object = new Channel(1u << 5);
        public static readonly Channel Items = new Channel(1u << 6);
        public static readonly Channel State = new Channel(1u << 7);
        public static readonly Channel Terrain = new Channel(1u << 8);
    }
}