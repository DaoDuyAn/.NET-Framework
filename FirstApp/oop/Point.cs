using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.oop
{
    public class Point : System.Object
    {
        #region Properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion

        #region Constructor Methods

        #endregion

        #region Member Methods
        /// <summary>
        /// Tính khoảng cách từ điểm hiện tại đến gốc tạo độ O(0,0)
        /// </summary>
        /// <returns>Khoảng cách giữa hai điểm</returns>
        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }

        /// <summary>
        /// Tính khoảng cách từ điểm hiện tại tới điểm p
        /// </summary>
        /// <param name="p">Điểm cần tính khoảng cách</param>
        /// <returns>Khoảng cách giữa 2 điểm</returns>
        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        }
        #endregion

        #region Static Methods
        public static double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point
            {
                x = a.x + b.x,
                y = a.y + b.y
            };
        }
        #endregion

        #region Override Methods
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is Point)
            {
                Point p = (Point) obj;
                //Point p = obj as Point;

                if (x == p.x && y == p.y) return true;
                else return false;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return $"Point({x}, {y})";
        }
        #endregion

    }
}
