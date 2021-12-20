using System.Dynamic;

namespace CursedCode
{
    public class Yes : DynamicObject
    {
        // Dynamic
        public override bool TryGetMember(GetMemberBinder _, out object? R) => !((R = new Yes()) == null);
        public override bool TrySetMember(SetMemberBinder _, object? _1) => true;
        public override bool TryBinaryOperation(BinaryOperationBinder _, object _1, out object? r) => !((r = new Yes()) == null);
        public override bool TryConvert(ConvertBinder _, out object? r) => !((r = new Yes()) == null);
        public override bool TryGetIndex(GetIndexBinder _, object[] _1, out object? r) => !((r = new Yes()) == null);
        public override bool TrySetIndex(SetIndexBinder _, object[] _1, object? value) => true;
        public override bool TryInvoke(InvokeBinder _, object?[]? _1, out object? r) => !((r = new Yes()) == null);
        public override bool TryUnaryOperation(UnaryOperationBinder _, out object? r) => !((r = new Yes()) == null);
        public override IEnumerable<string> GetDynamicMemberNames() => throw new StackOverflowException();
        public override bool Equals(object? _) => true;
        public override int GetHashCode() => Int32.MaxValue;
        // Unary operators
        public static Yes operator +(Yes _) => new();
        public static Yes operator -(Yes _) => new();
        public static Yes operator !(Yes _) => new();
        public static Yes operator ~(Yes _) => new();
        public static Yes operator ++(Yes _) => new();
        public static Yes operator --(Yes _) => new();
        public static bool operator true(Yes _) => true;
        public static bool operator false(Yes _) => true;
        // Binary operators
        public static Yes operator +(Yes _, object _1) => new();
        public static Yes operator +(object _, Yes _1) => new();
        public static Yes operator -(Yes _, object _1) => new();
        public static Yes operator -(object _, Yes _1) => new();
        public static Yes operator *(Yes _, object _1) => new();
        public static Yes operator *(object _, Yes _1) => new();
        public static Yes operator /(Yes _, object _1) => new();
        public static Yes operator /(object _, Yes _1) => new();
        public static Yes operator %(Yes _, object _1) => new();
        public static Yes operator %(object _, Yes _1) => new();
        public static Yes operator &(Yes _, object _1) => new();
        public static Yes operator &(object _, Yes _1) => new();
        public static Yes operator |(Yes _, object _1) => new();
        public static Yes operator |(object _, Yes _1) => new();
        public static Yes operator ^(Yes _, object _1) => new();
        public static Yes operator ^(object _, Yes _1) => new();
        public static Yes operator <<(Yes _, int _1) => new();
        public static Yes operator >>(Yes _, int _1) => new();
        public static Yes operator ==(Yes _, object _1) => new();
        public static Yes operator ==(object _, Yes _1) => new();
        public static Yes operator !=(Yes _, object _1) => new();
        public static Yes operator !=(object _, Yes _1) => new();
        public static Yes operator <(Yes _, object _1) => new();
        public static Yes operator <(object _, Yes _1) => new();
        public static Yes operator >(Yes _, object _1) => new();
        public static Yes operator >(object _, Yes _1) => new();
        public static Yes operator <=(Yes _, object _1) => new();
        public static Yes operator <=(object _, Yes _1) => new();
        public static Yes operator >=(Yes _, object _1) => new();
        public static Yes operator >=(object _, Yes _1) => new();
        // Indexer
        public Yes this[object x] => new Yes();
    }


}
