using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuChallange
{
  public class Sudoku
  {
    private int[][] _board;
    private List<int> colValues;

    public Sudoku(int[][] sudokuData)
    {
      _board = sudokuData;
    }

    public bool IsValid()
    {
      bool result = false;
      var rows = _board.Length;
      var cols = _board[0].Length;

      int microAreaLength = Convert.ToInt32(Math.Sqrt(_board.Length));

      for (int i = 0; i < rows; i++)
      {
        if (!(IsRowDataValid(_board[i]) && IsColumnDataValid(colValues, cols)))
        {
          return false;
        }
        result = true;
      }

      if (result)
      {
        for (int k = 0; k < rows; k += microAreaLength)
        {
          for (int j = 0; j < cols; j += microAreaLength)
          {
            var areaValues = GetMicroAreaValues(_board, k, j, microAreaLength);
            if (!IsAreaValuesValid(areaValues))
            {
              return false;
            }
            result = true;
          }
        }
      }

      return result;
    }

    private bool IsAreaValuesValid(List<int> areaValues)
    {
      return areaValues.Count == areaValues.Distinct().Count();
    }

    private List<int> GetMicroAreaValues(int[][] data, int row, int col, int microAreaLength)
    {
      ////int[,] areaValues = new int[microAreaLength, microAreaLength];

      var result = new List<int>();

      for (int i = row; i < microAreaLength + row; i++)
      {
        result.AddRange(_board[i].Skip(col).Take(microAreaLength));
      }

      return result;
    }

    private bool IsColumnDataValid(List<int> col, int colElements)
    {
      var distinctValue = col.Distinct();
      return distinctValue.Count() == colElements;
    }

    private bool IsRowDataValid(int[] values)
    {
      bool result = false;
      List<int> nums = values.Distinct().ToList();

      if (nums.Count != values.Length)
      {
        return result;
      }

      colValues = new List<int>();

      for (int j = 0; j < values.Length; j++)
      {
        try
        {
          colValues.Add(_board[j][0]);
        }
        catch (Exception)
        {
          result = false;
        }
        nums.RemoveAll(n => n == values[j]);
        if (nums.Count == values.GetLength(0) - j - 1)
        {
          result = true;
        }
      }
      return result;
    }
  }
}
