using NUnit.Framework;

namespace Sudoku.Test
{
  [TestFixture]
  public class SudokuTests
  {
    [Test]
    public void Test1()
    {
      var goodSudoku1 = new SudokuChallange.Sudoku(
        new int[][] {
      new int[] {7,8,4, 1,5,9, 3,2,6},
      new int[] {5,3,9, 6,7,2, 8,4,1},
      new int[] {6,1,2, 4,3,8, 7,5,9},

      new int[] {9,2,8, 7,1,5, 4,6,3},
      new int[] {3,5,7, 8,4,6, 1,9,2},
      new int[] {4,6,1, 9,2,3, 5,8,7},

      new int[] {8,7,6, 3,9,4, 2,1,5},
      new int[] {2,4,3, 5,6,1, 9,7,8},
      new int[] {1,9,5, 2,8,7, 6,3,4}
        });
      Assert.IsTrue(goodSudoku1.IsValid());
    }

    [Test]
    public void Test2()
    {
      var goodSudoku2 = new SudokuChallange.Sudoku(
        new int[][] {
            new int[] {1,4, 2,3},
            new int[] {3,2, 4,1},

            new int[] {4,1, 3,2},
            new int[] {2,3, 1,4}
      });
      Assert.IsTrue(goodSudoku2.IsValid());
    }

    [Test]
    public void Test3()
    {
      var badSudoku1 = new SudokuChallange.Sudoku(
        new int[][] {
      new int[] {1,2,3, 4,5,6, 7,8,9},
      new int[] {1,2,3, 4,5,6, 7,8,9},
      new int[] {1,2,3, 4,5,6, 7,8,9},

      new int[] {1,2,3, 4,5,6, 7,8,9},
      new int[] {1,2,3, 4,5,6, 7,8,9},
      new int[] {1,2,3, 4,5,6, 7,8,9},

      new int[] {1,2,3, 4,5,6, 7,8,9},
      new int[] {1,2,3, 4,5,6, 7,8,9},
      new int[] {1,2,3, 4,5,6, 7,8,9}
        });
      Assert.IsFalse(badSudoku1.IsValid());
    }

    [Test]
    public void Test4()
    {
      var badSudoku2 = new SudokuChallange.Sudoku(
        new int[][] {
      new int[] {1,2,3,4,5},
      new int[] {1,2,3,4},

      new int[] {1,2,3,4},
      new int[] {1}
      });
      Assert.IsFalse(badSudoku2.IsValid());
    }

    [Test]
    public void Test5()
    {
      var goodS = new SudokuChallange.Sudoku(
        new int[][] {
      new int[] {9, 7, 3, 5, 8, 1, 4, 2, 6},
      new int[] {5, 2, 6, 4, 7, 3, 1, 9, 8},
      new int[] {1, 8, 4, 2, 9, 6, 7, 5, 3},
      new int[] {2, 4, 7, 8, 6, 5, 3, 1, 9},
      new int[] {3, 9, 8, 1, 2, 4, 6, 7, 5},
      new int[] {6, 5, 1, 7, 3, 9, 8, 4, 2},
      new int[] {8, 1, 9, 3, 4, 2, 5, 6, 7},
      new int[] {7, 6, 5, 9, 1, 8, 2, 3, 4},
      new int[] {4, 3, 2, 6, 5, 7, 9, 8, 1}
      });
      Assert.IsTrue(goodS.IsValid());
    }

    [Test]
    public void Test6()
    {
      var notgoodS = new SudokuChallange.Sudoku(
        new int[][] {
      new int[] {9, 7, 3, 5, 8, 1, 4, 2, 6},
      new int[] {5, 2, 6, 4, 7, 3, 1, 9, 8},
      new int[] {1, 8, 1, 2, 9, 6, 7, 5, 3},  //row not valid and first area not valid
      new int[] {2, 4, 7, 8, 6, 5, 3, 1, 9},
      new int[] {3, 9, 8, 1, 2, 4, 6, 7, 5},
      new int[] {6, 5, 1, 7, 3, 9, 8, 4, 2},
      new int[] {8, 1, 9, 3, 4, 2, 5, 6, 7},
      new int[] {7, 6, 5, 9, 1, 8, 2, 3, 4},
      new int[] {4, 3, 2, 6, 5, 7, 9, 8, 1}
      });
      Assert.IsFalse(notgoodS.IsValid());
    }

    [Test]
    public void Test7()
    {
      var notgoodS = new SudokuChallange.Sudoku(
        new int[][] {
      new int[] {9, 7, 3, 5, 8, 1, 4, 2, 6},
      new int[] {5, 2, 6, 4, 7, 3, 1, 9, 8},
      new int[] {1, 8, 4, 2, 9, 6, 7, 5, 3},
      new int[] {2, 4, 7, 8, 6, 5, 3, 1, 9},
      new int[] {3, 9, 8, 1, 2, 4, 6, 7, 5},
      new int[] {6, 1, 1, 7, 3, 9, 8, 4, 2}, // row not valid and second area not valid
      new int[] {8, 1, 9, 3, 4, 2, 5, 6, 7},
      new int[] {7, 6, 5, 9, 1, 8, 2, 3, 4},
      new int[] {4, 3, 2, 6, 5, 7, 9, 8, 1}
      });
      Assert.IsFalse(notgoodS.IsValid());
    }

