using System;

namespace MathLib
{
    public partial struct Bounds : IEquatable<Bounds>
    {
        private Vector3 m_Center;
        private Vector3 m_Extents;

        // Creates new Bounds with a given /center/ and total /size/. Bound ::ref::extents will be half the given size.
        public Bounds(Vector3 center, Vector3 size)
        {
            m_Center = center;
            m_Extents = size * 0.5F;
        }

        // used to allow Bounds to be used as keys in hash tables
        public override int GetHashCode()
        {
            return center.GetHashCode() ^ (extents.GetHashCode() << 2);
        }

        // also required for being able to use Vector4s as keys in hash tables
        public override bool Equals(object other)
        {
            if (!(other is Bounds)) return false;

            return Equals((Bounds)other);
        }

        public bool Equals(Bounds other)
        {
            return center.Equals(other.center) && extents.Equals(other.extents);
        }

        // The center of the bounding box.
        public Vector3 center { get { return m_Center; } set { m_Center = value; } }

        // The total size of the box. This is always twice as large as the ::ref::extents.
        public Vector3 size { get { return m_Extents * 2.0F; } set { m_Extents = value * 0.5F; } }

        // The extents of the box. This is always half of the ::ref::size.
        public Vector3 extents { get { return m_Extents; } set { m_Extents = value; } }

        // The minimal point of the box. This is always equal to ''center-extents''.
        public Vector3 min { get { return center - extents; } set { SetMinMax(value, max); } }

        // The maximal point of the box. This is always equal to ''center+extents''.
        public Vector3 max { get { return center + extents; } set { SetMinMax(min, value); } }

        //*undoc*
        public static bool operator==(Bounds lhs, Bounds rhs)
        {
            // Returns false in the presence of NaN values.
            return (lhs.center == rhs.center && lhs.extents == rhs.extents);
        }

        //*undoc*
        public static bool operator!=(Bounds lhs, Bounds rhs)
        {
            // Returns true in the presence of NaN values.
            return !(lhs == rhs);
        }

        // Sets the bounds to the /min/ and /max/ value of the box.
        public void SetMinMax(Vector3 min, Vector3 max)
        {
            extents = (max - min) * 0.5F;
            center = min + extents;
        }

        // Grows the Bounds to include the /point/.
        public void Encapsulate(Vector3 point)
        {
            SetMinMax(Vector3.Min(min, point), Vector3.Max(max, point));
        }

        // Grows the Bounds to include the /Bounds/.
        public void Encapsulate(Bounds bounds)
        {
            Encapsulate(bounds.center - bounds.extents);
            Encapsulate(bounds.center + bounds.extents);
        }

        // Expand the bounds by increasing its /size/ by /amount/ along each side.
        public void Expand(float amount)
        {
            amount *= .5f;
            extents += new Vector3(amount, amount, amount);
        }

        // Expand the bounds by increasing its /size/ by /amount/ along each side.
        public void Expand(Vector3 amount)
        {
            extents += amount * .5f;
        }

        // Does another bounding box intersect with this bounding box?
        public bool Intersects(Bounds bounds)
        {
            return (min.x <= bounds.max.x) && (max.x >= bounds.min.x) &&
                (min.y <= bounds.max.y) && (max.y >= bounds.min.y) &&
                (min.z <= bounds.max.z) && (max.z >= bounds.min.z);
        }

        public bool IntersectRay(Ray ray) { float dist1; return IntersectRayAABB(ray, this, out dist1, out var dist2); }
        public bool IntersectRay(Ray ray, out float distance1, out float distance2) { return IntersectRayAABB(ray, this, out distance1, out distance2); }


        /// *listonly*
        override public string ToString()
        {
            return String.Format("Center: {0}, Extents: {1}", m_Center, m_Extents);
        }

        // Returns a nicely formatted string for the bounds.
        public string ToString(string format)
        {
            return String.Format("Center: {0}, Extents: {1}", m_Center.ToString(format), m_Extents.ToString(format));
        }
    }
    
    public partial struct Bounds
    {
        public bool Contains(Vector3 point)
        {
            return min.x <= point.x && max.x > point.x &&
                   min.y <= point.y && max.y > point.y &&
                   min.z <= point.z && max.z > point.z;
        }

        public float SqrDistance(Vector3 point)
        {
            Vector3 closest = point - center;
            float sqrDistance = 0.0f;
	
            for (int i = 0; i < 3; ++i)
            {
                float clos = closest[i];
                float ext = extents[i];
                if (clos < -ext)
                {
                    float delta = clos + ext;
                    sqrDistance += delta * delta;
                    closest[i] = -ext;
                }
                else if (clos > ext)
                {
                    float delta = clos - ext;
                    sqrDistance += delta * delta;
                    closest[i] = ext;
                }
            }

            return sqrDistance;
        }

        private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist1, out float dist2)
        {
            dist1 = dist2 = Mathf.Infinity;
            float tmin = -Mathf.Infinity;
            float tmax = Mathf.Infinity;
	
            float t0, t1, f;
	
            Vector3 p = bounds.center - ray.origin;
            Vector3 extent = bounds.extents;
            int i;
            for (i=0;i<3;i++)
            {
                // ray and plane are paralell so no valid intersection can be found
                {
                    f = 1.0F / ray.direction[i];
                    t0 = (p[i] + extent[i]) * f;
                    t1 = (p[i] - extent[i]) * f;
                    // Ray leaves on Right, Top, Back Side
                    if (t0 < t1)
                    {
                        if (t0 > tmin)
                            tmin = t0;
				
                        if (t1 < tmax)
                            tmax = t1;
				
                        if (tmin > tmax)
                            return false;
				
                        if (tmax < 0.0F)
                            return false;
                    }
                    // Ray leaves on Left, Bottom, Front Side
                    else
                    {
                        if (t1 > tmin)
                            tmin = t1;
				
                        if (t0 < tmax)
                            tmax = t0;
				
                        if (tmin > tmax)
                            return false;
				
                        if (tmax < 0.0F)
                            return false;
                    }
                }
            }
	
            dist1 = tmin;
            dist2 = tmax;
	
            return true;
        }

        public Vector3 ClosestPoint(Vector3 point, out float distance)
        {
            // compute coordinates of point in box coordinate system
            Vector3 closest = point - center;
            Vector3 outPoint;

            // project test point onto box
            float fSqrDistance = 0.0f;
            float fDelta;
	
            for (int i=0;i<3;i++)
            {
                if ( closest[i] < -extents[i] )
                {
                    fDelta = closest[i] + extents[i];
                    fSqrDistance += fDelta * fDelta;
                    closest[i] = -extents[i];
                }
                else if ( closest[i] > extents[i] )
                {
                    fDelta = closest[i] - extents[i];
                    fSqrDistance += fDelta * fDelta;
                    closest[i] = extents[i];
                }
            }
	
            // Inside
            if (fSqrDistance == 0.0F)
            {
                outPoint = point;
                distance = 0.0F;
            }
            // Outside
            else
            {
                outPoint = closest + center;
                distance = fSqrDistance;
            }

            return outPoint;
        }
    }
}