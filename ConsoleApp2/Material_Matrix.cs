using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Material_Matrix
    {
        private float[,] matrix;
        public int rows, cols;
        private int l;


        public float[,] Matrix { get => matrix; set => matrix = value; }
        public int Rows { get => rows; set => rows = value; }
        public int Cols { get => cols; set => cols = value; }
        public int L { get => l; set => l = value; }
        public Material_Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new float[this.rows, this.cols];
            l = rows * cols;
        }
        public float this[int index1, int index2]
        {
            get
            {
                return matrix[index1, index2];
            }

            set
            {
                matrix[index1, index2] = value;
            }
        }


    }
}
