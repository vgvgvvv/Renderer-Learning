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

        public Matrix3x3(
            float m00, float m01, float m02,
            float m10, float m11, float m12,
            float m20, float m21, float m22)
        {
            this.m00 = m00; this.m01 = m01; this.m02 = m02; 
            this.m10 = m10; this.m11 = m11; this.m12 = m12; 
            this.m20 = m20; this.m21 = m21; this.m22 = m22; 
        }

        // Access element at [row, column].
        public float this[int row, int column]
        {
            get
            {
                return this[row + column * 3];
            }

            set
            {
                this[row + column * 3] = value;
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
                    case 3: return m01;
                    case 4: return m11;
                    case 5: return m21;
                    case 6: return m02;
                    case 7: return m12;
                    case 8: return m22;
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
                    case 3: m01 = value; break;
                    case 4: m11 = value; break;
                    case 5: m21 = value; break;
                    case 6: m02 = value; break;
                    case 7: m12 = value; break;
                    case 8: m22 = value; break;

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
            Matrix3x3 res = identity;
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
            matrix[1,2] = -sx;
    
            matrix[2,0] = -cz*sy + cy*sx*sz;
            matrix[2,1] = cy*cz*sx + sy*sz;
            matrix[2,2] = cx*cy;

            return matrix;
        }
        
        public bool ToEuler(ref Vector3 v)
        {
            // from http://www.geometrictools.com/Documentation/EulerAngles.pdf
            // YXZ order
            if ( m12 < 0.999F ) // some fudge for imprecision
            {
                if ( m12 > -0.999F ) // some fudge for imprecision
                {
                    v.x = Mathf.Asin(-m12);
                    v.y = Mathf.Atan2(m02, m22);
                    v.z = Mathf.Atan2(m10, m11);
                    SanitizeEuler (ref v);
                    return true;
                }
                else
                {
                    // WARNING.  Not unique.  YA - ZA = atan2(r01,r00)
                    v.x = Mathf.PI * 0.5F;
                    v.y = Mathf.Atan2(m01, m00);
                    v.z = 0.0F;
                    SanitizeEuler (ref v);
            
                    return false;
                }
            }
            else
            {
                // WARNING.  Not unique.  YA + ZA = atan2(-r01,r00)
                v.x = -(float)Math.PI * 0.5F;
                v.y = Mathf.Atan2(-m01,m00);
                v.z = 0.0F;
                SanitizeEuler (ref v);
                return false;
            }
        }
        
        void SanitizeEuler (ref Vector3 euler)
        {
            MakePositive (ref euler);
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
        
        void MakePositive (ref Vector3 euler)
        {
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

        public static Matrix3x3 FromToRotation(Vector3 from, Vector3 to)
        {
            var mtx = new Matrix3x3();
            Vector3 v;
	        float e,h;
            v = Vector3.Cross(from, to);
	        e=Vector3.Dot(from,to);
	        if(e > 1.0 - Mathf.Epsilon)     /* "from" almost or equal to "to"-vector? */
	        {
		        /* return identity */
		        mtx[0,0]=1.0f; mtx[0,1]=0.0f; mtx[0,2]=0.0f;
		        mtx[1,0]=0.0f; mtx[1,1]=1.0f; mtx[1,2]=0.0f;
		        mtx[2,0]=0.0f; mtx[2,1]=0.0f; mtx[2,2]=1.0f;
	        }
	        else if(e < -1.0 + Mathf.Epsilon) /* "from" almost or equal to negated "to"? */
            {
                Vector3 up = new Vector3();
                Vector3 left = new Vector3();
		        float invlen;
		        float fxx,fyy,fzz,fxy,fxz,fyz;
		        float uxx,uyy,uzz,uxy,uxz,uyz;
		        float lxx,lyy,lzz,lxy,lxz,lyz;
		        /* left=CROSS(from, (1,0,0)) */
		        left[0]=0.0f; left[1]=from[2]; left[2]=-from[1];
		        if(Vector3.Dot(left,left) < Mathf.Epsilon) /* was left=CROSS(from,(1,0,0)) a good choice? */
		        {
			        /* here we now that left = CROSS(from, (1,0,0)) will be a good choice */
			        left[0]=-from[2]; left[1]=0.0f; left[2]=from[0];
		        }
		        /* normalize "left" */
		        invlen=1.0f / Mathf.Sqrt(Vector3.Dot(left,left));
		        left[0]*=invlen;
		        left[1]*=invlen;
		        left[2]*=invlen;
		        up = Vector3.Cross(left,from);
		        /* now we have a coordinate system, i.e., a basis;    */
		        /* M=(from, up, left), and we want to rotate to:      */
		        /* N=(-from, up, -left). This is done with the matrix:*/
		        /* N*M^T where M^T is the transpose of M              */
		        fxx=-from[0]*from[0]; fyy=-from[1]*from[1]; fzz=-from[2]*from[2];
		        fxy=-from[0]*from[1]; fxz=-from[0]*from[2]; fyz=-from[1]*from[2];

		        uxx=up[0]*up[0]; uyy=up[1]*up[1]; uzz=up[2]*up[2];
		        uxy=up[0]*up[1]; uxz=up[0]*up[2]; uyz=up[1]*up[2];

		        lxx=-left[0]*left[0]; lyy=-left[1]*left[1]; lzz=-left[2]*left[2];
		        lxy=-left[0]*left[1]; lxz=-left[0]*left[2]; lyz=-left[1]*left[2];
		        /* symmetric matrix */
		        mtx[0,0]=fxx+uxx+lxx; mtx[0,1]=fxy+uxy+lxy; mtx[0,2]=fxz+uxz+lxz;
		        mtx[1,0]=mtx[0,1];   mtx[1,1]=fyy+uyy+lyy; mtx[1,2]=fyz+uyz+lyz;
		        mtx[2,0]=mtx[0,2];   mtx[2,1]=mtx[1,2];   mtx[2,2]=fzz+uzz+lzz;
	        }
	        else  /* the most common case, unless "from"="to", or "from"=-"to" */
	        {
		        /* ...otherwise use this hand optimized version (9 mults less) */
		        float hvx,hvz,hvxy,hvxz,hvyz;
		        h=(1.0f-e)/Vector3.Dot(v,v);
		        hvx=h*v[0];
		        hvz=h*v[2];
		        hvxy=hvx*v[1];
		        hvxz=hvx*v[2];
		        hvyz=hvz*v[1];
		        mtx[0,0]=e+hvx*v[0]; mtx[0,1]=hvxy-v[2];     mtx[0,2]=hvxz+v[1];
		        mtx[1,0]=hvxy+v[2];  mtx[1,1]=e+h*v[1]*v[1]; mtx[1,2]=hvyz-v[0];
		        mtx[2,0]=hvxz-v[1];  mtx[2,1]=hvyz+v[0];     mtx[2,2]=e+hvz*v[2];
	        }

            return mtx;
        }

        public static bool LookRotationToMatrix(Vector3 viewVec, Vector3 upVec, out Matrix3x3 m)
        {
            Vector3 z = viewVec;
            // compute u0
            float mag = z.magnitude;
            if (mag < Vector3.kEpsilon)
            {
                m = identity;
                return false;
            }
            z /= mag;

            Vector3 x = Vector3.Cross (upVec, z);
            mag = x.magnitude;
            if (mag < Vector3.kEpsilon)
            {
                m = identity;
                return false;
            }
            x /= mag;
	
            Vector3 y = (Vector3.Cross (z, x));
            if (!Mathf.Approximately(y.sqrMagnitude, 1.0F))
            {
                m = identity;
                return false;
            }

            m = new Matrix3x3();
            m.SetOrthoNormalBasis (x, y, z);
            return true;	
        }
        
        void SetIdentity()
        {
            this[0, 0] = 1.0F;	this[0, 1] = 0.0F;	this[0, 2] = 0.0F;
            this[1, 0] = 0.0F;	this[1, 1] = 1.0F;	this[1, 2] = 0.0F;
            this[2, 0] = 0.0F;	this[2, 1] = 0.0F;	this[2, 2] = 1.0F;
        }

        void SetZero ()
        {
            this[0, 0] = 0.0F;	this[0, 1] = 0.0F;	this[0, 2] = 0.0F;
            this[1, 0] = 0.0F;	this[1, 1] = 0.0F;	this[1, 2] = 0.0F;
            this[2, 0] = 0.0F;	this[2, 1] = 0.0F;	this[2, 2] = 0.0F;
        }

        void SetOrthoNormalBasis (Vector3 inX, Vector3 inY, Vector3 inZ)
        {
            this[0, 0] = inX[0];	this[0, 1] = inY[0];	this[0, 2] = inZ[0];
            this[1, 0] = inX[1];	this[1, 1] = inY[1];	this[1, 2] = inZ[1];
            this[2, 0] = inX[2];	this[2, 1] = inY[2];	this[2, 2] = inZ[2];
        }

        void SetOrthoNormalBasisInverse (Vector3 inX, Vector3 inY, Vector3 inZ)
        {
            this[0, 0] = inX[0];	this[1, 0] = inY[0];	this[2, 0] = inZ[0];
            this[0, 1] = inX[1];	this[1, 1] = inY[1];	this[2, 1] = inZ[1];
            this[0, 2] = inX[2];	this[1, 2] = inY[2];	this[2, 2] = inZ[2];
        }

        void SetScale (Vector3 inScale)
        {
            this[0, 0] = inScale[0];	this[0, 1] = 0.0F;			this[0, 2] = 0.0F;
            this[1, 0] = 0.0F;			this[1, 1] = inScale[1];	this[1, 2] = 0.0F;
            this[2, 0] = 0.0F;			this[2, 1] = 0.0F;			this[2, 2] = inScale[2];
        }

        bool IsIdentity (float threshold) {
            if (Mathf.Approximately (this[0,0],1.0f, threshold) && Mathf.Approximately (this[0,1],0.0f, threshold) && Mathf.Approximately (this[0,2],0.0f, threshold) &&
                Mathf.Approximately (this[1,0],0.0f, threshold) && Mathf.Approximately (this[1,1],1.0f, threshold) && Mathf.Approximately (this[1,2],0.0f, threshold) &&
                Mathf.Approximately (this[2,0],0.0f, threshold) && Mathf.Approximately (this[2,1],0.0f, threshold) && Mathf.Approximately (this[2,2],1.0f, threshold))
                return true;
            return false;
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