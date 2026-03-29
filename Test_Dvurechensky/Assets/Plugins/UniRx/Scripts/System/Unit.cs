/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
 */

using System;

namespace UniRx
{
    [Serializable]
    public struct Unit : IEquatable<Unit>
    {
        static readonly Unit @default = new Unit();

        public static Unit Default { get { return @default; } }

        public static bool operator ==(Unit first, Unit second)
        {
            return true;
        }

        public static bool operator !=(Unit first, Unit second)
        {
            return false;
        }

        public bool Equals(Unit other)
        {
            return true;
        }
        public override bool Equals(object obj)
        {
            return obj is Unit;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return "()";
        }
    }
}