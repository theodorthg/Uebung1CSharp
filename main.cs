using System;

namespace mySpace {

  class MainClass {

    public static void Main (string[] args) {
      // String aaa;
      // aaa = Console.ReadLine();
      // Console.WriteLine(aaa);

      Mensch bernd = new Mensch("Bernd", "Birkicht", 55, "blaugrün");

      Mensch julian = new Mensch("Julian", "Dieskau", 15, "rot");

      bernd.showAttr();
      julian.showAttr();
      // Console.WriteLine ("Hello World");
      // Console.ReadLine();
    }
  }
}
