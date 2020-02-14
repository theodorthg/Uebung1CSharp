using System;

namespace mySpace {

  class Mensch {

    private String name;
    private String surname;
    private int age;
    private String eyecolor;

    public Mensch(String myName, String mySurename, int myAge, String myEyecolor) {

      name = myName;
      surname = mySurename;
      age = myAge;
      eyecolor = myEyecolor;
      
    }

    public Mensch(String myName, int myAge, String myEyecolor) {

      name = myName;
      age = myAge;
      eyecolor = myEyecolor;
      
    }

    public void showAttr() {

      if (surname != null) {
        Console.Write("Ich heisse " + name + " " + surname + " und bin " + age + " Jahre alt. Meine Augenfarbe ist " + eyecolor + ".\n");  
      } else {
        Console.Write("Ich heisse " + name + " " + surname + " und bin " + age + " Jahre alt. Meine Augenfarbe ist " + eyecolor + ".\n");
      }
    }
  }
}