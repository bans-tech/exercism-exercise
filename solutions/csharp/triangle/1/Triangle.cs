public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {       
        if (!IsValidTriangle(side1, side2, side3))
        {
            return false;
        }
        else
        {            
            if ((side1 != side2) && (side1 != side3) && (side2 != side3))
            {
                return true;
            }
        }
        return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (!IsValidTriangle(side1, side2, side3))
        {
            return false;
        }
        else
        {
            if ((side1 == side2)|| (side1 == side3) || (side2 == side3))
            {
                return true;
            }
            else
            {            
                return false;
            }
        }
        return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {        
        if (!IsValidTriangle(side1, side2, side3))
        {
            return false;
        }
        else 
        {
            if ((side1 == side2) && (side1 == side3))
            {
                return true;
            }        
            else
            {
                return false;
            }    
        }        
    }

    public static bool IsValidTriangle(double side1, double side2, double side3)
    {
        return (side1 + side2 > side3)&&(side2 + side3 > side1)&&(side1 + side3 > side2);
    }
}