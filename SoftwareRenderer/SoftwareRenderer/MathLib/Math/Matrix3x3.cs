using System;
using System.Globalization;

namespace MathLib
{
    public struct Matrix3x3 : IEquatable<Matrix3x3>, IFormattable
    {
        ///*undocumented*
        public float m00;
        ///*undocumented*
        public float m10;
        ///*undocumented*
        public float m20;

        ///*undocumented*
        public float m01;
        ///*undocumented*
        public float m11;
        ///*undocumented*
        public float m21;

        ///*undocumented*
        public float m02;
        ///*undocumented*
        public float m12;
        ///*undocumented*
        public float m22;


        public Matrix3x3(Vector3 column0, Vector3 column1, Vector3 column2)
        {
            this.m00 = column0.x; this.m01 = column1.x; this.m02 = column2.x; 
            this.m10 = column0.y; this.m11 = column1.y; this.m12 = column2.y; 
            this.m20 = column0.z; this.m21 = column1.z; this.m22 = column2.z; 
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
                    case 4: return m01;
                    case 5: return m11;
                    case 6: return m21;
                    case 8: return m02;
                    case 9: return m12;
                    case 10: return m22;
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
                    case 4: m01 = value; break;
                    case 5: m11 = value; break;
                    case 6: m21 = value; break;
                    case 8: m02 = value; break;
                    case 9: m12 = value; break;
                    case 10: m22 = value; break;

                    default:
                        throw new IndexOutOfRangeException("Invalid matrix index!");
                }
            }
        }
        
        public override int GetHashCode()
        {
            return GetColumn(0).GetHashCode() ^ (GetColumn(1).GetHashCode() << 2) ^ (GetColumn(2).GetHashCode() >> 2) ^ (GetColumn(3).GetHashCode() >> 1);
        }
        
        // also required for being able to use Matrix4x4s as keys in hash tables
        public override bool Equals(object other)
        {
            if (!(other is Matrix3x3)) return false;

            return Equals((Matrix3x3)other);
        }

        public bool Equals(Matrix3x3 other)
        {
            return GetColumn(0).Equals(other.GetColumn(0))
                   && GetColumn(1).Equals(other.GetColumn(1))
                   && GetColumn(2).Equals(other.GetColumn(2))
                   && GetColumn(3).Equals(other.GetColumn(3));
        }
        
         // Multiplies two matrices.
        public static Matrix3x3 operator*(Matrix3x3 lhs, Matrix3x3 rhs)
        {
            Matrix3x3 res;
            res.m00 = lhs.m00 * rhs.m00 + lhs.m01 * rhs.m10 + lhs.m02 * rhs.m20;
            res.m01 = lhs.m00 * rhs.m01 + lhs.m01 * rhs.m11 + lhs.m02 * rhs.m21;
            res.m02 = lhs.m00 * rhs.m02 + lhs.m01 * rhs.m12 + lhs.m02 * rhs.m22;

            res.m10 = lhs.m10 * rhs.m00 + lhs.m11 * rhs.m10 + lhs.m12 * rhs.m20;
            res.m11 = lhs.m10 * rhs.m01 + lhs.m11 * rhs.m11 + lhs.m12 * rhs.m21;
            res.m12 = lhs.m10 * rhs.m02 + lhs.m11 * rhs.m12 + lhs.m12 * rhs.m22;

            res.m20 = lhs.m20 * rhs.m00 + lhs.m21 * rhs.m10 + lhs.m22 * rhs.m20;
            res.m21 = lhs.m20 * rhs.m01 + lhs.m21 * rhs.m11 + lhs.m22 * rhs.m21;
            res.m22 = lhs.m20 * rhs.m02 + lhs.m21 * rhs.m12 + lhs.m22 * rhs.m22;

            return res;
        }

        // Transforms a [[Vector4]] by a matrix.
        public static Vector4 operator*(Matrix3x3 lhs, Vector3 vector)
        {
            Vector3 res;
            res.x = lhs.m00 * vector.x + lhs.m01 * vector.y + lhs.m02 * vector.z;
            res.y = lhs.m10 * vector.x + lhs.m11 * vector.y + lhs.m12 * vector.z;
            res.z = lhs.m20 * vector.x + lhs.m21 * vector.y + lhs.m22 * vector.z;
            return res;
        }

        //*undoc*
        public static bool operator==(Matrix3x3 lhs, Matrix3x3 rhs)
        {
            // Returns false in the presence of NaN values.
            return lhs.GetColumn(0) == rhs.GetColumn(0)
                && lhs.GetColumn(1) == rhs.GetColumn(1)
                && lhs.GetColumn(2) == rhs.GetColumn(2)
                && lhs.GetColumn(3) == rhs.GetColumn(3);
        }

        //*undoc*
        public static bool operator!=(Matrix3x3 lhs, Matrix3x3 rhs)
        {
            // Returns true in the presence of NaN values.
            return !(lhs == rhs);
        }

        // Get a column of the matrix.
        public Vector3 GetColumn(int index)
        {
            switch (index)
            {
                case 0: return new Vector3(m00, m10, m20);
                case 1: return new Vector3(m01, m11, m21);
                case 2: return new Vector3(m02, m12, m22);
                default:
                    throw new IndexOutOfRangeException("Invalid column index!");
            }
        }

        // Returns a row of the matrix.
        public Vector3 GetRow(int index)
        {
            switch (index)
            {
                case 0: return new Vector3(m00, m01, m02);
                case 1: return new Vector3(m10, m11, m12);
                case 2: return new Vector3(m20, m21, m22);
                default:
                    throw new IndexOutOfRangeException("Invalid row index!");
            }
        }

        // Sets a column of the matrix.
        public void SetColumn(int index, Vector3 column)
        {
            this[0, index] = column.x;
            this[1, index] = column.y;
            this[2, index] = column.z;
        }

        // Sets a row of the matrix.
        public void SetRow(int index, Vector3 row)
        {
            this[index, 0] = row.x;
            this[index, 1] = row.y;
            this[index, 2] = row.z;
        }
        
        public Vector3 MultiplyVector(Vector3 vector)
        {
            Vector3 res;
            res.x = this.m00 * vector.x + this.m01 * vector.y + this.m02 * vector.z;
            res.y = this.m10 * vector.x + this.m11 * vector.y + this.m12 * vector.z;
            res.z = this.m20 * vector.x + this.m21 * vector.y + this.m22 * vector.z;
            return res;
        }

        public static Matrix3x3 FromEuler (Vector3 v)
        {
            float cx = Mathf.Cos (v.x);
            float sx = Mathf.Sin (v.x);
            float cy = Mathf.Cos (v.y);
            float sy = Mathf.Sin (v.y);
            float cz = Mathf.Cos (v.z);
            float sz = Mathf.Sin (v.z);

            var matrix = new Matrix3x3();
            matrix[0,0] = cy*cz + sx*sy*sz;
            matrix[0,1] = cz*sx*sy - cy*sz;
            matrix[0,2] = cx*sy;
    
            matrix[1,0] = cx*sz;
            matrix[1,1] = cx*cz;
            matrix[1,1] = -sx;
    
            matrix[2,0] = -cz*sy + cy*sx*sz;
            matrix[2,1] = cy*cz*sx + sy*sz;
            matrix[2,2] = cx*cy;

            return matrix;
        }
        
        public bool ToEuler(out Vector3 v)
        {
            v = new Vector3();
            // from http://www.geometrictools.com/Documentation/EulerAngles.pdf
            // YXZ order
            if ( m12 < 0.999F ) // some fudge for imprecision
            {
                if ( m12 > -0.999F ) // some fudge for imprecision
                {
                    v.x = Mathf.Asin(-m12);
                    v.y = Mathf.Atan2(m02, m22);
                    v.z = Mathf.Atan2(m10, m11);
                    SanitizeEuler (out v);
                    return true;
                }
                else
                {
                    // WARNING.  Not unique.  YA - ZA = atan2(r01,r00)
                    v.x = Mathf.PI * 0.5F;
                    v.y = Mathf.Atan2(m01, m00);
                    v.z = 0.0F;
                    SanitizeEuler (out v);
            
                    return false;
                }
            }
            else
            {
                // WARNING.  Not unique.  YA + ZA = atan2(-r01,r00)
                v.x = -(float)Math.PI * 0.5F;
                v.y = Mathf.Atan2(-m01,m00);
                v.z = 0.0F;
                SanitizeEuler (out v);
                return false;
            }
        }
        
        void SanitizeEuler (out Vector3 euler)
        {
            MakePositive (out euler);
            /*
             Vector3f option0 = euler;
             option0.x = kPI - option0.x;
             option0.y = kPI - option0.y;
             option0.z = kPI - option0.z;
             
             MakePositive (euler);
             MakePositive (option0);
             if (option0.x+option0.y+option0.z < euler.x+euler.y+euler.z)
             euler = option0;
             */
        }
        
        void MakePositive (out Vector3 euler)
        {
            euler = new Vector3();
            const float negativeFlip = -0.0001F;
            const float positiveFlip = (Mathf.PI * 2.0F) - 0.0001F;
	
            if (euler.x < negativeFlip)
                euler.x += 2.0f * Mathf.PI;
            else if (euler.x > positiveFlip)
                euler.x -= 2.0f * Mathf.PI;
    
            if (euler.y < negativeFlip)
                euler.y += 2.0f * Mathf.PI;
            else if (euler.y > positiveFlip)
                euler.y -= 2.0f * Mathf.PI;
    
            if (euler.z < negativeFlip)
                euler.z += 2.0f * Mathf.PI;
            else if (euler.z > positiveFlip)
                euler.z -= 2.0f * Mathf.PI;
        }
        
        
        
        // Matrix4x4.zero is of questionable usefulness considering C# sets everything to 0 by default, however:
        //  1. it's consistent with other Math structs in Unity such as Vector2, Vector3 and Vector4,
        //  2. "Matrix4x4.zero" is arguably more readable than "new Matrix4x4()",
        //  3. it's already in the API ..

        // Returns a matrix with all elements set to zero (RO).
        public static Matrix3x3 zero { get; } = new Matrix3x3(
            new Vector3(0, 0, 0),
            new Vector3(0, 0, 0),
            new Vector3(0, 0, 0));

        static readonly Matrix3x3 IdentityMatrix = new Matrix3x3(
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(0, 0, 1));

        // Returns the identity matrix (RO).
        public static Matrix3x3 identity    { get { return IdentityMatrix; } }
        
        
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
            return String.Format(
                "{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}",
                m00.ToString(format, formatProvider), 
                m01.ToString(format, formatProvider),
                m02.ToString(format, formatProvider),
                
                m10.ToString(format, formatProvider), 
                m11.ToString(format, formatProvider),
                m12.ToString(format, formatProvider),
                
                m20.ToString(format, formatProvider), 
                m21.ToString(format, formatProvider),
                m22.ToString(format, formatProvider));
        }
    }
}