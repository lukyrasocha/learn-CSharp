using basicsyntax;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello World!");
        test();

    }

    static void test() {
        MyClass obj = new MyClass();
        obj.func();
        int c = obj.add(5,10);
        Console.WriteLine(c);
        obj.testSyntax();
    }
}