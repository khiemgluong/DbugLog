public partial struct Channel
{
    public static class Characters
    {
        public static readonly Channel Behavior = new Channel(1u << 0);
        public static readonly Channel Body = new Channel(1u << 1);
        public static readonly Channel Combat = new Channel(1u << 2);
        public static readonly Channel Controls = new Channel(1u << 3);

        public static readonly Channel Targeting = new Channel(1u << 4);

        public static readonly Channel NPCs = new Channel(1u << 5);
    }
}