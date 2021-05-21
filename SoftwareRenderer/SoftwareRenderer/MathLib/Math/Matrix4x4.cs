using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace MathLib
{
    public partial struct FrustumPlanes
    {
        public float left;
        public float right;
        public float bottom;
        public float top;
        public float zNear;
        public float zFar;
    }

    
    public partial struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
    {// memory layout:
        //
        //                row no (=vertical)
        //               |  0   1   2   3
        //            ---+----------------
        //            0  | m00 m10 m20 m30
        // column no  1  | m01 m11 m21 m31
        // (=horiz)   2  | m02 m12 m22 m32
        //            3  | m03 m13 m23 m33

        ///*undocumented*
        public float m00;
        ///*undocumented*
        public float m10;
        ///*undocumented*
        public float m20;
        ///*undocumented*
        public float m30;

        ///*undocumented*
        public float m01;
        ///*undocumented*
        public float m11;
        ///*undocumented*
        public float m21;
        ///*undocumented*
        public float m31;

        ///*undocumented*
        public float m02;
        ///*undocumented*
        public float m12;
        ///*undocumented*
        public float m22;
        ///*undocumented*
        public float m32;

        ///*undocumented*
        public float m03;
        ///*undocumented*
        public float m13;
        ///*undocumented*
        public float m23;
        ///*undocumented*
        public float m33;

        public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
        {
            this.m00 = column0.x; this.m01 = column1.x; this.m02 = column2.x; this.m03 = column3.x;
            this.m10 = column0.y; this.m11 = column1.y; this.m12 = column2.y; this.m13 = column3.y;
            this.m20 = column0.z; this.m21 = column1.z; this.m22 = column2.z; this.m23 = column3.z;
            this.m30 = column0.w; this.m31 = column1.w; this.m32 = column2.w; this.m33 = column3.w;
        }

        public Matrix4x4(
            float m00, float m01, float m02, float m03,
            float m10, float m11, float m12, float m13,
            float m20, float m21, float m22, float m23,
            float m30, float m31, float m32, float m33)
        {
            this.m00 = m00; this.m01 = m01; this.m02 = m02; this.m03 = m03;
            this.m10 = m10; this.m11 = m11; this.m12 = m12; this.m13 = m13;
            this.m20 = m20; this.m21 = m21; this.m22 = m22; this.m23 = m23;
            this.m30 = m30; this.m31 = m31; this.m32 = m32; this.m33 = m33;
        }

        // Access element at [row, column].
        public float this[int row, int column]
        {
            get
            {
                return this[row + column * 4];
            }

            set
            {
                this[row + column * 4] = value;
            }
        }

        // Access element at sequential index (0..15 inclusive).
        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return m00;
                    case 1: return m10;
                    case 2: return m20;
                    case 3: return m30;
                    case 4: return m01;
                    case 5: return m11;
                    case 6: return m21;
                    case 7: return m31;
                    case 8: return m02;
                    case 9: return m12;
                    case 10: return m22;
                    case 11: return m32;
                    case 12: return m03;
                    case 13: return m13;
                    case 14: return m23;
                    case 15: return m33;
                    default:
                        throw new IndexOutOfRangeException("Invalid matrix index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: m00 = value; break;
                    case 1: m10 = value; break;
                    case 2: m20 = value; break;
                    case 3: m30 = value; break;
                    case 4: m01 = value; break;
                    case 5: m11 = value; break;
                    case 6: m21 = value; break;
                    case 7: m31 = value; break;
                    case 8: m02 = value; break;
                    case 9: m12 = value; break;
                    case 10: m22 = value; break;
                    case 11: m32 = value; break;
                    case 12: m03 = value; break;
                    case 13: m13 = value; break;
                    case 14: m23 = value; break;
                    case 15: m33 = value; break;

                    default:
                        throw new IndexOutOfRangeException("Invalid matrix index!");
                }
            }
        }

        // used to allow Matrix4x4s to be used as keys in hash tables
        public override int GetHashCode()
        {
            return GetColumn(0).GetHashCode() ^ (GetColumn(1).GetHashCode() << 2) ^ (GetColumn(2).GetHashCode() >> 2) ^ (GetColumn(3).GetHashCode() >> 1);
        }

        // also required for being able to use Matrix4x4s as keys in hash tables
        public override bool Equals(object other)
        {
            if (!(other is Matrix4x4)) return false;

            return Equals((Matrix4x4)other);
        }

        public bool Equals(Matrix4x4 other)
        {
            return GetColumn(0).Equals(other.GetColumn(0))
                && GetColumn(1).Equals(other.GetColumn(1))
                && GetColumn(2).Equals(other.GetColumn(2))
                && GetColumn(3).Equals(other.GetColumn(3));
        }

        // Multiplies two matrices.
        public static Matrix4x4 operator*(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            Matrix4x4 res;
            res.m00 = lhs.m00 * rhs.m00 + lhs.m01 * rhs.m10 + lhs.m02 * rhs.m20 + lhs.m03 * rhs.m30;
            res.m01 = lhs.m00 * rhs.m01 + lhs.m01 * rhs.m11 + lhs.m02 * rhs.m21 + lhs.m03 * rhs.m31;
            res.m02 = lhs.m00 * rhs.m02 + lhs.m01 * rhs.m12 + lhs.m02 * rhs.m22 + lhs.m03 * rhs.m32;
            res.m03 = lhs.m00 * rhs.m03 + lhs.m01 * rhs.m13 + lhs.m02 * rhs.m23 + lhs.m03 * rhs.m33;

            res.m10 = lhs.m10 * rhs.m00 + lhs.m11 * rhs.m10 + lhs.m12 * rhs.m20 + lhs.m13 * rhs.m30;
            res.m11 = lhs.m10 * rhs.m01 + lhs.m11 * rhs.m11 + lhs.m12 * rhs.m21 + lhs.m13 * rhs.m31;
            res.m12 = lhs.m10 * rhs.m02 + lhs.m11 * rhs.m12 + lhs.m12 * rhs.m22 + lhs.m13 * rhs.m32;
            res.m13 = lhs.m10 * rhs.m03 + lhs.m11 * rhs.m13 + lhs.m12 * rhs.m23 + lhs.m13 * rhs.m33;

            res.m20 = lhs.m20 * rhs.m00 + lhs.m21 * rhs.m10 + lhs.m22 * rhs.m20 + lhs.m23 * rhs.m30;
            res.m21 = lhs.m20 * rhs.m01 + lhs.m21 * rhs.m11 + lhs.m22 * rhs.m21 + lhs.m23 * rhs.m31;
            res.m22 = lhs.m20 * rhs.m02 + lhs.m21 * rhs.m12 + lhs.m22 * rhs.m22 + lhs.m23 * rhs.m32;
            res.m23 = lhs.m20 * rhs.m03 + lhs.m21 * rhs.m13 + lhs.m22 * rhs.m23 + lhs.m23 * rhs.m33;

            res.m30 = lhs.m30 * rhs.m00 + lhs.m31 * rhs.m10 + lhs.m32 * rhs.m20 + lhs.m33 * rhs.m30;
            res.m31 = lhs.m30 * rhs.m01 + lhs.m31 * rhs.m11 + lhs.m32 * rhs.m21 + lhs.m33 * rhs.m31;
            res.m32 = lhs.m30 * rhs.m02 + lhs.m31 * rhs.m12 + lhs.m32 * rhs.m22 + lhs.m33 * rhs.m32;
            res.m33 = lhs.m30 * rhs.m03 + lhs.m31 * rhs.m13 + lhs.m32 * rhs.m23 + lhs.m33 * rhs.m33;

            return res;
        }

        // Transforms a [[Vector4]] by a matrix.
        public static Vector4 operator*(Matrix4x4 lhs, Vector4 vector)
        {
            Vector4 res;
            res.x = lhs.m00 * vector.x + lhs.m01 * vector.y + lhs.m02 * vector.z + lhs.m03 * vector.w;
            res.y = lhs.m10 * vector.x + lhs.m11 * vector.y + lhs.m12 * vector.z + lhs.m13 * vector.w;
            res.z = lhs.m20 * vector.x + lhs.m21 * vector.y + lhs.m22 * vector.z + lhs.m23 * vector.w;
            res.w = lhs.m30 * vector.x + lhs.m31 * vector.y + lhs.m32 * vector.z + lhs.m33 * vector.w;
            return res;
        }

        //*undoc*
        public static bool operator==(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            // Returns false in the presence of NaN values.
            return lhs.GetColumn(0) == rhs.GetColumn(0)
                && lhs.GetColumn(1) == rhs.GetColumn(1)
                && lhs.GetColumn(2) == rhs.GetColumn(2)
                && lhs.GetColumn(3) == rhs.GetColumn(3);
        }

        //*undoc*
        public static bool operator!=(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            // Returns true in the presence of NaN values.
            return !(lhs == rhs);
        }

        // Get a column of the matrix.
        public Vector4 GetColumn(int index)
        {
            switch (index)
            {
                case 0: return new Vector4(m00, m10, m20, m30);
                case 1: return new Vector4(m01, m11, m21, m31);
                case 2: return new Vector4(m02, m12, m22, m32);
                case 3: return new Vector4(m03, m13, m23, m33);
                default:
                    throw new IndexOutOfRangeException("Invalid column index!");
            }
        }

        // Returns a row of the matrix.
        public Vector4 GetRow(int index)
        {
            switch (index)
            {
                case 0: return new Vector4(m00, m01, m02, m03);
                case 1: return new Vector4(m10, m11, m12, m13);
                case 2: return new Vector4(m20, m21, m22, m23);
                case 3: return new Vector4(m30, m31, m32, m33);
                default:
                    throw new IndexOutOfRangeException("Invalid row index!");
            }
        }

        // Sets a column of the matrix.
        public void SetColumn(int index, Vector4 column)
        {
            this[0, index] = column.x;
            this[1, index] = column.y;
            this[2, index] = column.z;
            this[3, index] = column.w;
        }

        // Sets a row of the matrix.
        public void SetRow(int index, Vector4 row)
        {
            this[index, 0] = row.x;
            this[index, 1] = row.y;
            this[index, 2] = row.z;
            this[index, 3] = row.w;
        }

        // Transforms a position by this matrix, with a perspective divide. (generic)
        public Vector3 MultiplyPoint(Vector3 point)
        {
            Vector3 res;
            float w;
            res.x = this.m00 * point.x + this.m01 * point.y + this.m02 * point.z + this.m03;
            res.y = this.m10 * point.x + this.m11 * point.y + this.m12 * point.z + this.m13;
            res.z = this.m20 * point.x + this.m21 * point.y + this.m22 * point.z + this.m23;
            w = this.m30 * point.x + this.m31 * point.y + this.m32 * point.z + this.m33;

            w = 1F / w;
            res.x *= w;
            res.y *= w;
            res.z *= w;
            return res;
        }

        // Transforms a position by this matrix, without a perspective divide. (fast)
        public Vector3 MultiplyPoint3x4(Vector3 point)
        {
            Vector3 res;
            res.x = this.m00 * point.x + this.m01 * point.y + this.m02 * point.z + this.m03;
            res.y = this.m10 * point.x + this.m11 * point.y + this.m12 * point.z + this.m13;
            res.z = this.m20 * point.x + this.m21 * point.y + this.m22 * point.z + this.m23;
            return res;
        }

        // Transforms a direction by this matrix.
        public Vector3 MultiplyVector(Vector3 vector)
        {
            Vector3 res;
            res.x = this.m00 * vector.x + this.m01 * vector.y + this.m02 * vector.z;
            res.y = this.m10 * vector.x + this.m11 * vector.y + this.m12 * vector.z;
            res.z = this.m20 * vector.x + this.m21 * vector.y + this.m22 * vector.z;
            return res;
        }

        // Transforms a plane by this matrix.
        public Plane TransformPlane(Plane plane)
        {
            var ittrans = this.inverse;

            float x = plane.normal.x, y = plane.normal.y, z = plane.normal.z, w = plane.distance;
            // note: a transpose is part of this transformation
            var a = ittrans.m00 * x + ittrans.m10 * y + ittrans.m20 * z + ittrans.m30 * w;
            var b = ittrans.m01 * x + ittrans.m11 * y + ittrans.m21 * z + ittrans.m31 * w;
            var c = ittrans.m02 * x + ittrans.m12 * y + ittrans.m22 * z + ittrans.m32 * w;
            var d = ittrans.m03 * x + ittrans.m13 * y + ittrans.m23 * z + ittrans.m33 * w;

            return new Plane(new Vector3(a, b, c), d);
        }

        // Creates a scaling matrix.
        public static Matrix4x4 Scale(Vector3 vector)
        {
            Matrix4x4 m;
            m.m00 = vector.x; m.m01 = 0F; m.m02 = 0F; m.m03 = 0F;
            m.m10 = 0F; m.m11 = vector.y; m.m12 = 0F; m.m13 = 0F;
            m.m20 = 0F; m.m21 = 0F; m.m22 = vector.z; m.m23 = 0F;
            m.m30 = 0F; m.m31 = 0F; m.m32 = 0F; m.m33 = 1F;
            return m;
        }

        // Creates a translation matrix.
        public static  Matrix4x4 Translate(Vector3 vector)
        {
            Matrix4x4 m;
            m.m00 = 1F; m.m01 = 0F; m.m02 = 0F; m.m03 = vector.x;
            m.m10 = 0F; m.m11 = 1F; m.m12 = 0F; m.m13 = vector.y;
            m.m20 = 0F; m.m21 = 0F; m.m22 = 1F; m.m23 = vector.z;
            m.m30 = 0F; m.m31 = 0F; m.m32 = 0F; m.m33 = 1F;
            return m;
        }

        // Creates a rotation matrix. Note: Assumes unit quaternion
        public static Matrix4x4 Rotate(Quaternion q)
        {
            // Precalculate coordinate products
            float x = q.x * 2.0F;
            float y = q.y * 2.0F;
            float z = q.z * 2.0F;
            float xx = q.x * x;
            float yy = q.y * y;
            float zz = q.z * z;
            float xy = q.x * y;
            float xz = q.x * z;
            float yz = q.y * z;
            float wx = q.w * x;
            float wy = q.w * y;
            float wz = q.w * z;

            // Calculate 3x3 matrix from orthonormal basis
            Matrix4x4 m;
            m.m00 = 1.0f - (yy + zz); m.m10 = xy + wz; m.m20 = xz - wy; m.m30 = 0.0F;
            m.m01 = xy - wz; m.m11 = 1.0f - (xx + zz); m.m21 = yz + wx; m.m31 = 0.0F;
            m.m02 = xz + wy; m.m12 = yz - wx; m.m22 = 1.0f - (xx + yy); m.m32 = 0.0F;
            m.m03 = 0.0F; m.m13 = 0.0F; m.m23 = 0.0F; m.m33 = 1.0F;
            return m;
        }

        // Matrix4x4.zero is of questionable usefulness considering C# sets everything to 0 by default, however:
        //  1. it's consistent with other Math structs in Unity such as Vector2, Vector3 and Vector4,
        //  2. "Matrix4x4.zero" is arguably more readable than "new Matrix4x4()",
        //  3. it's already in the API ..
        static readonly Matrix4x4 zeroMatrix = new Matrix4x4(new Vector4(0, 0, 0, 0),
            new Vector4(0, 0, 0, 0),
            new Vector4(0, 0, 0, 0),
            new Vector4(0, 0, 0, 0));

        // Returns a matrix with all elements set to zero (RO).
        public static Matrix4x4 zero { get { return zeroMatrix; } }

        static readonly Matrix4x4 identityMatrix = new Matrix4x4(new Vector4(1, 0, 0, 0),
            new Vector4(0, 1, 0, 0),
            new Vector4(0, 0, 1, 0),
            new Vector4(0, 0, 0, 1));

        // Returns the identity matrix (RO).
        public static Matrix4x4 identity    { get { return identityMatrix; } }

        public override string ToString()
        {
            return ToString(null, CultureInfo.InvariantCulture.NumberFormat);
        }

        public string ToString(string format)
        {
            return ToString(format, CultureInfo.InvariantCulture.NumberFormat);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                format = "F5";
            return String.Format("{0}\t{1}\t{2}\t{3}\n{4}\t{5}\t{6}\t{7}\n{8}\t{9}\t{10}\t{11}\n{12}\t{13}\t{14}\t{15}\n",
                m00.ToString(format, formatProvider), m01.ToString(format, formatProvider), m02.ToString(format, formatProvider), m03.ToString(format, formatProvider),
                m10.ToString(format, formatProvider), m11.ToString(format, formatProvider), m12.ToString(format, formatProvider), m13.ToString(format, formatProvider),
                m20.ToString(format, formatProvider), m21.ToString(format, formatProvider), m22.ToString(format, formatProvider), m23.ToString(format, formatProvider),
                m30.ToString(format, formatProvider), m31.ToString(format, formatProvider), m32.ToString(format, formatProvider), m33.ToString(format, formatProvider));
        }
    }
    
    public partial struct Matrix4x4
    {
        private Quaternion GetRotation()
        {
            throw new NotImplementedException();
        }

        private Vector3 GetLossyScale()
        {
            throw new NotImplementedException();
        }

        private bool IsIdentity()
        {
            if (Mathf.Approximately (this[0,0],1.0f) && Mathf.Approximately (this [0,1],0.0f) && Mathf.Approximately (this [0,2],0.0f) && Mathf.Approximately (this [0,3],0.0f) &&
                Mathf.Approximately (this [1,0],0.0f) && Mathf.Approximately (this [1,1],1.0f) && Mathf.Approximately (this [1,2],0.0f) && Mathf.Approximately (this [1,3],0.0f) &&
                Mathf.Approximately (this [2,0],0.0f) && Mathf.Approximately (this [2,1],0.0f) && Mathf.Approximately (this [2,2],1.0f) && Mathf.Approximately (this [2,3],0.0f) &&
                Mathf.Approximately (this [3,0],0.0f) && Mathf.Approximately (this [3,1],0.0f) && Mathf.Approximately (this [3,2],0.0f) && Mathf.Approximately (this [3,3],1.0f))
                return true;
            return false;
        }

        private float GetDeterminant()
        {
            float m00 = this[0, 0];  float m01 = this[0, 1];  float m02 = this[0, 2];  float m03 = this[0, 3];
            float m10 = this[1, 0];  float m11 = this[1, 1];  float m12 = this[1, 2];  float m13 = this[1, 3];
            float m20 = this[2, 0];  float m21 = this[2, 1];  float m22 = this[2, 2];  float m23 = this[2, 3];
            float m30 = this[3, 0];  float m31 = this[3, 1];  float m32 = this[3, 2];  float m33 = this[3, 3];

            float result =
                m03 * m12 * m21 * m30 - m02 * m13 * m21 * m30 - m03 * m11 * m22 * m30 + m01 * m13 * m22 * m30 +
                m02 * m11 * m23 * m30 - m01 * m12 * m23 * m30 - m03 * m12 * m20 * m31 + m02 * m13 * m20 * m31 +
                m03 * m10 * m22 * m31 - m00 * m13 * m22 * m31 - m02 * m10 * m23 * m31 + m00 * m12 * m23 * m31 +
                m03 * m11 * m20 * m32 - m01 * m13 * m20 * m32 - m03 * m10 * m21 * m32 + m00 * m13 * m21 * m32 +
                m01 * m10 * m23 * m32 - m00 * m11 * m23 * m32 - m02 * m11 * m20 * m33 + m01 * m12 * m20 * m33 +
                m02 * m10 * m21 * m33 - m00 * m12 * m21 * m33 - m01 * m10 * m22 * m33 + m00 * m11 * m22 * m33;
            return result;    
        }

        private FrustumPlanes DecomposeProjection()
        {
            throw new NotImplementedException();
        }


        public Quaternion rotation               { get { return GetRotation(); } }
        public Vector3 lossyScale                { get { return GetLossyScale(); } }
        public bool isIdentity                   { get { return IsIdentity(); } }
        public float determinant                 { get { return GetDeterminant(); } }
        public FrustumPlanes decomposeProjection { get { return DecomposeProjection(); } }

        public static float Determinant(Matrix4x4 m) { return m.determinant; }

        public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
        {
            var mat = Quaternion.ToMatrix4x4(q);

            mat[0] *= s[0];
            mat[1] *= s[0];
            mat[2] *= s[0];

            mat[4] *= s[1];
            mat[5] *= s[1];
            mat[6] *= s[1];

            mat[8] *= s[2];
            mat[9] *= s[2];
            mat[10] *= s[2];

            mat[12] = pos[0];
            mat[13] = pos[1];
            mat[14] = pos[2];

            return mat;
        }
        
        public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { this = Matrix4x4.TRS(pos, q, s); }

        public static Matrix4x4 Inverse(Matrix4x4 m)
        {
            var @out = m;
            
            float[,] wtmp = new float[4,8];
           float m0, m1, m2, m3, s;
           float[] r0 = new float[4];
           float[] r1 = new float[4];
           float[] r2 = new float[4];
           float[] r3 = new float[4];

           r0 = new []{wtmp[0, 0], wtmp[0, 1], wtmp[0, 2], wtmp[0, 3]};
           r1 = new []{wtmp[1, 0], wtmp[1, 1], wtmp[1, 2], wtmp[1, 3]};
           r2 = new []{wtmp[2, 0], wtmp[2, 1], wtmp[2, 2], wtmp[2, 3]};
           r3 = new []{wtmp[3, 0], wtmp[3, 1], wtmp[3, 2], wtmp[3, 3]};

           r0[0] = m[0, 0];
           r0[1] = m[0, 1];
           r0[2] = m[0, 2];
           r0[3] = m[0, 3];
           r0[4] = 1.0f;
           r0[5] = r0[6] = r0[7] = 0.0f;

           r1[0] = m[1, 0];
           r1[1] = m[1, 1];
           r1[2] = m[1, 2];
           r1[3] = m[1, 3];
           r1[5] = 1.0f;
           r1[4] = r1[6] = r1[7] = 0.0f;

           r2[0] = m[2, 0];
           r2[1] = m[2, 1];
           r2[2] = m[2, 2];
           r2[3] = m[2, 3];
           r2[6] = 1.0f;
           r2[4] = r2[5] = r2[7] = 0.0f;

           r3[0] = m[3, 0];
           r3[1] = m[3, 1];
           r3[2] = m[3, 2];
           r3[3] = m[3, 3];
           r3[7] = 1.0f;
           r3[4] = r3[5] = r3[6] = 0.0f;

           /* choose pivot - or die */
           if (Mathf.Abs(r3[0])>Mathf.Abs(r2[0])) Utility.Swap(ref r3, ref r2);
           if (Mathf.Abs(r2[0])>Mathf.Abs(r1[0])) Utility.Swap(ref r2, ref r1);
           if (Mathf.Abs(r1[0])>Mathf.Abs(r0[0])) Utility.Swap(ref r1, ref r0);
           if (0.0F == r0[0]) return identity;

           /* eliminate first variable     */
           m1 = r1[0]/r0[0]; m2 = r2[0]/r0[0]; m3 = r3[0]/r0[0];
           s = r0[1]; r1[1] -= m1 * s; r2[1] -= m2 * s; r3[1] -= m3 * s;
           s = r0[2]; r1[2] -= m1 * s; r2[2] -= m2 * s; r3[2] -= m3 * s;
           s = r0[3]; r1[3] -= m1 * s; r2[3] -= m2 * s; r3[3] -= m3 * s;
           s = r0[4];
           if (s != 0.0F) { r1[4] -= m1 * s; r2[4] -= m2 * s; r3[4] -= m3 * s; }
           s = r0[5];
           if (s != 0.0F) { r1[5] -= m1 * s; r2[5] -= m2 * s; r3[5] -= m3 * s; }
           s = r0[6];
           if (s != 0.0F) { r1[6] -= m1 * s; r2[6] -= m2 * s; r3[6] -= m3 * s; }
           s = r0[7];
           if (s != 0.0F) { r1[7] -= m1 * s; r2[7] -= m2 * s; r3[7] -= m3 * s; }

           /* choose pivot - or die */
           if (Mathf.Abs(r3[1])>Mathf.Abs(r2[1])) Utility.Swap(ref r3, ref r2);
           if (Mathf.Abs(r2[1])>Mathf.Abs(r1[1])) Utility.Swap(ref r2, ref r1);
           if (0.0F == r1[1]) return zero;

           /* eliminate second variable */
           m2 = r2[1]/r1[1]; m3 = r3[1]/r1[1];
           r2[2] -= m2 * r1[2]; r3[2] -= m3 * r1[2];
           r2[3] -= m2 * r1[3]; r3[3] -= m3 * r1[3];
           s = r1[4]; if (0.0F != s) { r2[4] -= m2 * s; r3[4] -= m3 * s; }
           s = r1[5]; if (0.0F != s) { r2[5] -= m2 * s; r3[5] -= m3 * s; }
           s = r1[6]; if (0.0F != s) { r2[6] -= m2 * s; r3[6] -= m3 * s; }
           s = r1[7]; if (0.0F != s) { r2[7] -= m2 * s; r3[7] -= m3 * s; }

           /* choose pivot - or die */
           if (Mathf.Abs(r3[2])>Mathf.Abs(r2[2])) Utility.Swap(ref r3, ref r2);
           if (0.0F == r2[2]) return zero;

           /* eliminate third variable */
           m3 = r3[2]/r2[2];
           r3[3] -= m3 * r2[3];
           r3[4] -= m3 * r2[4];
           r3[5] -= m3 * r2[5];
           r3[6] -= m3 * r2[6];
           r3[7] -= m3 * r2[7];

           /* last check */
           if (0.0F == r3[3]) return zero;

           s = 1.0F/r3[3];             /* now back substitute row 3 */
           r3[4] *= s; r3[5] *= s; r3[6] *= s; r3[7] *= s;

           m2 = r2[3];                 /* now back substitute row 2 */
           s  = 1.0F/r2[2];
           r2[4] = s * (r2[4] - r3[4] * m2); r2[5] = s * (r2[5] - r3[5] * m2);
           r2[6] = s * (r2[6] - r3[6] * m2); r2[7] = s * (r2[7] - r3[7] * m2);
           m1 = r1[3];
           r1[4] -= r3[4] * m1; r1[5] -= r3[5] * m1;
           r1[6] -= r3[6] * m1; r1[7] -= r3[7] * m1;
           m0 = r0[3];
           r0[4] -= r3[4] * m0; r0[5] -= r3[5] * m0;
           r0[6] -= r3[6] * m0; r0[7] -= r3[7] * m0;

           m1 = r1[2];                 /* now back substitute row 1 */
           s  = 1.0F/r1[1];
           r1[4] = s * (r1[4] - r2[4] * m1); r1[5] = s * (r1[5] - r2[5] * m1);
           r1[6] = s * (r1[6] - r2[6] * m1); r1[7] = s * (r1[7] - r2[7] * m1);
           m0 = r0[2];
           r0[4] -= r2[4] * m0; r0[5] -= r2[5] * m0;
           r0[6] -= r2[6] * m0; r0[7] -= r2[7] * m0;

           m0 = r0[1];                 /* now back substitute row 0 */
           s  = 1.0F/r0[0];
           r0[4] = s * (r0[4] - r1[4] * m0); r0[5] = s * (r0[5] - r1[5] * m0);
           r0[6] = s * (r0[6] - r1[6] * m0); r0[7] = s * (r0[7] - r1[7] * m0);

           @out[0,0] = r0[4]; @out[0, 1] = r0[5]; @out[0,2] = r0[6]; @out[0, 3] = r0[7];
           @out[1,0] = r1[4]; @out[1, 1] = r1[5]; @out[1,2] = r1[6]; @out[1, 3] = r1[7];
           @out[2,0] = r2[4]; @out[2, 1] = r2[5]; @out[2,2] = r2[6]; @out[2, 3] = r2[7];
           @out[3,0] = r3[4]; @out[3, 1] = r3[5]; @out[3,2] = r3[6]; @out[3,3] = r3[7];

           return @out;
            
        }
        public Matrix4x4 inverse { get { return Matrix4x4.Inverse(this); } }

        public static Matrix4x4 Transpose(Matrix4x4 m)
        {
            var res = m;
            Utility.Swap(ref m.m01,ref m.m10);
            Utility.Swap(ref m.m02,ref m.m20);
            Utility.Swap(ref m.m03,ref m.m30);
            Utility.Swap(ref m.m12,ref m.m21);
            Utility.Swap(ref m.m13,ref m.m31);
            Utility.Swap(ref m.m23,ref m.m32);
            return res;
        }
        
        public Matrix4x4 transpose { get { return Matrix4x4.Transpose(this); } }

        public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
        {
            var mat = Matrix4x4.identity;

            float deltax = right - left;
            float deltay = top - bottom;
            float deltaz = zFar - zNear;

            mat.m00 = 2.0F / deltax;
            mat.m03 = -(right + left) / deltax;
            mat.m11 = 2.0F / deltay;
            mat.m13 = -(top + bottom) / deltay;
            mat.m22 = -2.0F / deltaz;
            mat.m23 = -(zFar + zNear) / deltaz;
            return mat;
        }

        public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
        {
            var mat = Matrix4x4.identity;
            float cotangent, deltaZ;
            float radians = fov / 2.0f * Mathf.Deg2Rad;
            cotangent = Mathf.Cos (radians) / Mathf.Sin (radians);
            deltaZ = zNear - zFar;
	
            mat [0,0] = cotangent / aspect; mat [0,1] = 0.0F;      mat [0,2] = 0.0F;                    mat [0,3] = 0.0F;
            mat [1,0] = 0.0F;               mat [1,1] = cotangent; mat [1,2] = 0.0F;                    mat [1,3] = 0.0F;
            mat [2,0] = 0.0F;               mat [2,1] = 0.0F;      mat [2,2] = (zFar + zNear) / deltaZ; mat [2,3] = 2.0F * zNear * zFar / deltaZ;
            mat [3,0] = 0.0F;               mat [3,1] = 0.0F;      mat [3,2] = -1.0F;                   mat [3,3] = 0.0F;

            return mat;
        }

        public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float nearval, float farval)
        {
            var mat = Matrix4x4.identity;
            float x, y, a, b, c, d, e;
	    
            x =  (2.0F * nearval) 		/ (right - left);
            y =  (2.0F * nearval) 		/ (top - bottom);
            a =  (right + left)			/ (right - left);
            b =  (top + bottom)			/ (top - bottom);
            c = -(farval + nearval)		   / (farval - nearval);
            d = -(2.0f * farval * nearval) / (farval - nearval);
            e = -1.0f;

            mat.m00 = x;     mat.m01 = 0.0f;  mat.m02 = a;   mat.m03 = 0.0f;
            mat.m10 = 0.0f;  mat.m11 = y;     mat.m12 = b;   mat.m13 = 0.0f;
            mat.m20 = 0.0f;  mat.m21 = 0.0f;  mat.m22 = c;   mat.m23 = d;
            mat.m30 = 0.0f;  mat.m31 = 0.0f;  mat.m32 = e;	 mat.m33 = 0.0f;
            return mat;
        }
        public static Matrix4x4 Frustum(FrustumPlanes fp) { return Frustum(fp.left, fp.right, fp.bottom, fp.top, fp.zNear, fp.zFar); }
    }
    
}
