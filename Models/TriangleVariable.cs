using System;
namespace Triangle.Models
{

  public class TriangleVariable
  {
    private int _length1;
    private int _length2;
    private int _length3;

    public string blah;
    public string equilateral = "Equilateral";
    public string scalene = "Scalene";
    public string isosceles = "Isosceles";

    public void SetTriangle(string newLength1, string newLength2, string newLength3)
    {
      if (newLength1 == "" || newLength2 == "" || newLength3 == "") {
        blah = "You left something blank please try again.";
      }else{
        _length1 = int.Parse(newLength1);
        _length2 = int.Parse(newLength2);
        _length3 = int.Parse(newLength3);
      }
    }


    public string Alert(){
      return blah;
    }

    public int GetLength1()
    {
      return _length1;
    }

    public int GetLength2()
    {
      return _length2;
    }

    public int GetLength3()
    {
      return _length3;
    }

    public string TriangleOne()
    {
      if (_length1 == _length2 && _length1 == _length3) {
        return equilateral;
      } else if (_length1 != _length2 && _length2 != _length3) {
        return scalene;
      } else if (_length1 == _length2 && _length1 != _length3) {
        return isosceles;
      }
      return TriangleOne();
    }

  }
}
