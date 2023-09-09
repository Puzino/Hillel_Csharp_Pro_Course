using System;
namespace Homework_4
{
	public class Matrix
	{

		private int rows;
		private int columns;
		private int[,] data;

		public Matrix(int rows, int columns)
		{
			this.rows = rows;
			this.columns = columns;
			data = new int[rows, columns];
		}

		public int Rows
		{
			get { return rows; }
		}

		public int Columns
		{
			get { return columns; }
		}

		public int this[int row, int col]
		{
			get { return data[row, col];  }
			set { data[row, col] = value; }
		}

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                throw new ArgumentException("Matrices must have the same dimensions for addition.");

            Matrix result = new Matrix(m1.Rows, m1.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                throw new ArgumentException("Matrices must have the same dimensions for subtraction.");

            Matrix result = new Matrix(m1.Rows, m1.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Columns != m2.Rows)
                throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix for multiplication.");

            Matrix result = new Matrix(m1.Rows, m2.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m1.Columns; k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix m, int scalar)
        {
            Matrix result = new Matrix(m.Rows, m.Columns);
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Columns; j++)
                {
                    result[i, j] = m[i, j] * scalar;
                }
            }
            return result;
        }

        public static bool operator ==(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                return false;

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    if (m1[i, j] != m2[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Matrix))
                return false;

            Matrix other = (Matrix)obj;

            if (Rows != other.Rows || Columns != other.Columns)
                return false;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (this[i, j] != other[i, j])
                        return false;
                }
            }
            return true;
        }
    }
}

