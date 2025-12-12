
namespace Program;

class Complex
{
    // z = a + bi
    private int a;
    private int b;

    public Complex(int a, int b)
    {
        this.a = a;

        if (b == 0)
        {
            Console.WriteLine("Ошибка! Комплексная часть не может быть равна 0!");
            this.b = 1;
        }
        this.b = b;
    }
    
    public Complex()
    {
        this.a = 0;
        this.b = 1;
    }
    
    public override string ToString()
    {
        if (b < 0) return $"{a} - {Math.Abs(b)}i";
        
        return $"{a} + {b}i";
    }


    public static Complex AddComplexNumbers(Complex firstNumber, Complex secondNumber)
    {
        Complex newNumber = new Complex();
        newNumber.a = firstNumber.a + secondNumber.a;
        newNumber.b = firstNumber.b + secondNumber.b;

        return newNumber;
    }
    
    public static Complex MinusComplexNumbers(Complex firstNumber, Complex secondNumber)
    {
        Complex newNumber = new Complex();
        newNumber.a = firstNumber.a - secondNumber.a;
        newNumber.b = firstNumber.b - secondNumber.b;

        return newNumber;
    }
    
    public static Complex MultComplexNumbers(Complex firstNumber, Complex secondNumber)
    {
        Complex newNumber = new Complex();
        newNumber.a = firstNumber.a * secondNumber.a + firstNumber.b * secondNumber.b * (-1);
        newNumber.b = firstNumber.a * secondNumber.b + firstNumber.b * secondNumber.a;

        return newNumber;
    }
    
    public static Complex operator+(Complex complex1, Complex complex2)
    {
        return Complex.AddComplexNumbers(complex1, complex2);
    }
    public static Complex operator-(Complex complex1, Complex complex2)
    {
        return Complex.MinusComplexNumbers(complex1, complex2);
    }
    public static Complex operator*(Complex complex1, Complex complex2)
    {
        return Complex.MultComplexNumbers(complex1, complex2);
    }
}