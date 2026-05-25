using UnityEngine;
using System;
[Serializable]
public partial struct Channel : IEquatable<Channel>
{
    public ulong Value;

    public Channel(ulong value) => Value = value;

    public static implicit operator ulong(Channel c) => c.Value;
    public static implicit operator Channel(ulong v) => new Channel(v);

    public static Channel operator |(Channel a, Channel b) => new Channel(a.Value | b.Value);
    public static Channel operator &(Channel a, Channel b) => new Channel(a.Value & b.Value);
    public static Channel operator ^(Channel a, Channel b) => new Channel(a.Value ^ b.Value);
    public static Channel operator ~(Channel a) => new Channel(~a.Value);

    public bool Equals(Channel other) => Value == other.Value;
    public override bool Equals(object obj) => obj is Channel other && Equals(other);
    public override int GetHashCode() => Value.GetHashCode();
    public override string ToString() => DBug.GetChannelName(this);
}