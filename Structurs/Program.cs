using System;

namespace Structurs
{
    public struct Vector
    {
        public int x;
        public int y;
        public int z;

        public Vector GetVector(int x, int y, int z)
        {
            Vector vector = new Vector();
            vector.x = x;
            vector.y = y;
            vector.z = z;
            return vector;
        }

        public override string ToString() => "(" + x + ";" + y + ";" + z + ")";

        public double Length()
            => Math.Pow(this.x * this.x + this.y * this.y + this.z * this.z, 0.5);

        public static Vector operator +(Vector Vector1, Vector Vector2)
            => new Vector().GetVector(Vector1.x + Vector2.x, Vector1.y + Vector2.y, Vector1.z + Vector2.z);

        public static Vector operator -(Vector Vector1, Vector Vector2)
            => new Vector().GetVector(Vector1.x - Vector2.x, Vector1.y - Vector2.y, Vector1.z - Vector2.z);

        public static Vector operator *(Vector Vector1, Vector Vector2)
            => new Vector().GetVector(Vector1.x * Vector2.x, Vector1.y * Vector2.y, Vector1.z * Vector2.z);

        public static Vector operator *(Vector Vector, int k)
            => new Vector().GetVector(Vector.x * k, Vector.y * k, Vector.z * k);

        public static Vector operator /(Vector Vector, int k)
            => new Vector().GetVector(Vector.x / k, Vector.y / k, Vector.z / k);

    }

    class Program
    {
        public void Main()
        {
            Vector Vector1 = ReadVector();
            Vector Vector2 = ReadVector();
            int k = ReadInt();
            Console.WriteLine(Vector1.Length());
            Console.WriteLine(Vector1 * Vector2);
            Console.WriteLine(Vector1 / k);

        }

        public Vector ReadVector()
            => new Vector().GetVector(ReadInt(), ReadInt(), ReadInt());

        public int ReadInt()
            => Convert.ToInt32(Console.ReadLine());

    }
}
