// Modified version of the Los Techies enumeration type
// https://lostechies.com/jimmybogard/2008/08/12/enumeration-classes/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GoDungeon.Core.Enum
{
    public abstract class Enumeration : IComparable
    {
        private readonly Guid id = Guid.NewGuid();
        private readonly string _displayName;
        private readonly string? _description;

        public int Value { get; }

        protected Enumeration(int value, string displayName)
        {
            Value = value;
            _displayName = displayName;
        }

        protected Enumeration(string displayName)
        {
            Value++;
            _displayName = displayName;
        }

        protected Enumeration(string displayName, string description)
        {
            Value++;
            _displayName = displayName;
            _description = description;
        }

        protected Enumeration() : this(string.Empty) { }

        public string? Description => _description;
        public string DisplayName => _displayName;
        public Guid Id => Id;

        public override string ToString() => DisplayName;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                        .Select(f => f.GetValue(null))
                        .Cast<T>();
        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;

            if (otherValue == null)
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static int AbsoluteDifference(Enumeration firstValue, Enumeration secondValue)
        {
            var absoluteDifference = Math.Abs(firstValue.Value - secondValue.Value);
            return absoluteDifference;
        }

        public static T FromValue<T>(int value) where T : Enumeration, new()
        {
            var matchingItem = parse<T, int>(value, "value", item => item.Value == value);
            return matchingItem;
        }

        public static T FromDisplayName<T>(string displayName) where T : Enumeration, new()
        {
            var matchingItem = parse<T, string>(displayName, "display name", item => item.DisplayName == displayName);
            return matchingItem;
        }

        private static T parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration, new()
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);

            if (matchingItem == null)
            {
                var message = string.Format("'{0}' is not a valid {1} in {2}", value, description, typeof(T));
                throw new ApplicationException(message);
            }

            return matchingItem;
        }

        public int CompareTo(object other)
        {
            return Value.CompareTo(((Enumeration)other).Value);
        }
    }
}