    [Test]
    public void Test8()
    {
      var notGoodS = new SudokuChallange.Sudoku(
        new int[][] {
      new int[] {9, 7, 3, 5, 8, 1, 4, 2, 6},
      new int[] {5, 8, 2, 4, 7, 3, 1, 9, 8}, // row not ok
      new int[] {1, 6, 4, 2, 9, 6, 7, 5, 3}, // row not ok
      new int[] {2, 4, 7, 8, 6, 5, 3, 1, 9},
      new int[] {3, 9, 8, 1, 2, 4, 6, 7, 5},
      new int[] {6, 5, 1, 7, 3, 9, 8, 4, 2},
      new int[] {8, 1, 9, 3, 4, 2, 5, 6, 7},
      new int[] {7, 6, 5, 9, 1, 8, 2, 3, 4},
      new int[] {4, 3, 2, 6, 5, 7, 9, 8, 1}
      });
      Assert.IsFalse(notGoodS.IsValid());
    }

    [Test]
    public void Test9()
    {
      var notGoodS = new SudokuChallange.Sudoku(
      new int[][] {
      new int[] {1, 1, 1},
      new int[] {1, 1, 1},
      new int[] {1, 1, 1}
      });
      Assert.IsFalse(notGoodS.IsValid());
    }

    [Test]
    public void Test10()
    {
      var g = new SudokuChallange.Sudoku(
        new int[][] {
          new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 },
          new int[]{ 2, 3, 1, 5, 6, 4, 8, 9, 7},
          new int[]{ 3, 1, 2, 6, 4, 5, 9, 7, 8 },
          new int[]{ 4, 5, 6, 7, 8, 9, 1, 2, 3 },
          new int[]{ 5, 6, 4, 8, 9, 7, 2, 3, 1 },
          new int[]{ 6, 4, 5, 9, 7, 8, 3, 1, 2 },
          new int[]{ 7, 8, 9, 1, 2, 3, 4, 5, 6 },
          new int[]{ 8, 9, 7, 2, 3, 1, 5, 6, 4 },
          new int[]{ 9, 7, 8, 3, 1, 2, 6, 4, 5 }
          });
      Assert.IsFalse(g.IsValid());
    }

    [Test]
    public void Test11()
    {
      var g = new SudokuChallange.Sudoku(
       new int[][] {
          new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 },
          new int[]{ 2, 3, 1, 5, 6, 4, 8, 9, 7},
          new int[]{ 3, 1, 2, 6, 4, 5, 9, 7, 8 },
          new int[]{ 4, 5, 6, 7, 8, 9, 1, 2, 3 },
          new int[]{ 5, 6, 4, 8, 9, 7, 2, 3, 1 },
          new int[]{ 6, 4, 5, 9, 7, 8, 3, 1, 2 },
          new int[]{ 7, 8, 9, 1, 2, 3, 4, 5, 6 },
          new int[]{ 8, 9, 7, 2, 3, 1, 5, 6, 4 }
         });
      Assert.IsFalse(g.IsValid());
    }

    [Test]
    public void Test12()
    {
      var g = new SudokuChallange.Sudoku(
       new int[][] {
          new int[]{ 1, 2, 4, 5, 6, 7, 8, 9 },
          new int[]{ 2, 3, 5, 6, 4, 8, 9, 7 },
          new int[]{ 3, 1, 6, 4, 5, 9, 7, 8 },
          new int[]{ 4, 5, 7, 8, 9, 1, 2, 3 },
          new int[]{ 5, 6, 8, 9, 7, 2, 3, 1 },
          new int[]{ 6, 4, 9, 7, 8, 3, 1, 2 },
          new int[]{ 7, 8, 1, 2, 3, 4, 5, 6 }
         });
      Assert.IsFalse(g.IsValid());
    }

    [Test]
    public void Test13()
    {
      var g = new SudokuChallange.Sudoku(
       new int[][] {
          new int[]{ 1, 1, 1, 1, 1, 1, 1, 1},
          new int[]{ 1, 1, 1, 1, 1, 1, 1, 1},
          new int[]{ 1, 1, 1, 1, 1, 1, 1, 1},
          new int[]{ 1, 1, 1, 1, 1, 1, 1, 1}
         });
      Assert.IsFalse(g.IsValid());
    }

    [Test]
    public void Test14()
    {
      var g = new SudokuChallange.Sudoku(
       new int[][] {
          new int[]{ 1, '1', 1, 1, 1, 1, 1, 1},
          new int[]{ 1, 1, 1, 1, 1, 1, 1, 1},
          new int[]{ 1, 1, 1, 1, 1, 1, 1, 1},
          new int[]{ 1, 1, 1, 1, 1, 1, 1, 1}
         });
      Assert.IsFalse(g.IsValid());
    }
  }
}