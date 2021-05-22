using System;
using System.Globalization;

namespace MathLib
{
    public partial struct Quaternion : IEquatable<Quaternion>, IFormattable
    {
        // X component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        public float x;
        // Y component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        public float y;
        // Z component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        public float z;
        // W component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        public float w;

        // Access the x, y, z, w components using [0], [1], [2], [3] respectively.
        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
                    default:
                        throw new IndexOutOfRangeException("Invalid Quaternion index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    case 3: w = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid Quaternion index!");
                }
            }
        }

        // Constructs new Quaternion with given x,y,z,w components.
        public Quaternion(float x, float y, float z, float w) { this.x = x; this.y = y; this.z = z; this.w = w; }

        // Set x, y, z and w components of an existing Quaternion.
        public void Set(float newX, float newY, float newZ, float newW)
        {
            x = newX;
            y = newY;
            z = newZ;
            w = newW;
        }

        static readonly Quaternion identityQuaternion = new Quaternion(0F, 0F, 0F, 1F);

        // The identity rotation (RO). This quaternion corresponds to "no rotation": the object
        public static Quaternion identity
        {
            get
            {
                return identityQuaternion;
            }
        }

        // Combines rotations /lhs/ and /rhs/.
        public static Quaternion operator*(Quaternion lhs, Quaternion rhs)
        {
            return new Quaternion(
                lhs.w * rhs.x + lhs.x * rhs.w + lhs.y * rhs.z - lhs.z * rhs.y,
                lhs.w * rhs.y + lhs.y * rhs.w + lhs.z * rhs.x - lhs.x * rhs.z,
                lhs.w * rhs.z + lhs.z * rhs.w + lhs.x * rhs.y - lhs.y * rhs.x,
                lhs.w * rhs.w - lhs.x * rhs.x - lhs.y * rhs.y - lhs.z * rhs.z);
        }

        // Rotates the point /point/ with /rotation/.
        public static Vector3 operator*(Quaternion rotation, Vector3 point)
        {
            float x = rotation.x * 2F;
            float y = rotation.y * 2F;
            float z = rotation.z * 2F;
            float xx = rotation.x * x;
            float yy = rotation.y * y;
            float zz = rotation.z * z;
            float xy = rotation.x * y;
            float xz = rotation.x * z;
            float yz = rotation.y * z;
            float wx = rotation.w * x;
            float wy = rotation.w * y;
            float wz = rotation.w * z;

            Vector3 res;
            res.x = (1F - (yy + zz)) * point.x + (xy - wz) * point.y + (xz + wy) * point.z;
            res.y = (xy + wz) * point.x + (1F - (xx + zz)) * point.y + (yz - wx) * point.z;
            res.z = (xz - wy) * point.x + (yz + wx) * point.y + (1F - (xx + yy)) * point.z;
            return res;
        }

        // *undocumented*
        public const float kEpsilon = 0.000001F;

        // Is the dot product of two quaternions within tolerance for them to be considered equal?
        private static bool IsEqualUsingDot(float dot)
        {
            // Returns false in the presence of NaN values.
            return dot > 1.0f - kEpsilon;
        }

        // Are two quaternions equal to each other?
        public static bool operator==(Quaternion lhs, Quaternion rhs)
        {
            return IsEqualUsingDot(Dot(lhs, rhs));
        }

        // Are two quaternions different from each other?
        public static bool operator!=(Quaternion lhs, Quaternion rhs)
        {
            // Returns true in the presence of NaN values.
            return !(lhs == rhs);
        }

        // The dot product between two rotations.
        public static float Dot(Quaternion a, Quaternion b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }

        public void SetLookRotation(Vector3 view)
        {
            Vector3 up = Vector3.up;
            SetLookRotation(view, up);
        }

        // Creates a rotation with the specified /forward/ and /upwards/ directions.
        public void SetLookRotation(Vector3 view,  Vector3 up)
        {
            this = LookRotation(view, up);
        }

        // Returns the angle in degrees between two rotations /a/ and /b/.
        public static float Angle(Quaternion a, Quaternion b)
        {
            float dot = Dot(a, b);
            return IsEqualUsingDot(dot) ? 0.0f : Mathf.Acos(Mathf.Min(Mathf.Abs(dot), 1.0F)) * 2.0F * Mathf.Rad2Deg;
        }

        // Makes euler angles positive 0/360 with 0.0001 hacked to support old behaviour of QuaternionToEuler
        private static Vector3 Internal_MakePositive(Vector3 euler)
        {
            float negativeFlip = -0.0001f * Mathf.Rad2Deg;
            float positiveFlip = 360.0f + negativeFlip;

            if (euler.x < negativeFlip)
                euler.x += 360.0f;
            else if (euler.x > positiveFlip)
                euler.x -= 360.0f;

            if (euler.y < negativeFlip)
                euler.y += 360.0f;
            else if (euler.y > positiveFlip)
                euler.y -= 360.0f;

            if (euler.z < negativeFlip)
                euler.z += 360.0f;
            else if (euler.z > positiveFlip)
                euler.z -= 360.0f;

            return euler;
        }

        public Vector3 eulerAngles
        {
            get { return Internal_MakePositive(Internal_ToEulerRad(this) * Mathf.Rad2Deg); }
            set { this = Internal_FromEulerRad(value * Mathf.Deg2Rad); }
        }
        public static Quaternion Euler(float x, float y, float z) { return Internal_FromEulerRad(new Vector3(x, y, z) * Mathf.Deg2Rad); }
        public static Quaternion Euler(Vector3 euler) { return Internal_FromEulerRad(euler * Mathf.Deg2Rad); }
        public void ToAngleAxis(out float angle, out Vector3 axis) { Internal_ToAxisAngleRad(this, out axis, out angle); angle *= Mathf.Rad2Deg;  }
        public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection) { this = FromToRotation(fromDirection, toDirection); }

        public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
        {
            float angle = Quaternion.Angle(from, to);
            if (angle == 0.0f) return to;
            return SlerpUnclamped(from, to, Mathf.Min(1.0f, maxDegreesDelta / angle));
        }

        public static Quaternion Normalize(Quaternion q)
        {
            float mag = Mathf.Sqrt(Dot(q, q));

            if (mag < Mathf.Epsilon)
                return Quaternion.identity;

            return new Quaternion(q.x / mag, q.y / mag, q.z / mag, q.w / mag);
        }

        public void Normalize()
        {
            this = Normalize(this);
        }

        public Quaternion normalized
        {
            get { return Normalize(this); }
        }

        // used to allow Quaternions to be used as keys in hash tables
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2) ^ (w.GetHashCode() >> 1);
        }

        // also required for being able to use Quaternions as keys in hash tables
        public override bool Equals(object other)
        {
            if (!(other is Quaternion)) return false;

            return Equals((Quaternion)other);
        }

        public bool Equals(Quaternion other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w);
        }

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
                format = "F1";
            return String.Format("({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

    }
    
    public partial struct Quaternion
    {
        public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
        {
            var lhs = fromDirection;
            var rhs = toDirection;
            float lhsMag = Vector3.Magnitude (lhs);
            float rhsMag = Vector3.Magnitude (rhs);
            if (lhsMag < Vector3.kEpsilon || rhsMag < Vector3.kEpsilon)
            {
                return Quaternion.identity;
            }
            else
            {
                var from = lhs / lhsMag;
                var to = rhs / rhsMag;
                var m = Matrix3x3.FromToRotation(from, to);
                var q = FromMatrix3x3(m) ;
                return q;
            }
        }

        public static Quaternion Inverse(Quaternion rotation)
        {
            return rotation.Conjugate();
        }

        public Quaternion Conjugate()
        {
            return new Quaternion (-x, -y, -z, w);
        }

        public static Quaternion Slerp(Quaternion q1, Quaternion q2, float t)
        {
            //	Quaternionf q3 = new Quaternionf();
            float dot = Dot( q1, q2 );

            // dot = cos(theta)
            // if (dot < 0), q1 and q2 are more than 90 degrees apart,
            // so we can invert one to reduce spinning
            Quaternion tmpQuat = new Quaternion();
            if (dot < 0.0f )
            {
                dot = -dot;
                tmpQuat.Set( -q2.x,
                    -q2.y,
                    -q2.z,
                    -q2.w );
            }
            else
                tmpQuat = q2;

	
            if (dot < 0.95f )
            {
                float angle = Mathf.Acos(dot);
                float sinadiv, sinat, sinaomt;
                sinadiv = 1.0f / Mathf.Sin(angle);
                sinat   = Mathf.Sin(angle*t);
                sinaomt = Mathf.Sin(angle*(1.0f-t));
                tmpQuat.Set( (q1.x*sinaomt+tmpQuat.x*sinat)*sinadiv,
                    (q1.y*sinaomt+tmpQuat.y*sinat)*sinadiv,
                    (q1.z*sinaomt+tmpQuat.z*sinat)*sinadiv, 
                    (q1.w*sinaomt+tmpQuat.w*sinat)*sinadiv  );
                // AssertIf (!CompareApproximately (SqrMagnitude (tmpQuat), 1.0F));
                return tmpQuat;

            }
            // if the angle is small, use linear interpolation
            else
            {
                return Lerp(q1,tmpQuat,t);
            }
        }

        public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
        {
            throw new NotImplementedException();
        }

        public static Quaternion Lerp(Quaternion q1, Quaternion q2, float t)
        {
            Quaternion tmpQuat = new Quaternion();
            // if (dot < 0), q1 and q2 are more than 360 deg apart.
            // The problem is that quaternions are 720deg of freedom.
            // so we - all components when lerping
            if (Dot (q1, q2) < 0.0F)
            {
                tmpQuat.Set(q1.x + t * (-q2.x - q1.x),
                    q1.y + t * (-q2.y - q1.y),
                    q1.z + t * (-q2.z - q1.z),
                    q1.w + t * (-q2.w - q1.w));
            }
            else
            {
                tmpQuat.Set(q1.x + t * (q2.x - q1.x),
                    q1.y + t * (q2.y - q1.y),
                    q1.z + t * (q2.z - q1.z),
                    q1.w + t * (q2.w - q1.w));
            }
            return Normalize (tmpQuat);
        }

        public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
        {
            throw new NotImplementedException();
        }

        private static Quaternion Internal_FromEulerRad(Vector3 euler)
        {
            float cX  = Mathf.Cos (euler.x / 2.0f);
            float sX  = Mathf.Sin (euler.x / 2.0f);

            float cY =  Mathf.Cos (euler.y / 2.0f);
            float sY = Mathf.Sin (euler.y / 2.0f);

            float cZ = Mathf.Cos (euler.z / 2.0f);
            float sZ = Mathf.Sin (euler.z / 2.0f);
	
            Quaternion qX = new Quaternion(sX, 0.0F, 0.0F, cX);
            Quaternion qY = new Quaternion(0.0F, sY, 0.0F, cY);
            Quaternion qZ = new Quaternion(0.0F, 0.0F, sZ, cZ);
	
            Quaternion q = (qY * qX) * qZ;
            // AssertIf (!CompareApproximately (SqrMagnitude (q), 1.0F));
            return q;    
        }

        private static Vector3 Internal_ToEulerRad(Quaternion rotation)
        {
            Matrix3x3 m;
            Vector3 rot = new Vector3();
            m = ToMatrix3x3(rotation.normalized);
            m.ToEuler (ref rot);
            return rot;
        }

        public static Quaternion FromMatrix3x3(Matrix3x3 m)
        {
            var kRot = m;
            var q = new Quaternion();
            float fTrace = kRot.m00 + kRot.m11 + kRot.m22;
            float fRoot;

            if ( fTrace > 0.0f )
            {
                // |w| > 1/2, may as well choose w > 1/2
                fRoot = Mathf.Sqrt (fTrace + 1.0f);  // 2w
                q.w = 0.5f*fRoot;
                fRoot = 0.5f/fRoot;  // 1/(4w)
                q.x = (kRot.m21 - kRot.m12)*fRoot;
                q.y = (kRot.m02 - kRot.m20)*fRoot;
                q.z = (kRot.m10 - kRot.m01)*fRoot;
            }
            else
            {
                // |w| <= 1/2
                int[] s_iNext = { 1, 2, 0 };
                int i = 0;
                if ( kRot.m11 > kRot.m00 )
                    i = 1;
                if ( kRot.m22 > kRot[i, i] )
                    i = 2;
                int j = s_iNext[i];
                int k = s_iNext[j];

                fRoot = Mathf.Sqrt (kRot[i, i] - kRot[j, j] - kRot[k, k] + 1.0f);
                float[] apkQuat = { q.x, q.y, q.z };
                // AssertIf (fRoot < Vector3.kEpsilon);
                apkQuat[i] = 0.5f*fRoot;
                fRoot = 0.5f / fRoot;
                q.w = (kRot[k, j] - kRot[j, k]) * fRoot;
                apkQuat[j] = (kRot[j, i] + kRot[i, j]) * fRoot;
                apkQuat[k] = (kRot[k, i] + kRot[i, k]) * fRoot;
            }
            q = Normalize (q);
            return q;
        }
        
        public static Matrix3x3 ToMatrix3x3(Quaternion rotation)
        {
            var q = rotation;
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

            Matrix3x3 m = new Matrix3x3();
            // Calculate 3x3 matrix from orthonormal basis
            m[0] = 1.0f - (yy + zz);
            m[1] = xy + wz;
            m[2] = xz - wy;

            m[3] = xy - wz;
            m[4] = 1.0f - (xx + zz);
            m[5] = yz + wx;
	
            m[6]  = xz + wy;
            m[7]  = yz - wx;
            m[8] = 1.0f - (xx + yy);

            return m;
        }

        public static Quaternion FromMatrix4x4(Matrix4x4 m)
        {
            var m3 = new Matrix3x3(
                m.m00, m.m01, m.m02,
                m.m00, m.m01, m.m02,
                m.m00, m.m01, m.m02);
            return FromMatrix3x3(m3);
        }
        
        public static Matrix4x4 ToMatrix4x4(Quaternion rotation)
        {
            var q = rotation;
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

            Matrix4x4 m = new Matrix4x4();
            // Calculate 3x3 matrix from orthonormal basis
            m[0] = 1.0f - (yy + zz);
            m[1] = xy + wz;
            m[2] = xz - wy;
            m[3] = 0.0F;

            m[4] = xy - wz;
            m[5] = 1.0f - (xx + zz);
            m[6] = yz + wx;
            m[7] = 0.0F;

            m[8]  = xz + wy;
            m[9]  = yz - wx;
            m[10] = 1.0f - (xx + yy);
            m[11] = 0.0F;

            m[12] = 0.0F;
            m[13] = 0.0F;
            m[14] = 0.0F;
            m[15] = 1.0F;
            
            return m;
        }

        public static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float targetAngle)
        {
            q = q.normalized;
            //AssertIf (! CompareApproximately(SqrMagnitude (q), 1.0F));
            targetAngle = 2.0f * Mathf.Acos(q.w);
            if (Mathf.Approximately (targetAngle, 0.0F))
            {
                axis = Vector3.right;
                return;
            }
		
            float div = 1.0f / Mathf.Sqrt(1.0f - q.w * q.w);
            axis = new Vector3(q.x*div, q.y*div, q.z*div);
        }

        public static Quaternion AngleAxis(float angle, Vector3 axis)
        {
            var rad = angle * Mathf.Deg2Rad;
            Quaternion q = new Quaternion();
            float mag = axis.magnitude;
            if (mag > 0.000001F)
            {
                float halfAngle = angle * 0.5F;
		
                q.w = Mathf.Cos (halfAngle);

                float s = Mathf.Sin (halfAngle) / mag;
                q.x = s * axis.x;
                q.y = s * axis.y;
                q.z = s * axis.z;
                return q;
            }
            else
            {
                return Quaternion.identity;
            }

        }

        public static Quaternion LookRotation(Vector3 forward, Vector3 upwards)
        {
            Matrix3x3 m;
            if (!Matrix3x3.LookRotationToMatrix (forward, upwards, out m))
                return Quaternion.identity;
            return FromMatrix3x3(m);
        }
        public static Quaternion LookRotation(Vector3 forward) { return LookRotation(forward, Vector3.up); }
    }
    
}