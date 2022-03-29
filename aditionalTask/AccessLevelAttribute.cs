using System;

namespace aditionalTask
{
    public enum AccessLevel : byte
    {
        low = 1,
        average = 2,
        high = 3,
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AccessLevelAttribute : Attribute
    {
        private readonly AccessLevel access;
        public AccessLevel Access { get => access; }

        public AccessLevelAttribute(AccessLevel access)
        {
            this.access = access;
        }
    }
}
