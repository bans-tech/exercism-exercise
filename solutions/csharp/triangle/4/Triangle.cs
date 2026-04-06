public static class Triangle
{
    // These methods use Expression-body members.
    // a, b, c represent the sides of the triangle.
    
    public static bool IsScalene(double a, double b, double c) =>
        IsValidTriangle(a,b,c) && ((a != b) && (a != c) && (b != c));

    public static bool IsIsosceles(double a, double b, double c) =>
        IsValidTriangle(a,b,c) && ((a == b)||(b == c)||(a == c));

    public static bool IsEquilateral(double a, double b, double c) =>
        IsValidTriangle(a,b,c) && ((a == b)&&(a == c));

    //Helper method
    public static bool IsValidTriangle(double a, double b, double c) => (a + b > c)&&(b + c > a)&&(a + c > b);
    
}